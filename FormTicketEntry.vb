' Program:                Concert Tickets 
' Author:                 Dave Babler
' Date:                   2019-11-03
' Purpose:                Produces a summary report showing total revuneu, number of charters, and average hours per charter based on user input
' Colors used:            #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc) Fluorescent Magenta
'                         #00ccff|rgb(0, 204, 255) Electric Blue
'                         #ccff00|rgb(204, 255, 0) Electric Lime
'                         End split complementary color scheme
'                         Standard Windows colors: Black, Gainsboro
' Assignment Paramaters:  Create a project to keep track of concert ticket sales using arrays. 
'                         Ticket prices are based On seating location. Display the ticket price schedule On a form. 
'                         Calculate the price For Each sale, accumulating the total number Of tickets sold For Each section In an array; 
'                         print a summary Of all sales, include total tickets And $ In summary.


'dynamic text box generation https://stackoverflow.com/questions/11827527/how-to-get-value-in-dynamic-generated-textbox
'hiding table layout panel columns & rows https://stackoverflow.com/questions/3290414/hide-and-show-a-cell-of-the-tablelayoutpanel

Public Class frmTicketEntryMain



    Dim strSectionLabelsTicket(intSectOrig) As String
    Dim strSectionIncome(intSectOrig) As String
    Dim strSectionCumulation(intSectOrig) As String

    Public strSectionNames As String() = {"Orchestra", "Mezzanine", "General", "Balcony"}
    Public decPrices As Decimal() = {40.0, 27.5, 15.0, 10.0}

    Dim intSectOrig As Integer = strSectionNames.Count() - 1  'don't forget to subtract 1 to dim the array holy god that was awful

    Private Sub ShowSubTotal(boolShow As Boolean)
        If boolShow = True Then
            lblSubtotal.Visible = True
            lblSubtotalOut.Text = GlobalClass.decTicketSubTotal.ToString("N2")
            lblSubtotalOut.Visible = True
        Else
            lblSubtotal.Visible = False
            lblSubtotalOut.Visible = False
        End If

    End Sub
    Private Sub frmTicketEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dictionary is populated on splash screen!!!!
        GlobalClass.PopulateListBoxWithDictionary(lstSeatLocations, GlobalClass.dicSeatingPrices)

        'Wipe all the labels and text boxes that have holding patterns



        strSectionLabelsTicket = ArrayManipulation.StringArraySuffixer(strSectionNames, "Out")
        strSectionIncome = ArrayManipulation.StringArraySuffixer(strSectionNames, "PriceOut")
        strSectionCumulation = ArrayManipulation.StringArraySuffixer(strSectionNames, "CumulativeOut")

        TextBoxManipulation.ClearTableLayoutTextBoxByChunk(strSectionNames, tbllyQuantity)
        LabelManipulation.ClearLabelsOnTblLyOut(strSectionLabelsTicket, TicketSummary.tblyTicketSummary)
        LabelManipulation.ClearLabelsOnTblLyOut(strSectionLabelsTicket, CumulativeTicketSummary.tblyCumulative)
        LabelManipulation.ClearLabelsOnTblLyOut(strSectionIncome, CumulativeTicketSummary.tblyCumulative)
        LabelManipulation.ClearLabelsOnTblLyOut(strSectionCumulation, CumulativeTicketSummary.tblyCumulative)
        GlobalClass.ClearSpecificIndividualControls()


    End Sub

    Private Sub lstSeatLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeatLocations.SelectedIndexChanged
        'This does visual and some mathmatical logic when the selection is changed, it also unlocks the confirm quantities button.
        btnConfirmQty.Enabled = True
        Dim strUnselected As String = ""
        Dim strSelectedValue As String = ""
        For i As Integer = 0 To lstSeatLocations.Items.Count - 1
            If lstSeatLocations.SelectedIndices.Contains(i) Then
                strSelectedValue = lstSeatLocations.Items(i).ToString()
                LabelManipulation.CheckLabelVisibility(Me, strSelectedValue, False, True, "integer")
                'GlobalClass.ReduceTableLayoutRowPercent(tbllyQuantity, i, "grow")   BRILLIANT PLAN WAS A FAILURE!!!

            End If


            If Not lstSeatLocations.SelectedIndices.Contains(i) Then
                '  Console.WriteLine("Not Selected" & i.ToString() & " the value is: " & lstSeatLocations.Items(i).ToString())

                strUnselected = lstSeatLocations.Items(i).ToString()
                LabelManipulation.CheckLabelVisibility(Me, strUnselected, True, False, "integer")
                'GlobalClass.ReduceTableLayoutRowPercent(tbllyQuantity, i, "reduce")  BRILLIANT PLAN WAS A FAILURE!!!



            End If

        Next



    End Sub

    Private Sub btnConfirmQty_Click(sender As Object, e As EventArgs) Handles btnConfirmQty.Click

        Try
            TextBoxManipulation.SaveTableLayOutTextBoxToArray(strSectionNames,
                                                              tbllyQuantity,
                                                              GlobalClass.intTotalPerSection)
        Catch ex As Exception
            GlobalClass.UserErrorMessage("You must enter a whole number", "Data Type Error")
        End Try

        If txtTicketPurchaser.Text = "" Then
            GlobalClass.UserErrorMessage("You must enter in the purchaser's name to proceed", "Please fill in the form!")
            txtTicketPurchaser.Focus()

        Else
            GlobalClass.strTicketPurchaser = txtTicketPurchaser.Text.ToString()
        End If
        btnPrintReceipt.Enabled = True
        GlobalClass.intSubTotalNumTicks = ArrayManipulation.ArrayTotaler(GlobalClass.intTotalPerSection)
        ArrayManipulation.ArrayPopulatorFromDictionary(GlobalClass.intTotalPerSection,
                                                       GlobalClass.decSubtotalPerSection,
                                                       strSectionNames,
                                                       GlobalClass.dicSeatingPrices)
        GlobalClass.decTicketSubTotal = ArrayManipulation.ArrayTotaler(GlobalClass.decSubtotalPerSection)
        ShowSubTotal(True)
        ArrayManipulation.ArrayToArrayTotaler(GlobalClass.decSubtotalPerSection, GlobalClass.decCumulativePerSection)
        ArrayManipulation.ArrayToArrayTotaler(GlobalClass.intTotalPerSection, GlobalClass.intCumulativePurchPerSection)
        GlobalClass.decTicketsGrandTotal = ArrayManipulation.ArrayTotaler(GlobalClass.decCumulativePerSection)


    End Sub

    Private Sub ResetAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllDataToolStripMenuItem.Click
        'Verify the customer wants to totaly remove all data before you do it!
        Dim strAnswer = MsgBox("Are you sure you want to Clear All Data?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "This purges all stored data!")
        If strAnswer = vbYes Then
            GlobalClass.WipeValues()
            btnPrintReceipt.Enabled = False
            lstSeatLocations.ClearSelected()
            'close section entries

            strSectionLabelsTicket = ArrayManipulation.StringArraySuffixer(strSectionNames, "Out")
            strSectionIncome = ArrayManipulation.StringArraySuffixer(strSectionNames, "PriceOut")
            strSectionCumulation = ArrayManipulation.StringArraySuffixer(strSectionNames, "CumulativeOut")

            TextBoxManipulation.ClearTableLayoutTextBoxByChunk(strSectionNames, tbllyQuantity)
            LabelManipulation.ClearLabelsOnTblLyOut(strSectionLabelsTicket, TicketSummary.tblyTicketSummary)
            LabelManipulation.ClearLabelsOnTblLyOut(strSectionLabelsTicket, CumulativeTicketSummary.tblyCumulative)
            LabelManipulation.ClearLabelsOnTblLyOut(strSectionIncome, CumulativeTicketSummary.tblyCumulative)
            LabelManipulation.ClearLabelsOnTblLyOut(strSectionCumulation, CumulativeTicketSummary.tblyCumulative)
            GlobalClass.ClearSpecificIndividualControls()
            ClearTicketEntryControls()
        End If
    End Sub






    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTicketEntryControls()



    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub


    Public Shared Sub ClearTicketEntryControls()
        'This clears some individual labels and textboxes that don't really properly fit into an array 
        'THIS IS ONLY for frmTicketEntry but will be folded into other subs
        frmTicketEntryMain.txtTicketPurchaser.Clear()
        frmTicketEntryMain.lblSubtotalOut.Text = ""

        frmTicketEntryMain.lstSeatLocations.ClearSelected()
        'close section entries
        For i As Integer = 0 To frmTicketEntryMain.lstSeatLocations.Items.Count - 1

            LabelManipulation.CheckLabelVisibility(frmTicketEntryMain, frmTicketEntryMain.strSectionNames(i), True, False, "integer")
        Next i
    End Sub

    Private Sub btnConfirmQty_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirmQty.MouseEnter
        If btnConfirmQty.Enabled = True Then
            GlobalClass.ButtonFlashHover(btnConfirmQty, False)
        End If
    End Sub

    Private Sub btnConfirmQty_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirmQty.MouseLeave
        If btnConfirmQty.Enabled = True Then
            GlobalClass.ButtonFlashHover(btnConfirmQty, True)
        End If
    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        GlobalClass.boolUnockCumulativeReport = True 'unlock the ability to see the cumulative report
        TicketSummary.Show()
    End Sub
    Private Sub PrintTicketDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTicketDataToolStripMenuItem.Click
        GlobalClass.boolUnockCumulativeReport = True 'unlock the ability to see the cumulative report
        TicketSummary.Show()

    End Sub

    Private Sub PrintCumulativeSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintCumulativeSummaryToolStripMenuItem.Click
        If GlobalClass.boolUnockCumulativeReport = True Then
            CumulativeTicketSummary.Show()
        Else
            GlobalClass.UserErrorMessage("Sorry you must first print a receipt, to show you've made a sale.", "Have you sold anything?")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim areYouSure = MsgBox("Are you sure you want to quit?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "This quits!")
        If areYouSure = vbYes Then
            Me.Close()
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim areYouSure = MsgBox("Are you sure you want to quit?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "This quits!")
        If areYouSure = vbYes Then
            Me.Close()
        End If

    End Sub
End Class
