﻿' Program:                Yachts 
' Author:                 Dave Babler
' Date:                   2019-11-03
' Purpose:                Produces a summary report showing total revuneu, number of charters, and average hours per charter based on user input
' Colors used:            #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc) Fluorescent Magenta
'                         #00ccff|rgb(0, 204, 255) Electric Blue
'                         #ccff00|rgb(204, 255, 0) Electric Lime
'                         End split complementary color scheme
'                         Standard Windows colors: Black, Gainsboro
' Assignment Paramaters:  Create a project to input boat chartering and produce a summary report showing total revenue, number of charters, and average hours per charter. 
'                         User will input party name & hours wanted, Select yacht type & length (dropdown combo boxes), Then cost will be calculated And displayed With OK button.
'                         Menu bar sample With hotkeys & shortcuts
'                         ______________________________________________________________________________________________
'                         Ability to: add/ remove a yacht type, list count Of types, print a list/report of all types. 
'                         Summary Report includes:  # charters, total revenue, average hours chartered, And programmer name. 
'                         Yacht Type Report will list the yacht types in the combo box with programmer name And title at top.

'dynamic text box generation https://stackoverflow.com/questions/11827527/how-to-get-value-in-dynamic-generated-textbox
'hiding table layout panel columns & rows https://stackoverflow.com/questions/3290414/hide-and-show-a-cell-of-the-tablelayoutpanel

Public Class frmTicketEntryMain


    Public strSectionNames As String() = {"Orchestra", "Mezzanine", "General", "Balcony"}
    Public decPrices As Decimal() = {40.0, 27.5, 15.0, 10.0}
    Private Sub frmTicketEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dictionary is populated on splash screen!!!!
        GlobalClass.PopulateListBoxWithDictionary(lstSeatLocations, GlobalClass.dicSeatingPrices)
    End Sub

    Private Sub lstSeatLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeatLocations.SelectedIndexChanged

        Dim strUnselected As String = ""
        Dim strSelectedValue As String = ""
        For i As Integer = 0 To lstSeatLocations.Items.Count - 1
            If lstSeatLocations.SelectedIndices.Contains(i) Then
                strSelectedValue = lstSeatLocations.Items(i).ToString()
                GlobalClass.CheckLabels(Me, strSelectedValue, False, True)
                'GlobalClass.ReduceTableLayoutRowPercent(tbllyQuantity, i, "grow")   BRILLIANT PLAN WAS A FAILURE!!!

            End If


            If Not lstSeatLocations.SelectedIndices.Contains(i) Then
                '  Console.WriteLine("Not Selected" & i.ToString() & " the value is: " & lstSeatLocations.Items(i).ToString())

                strUnselected = lstSeatLocations.Items(i).ToString()
                GlobalClass.CheckLabels(Me, strUnselected, True, False)
                'GlobalClass.ReduceTableLayoutRowPercent(tbllyQuantity, i, "reduce")  BRILLIANT PLAN WAS A FAILURE!!!



            End If

        Next



    End Sub

    Private Sub btnConfirmQty_Click(sender As Object, e As EventArgs) Handles btnConfirmQty.Click
        If txtTicketPurchaser.Text = "" Then
            GlobalClass.UserErrorMessage("You must enter in the purchaser's name to proceed", "Please fill in the form!")
            txtTicketPurchaser.Focus()

        Else

        End If

        Console.WriteLine("{0:C}", decPrices(1))
        For Each pair In GlobalClass.dicSeatingPrices
            Console.WriteLine("{0} | {1:C}", pair.Key, pair.Value)
        Next
    End Sub

    Private Sub ResetAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllDataToolStripMenuItem.Click
        'Verify the customer wants to totaly remove all data before you do it!
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        TicketSummary.Show()
        Dim strValue As String = "General"
        'Dim ctrl As Control
        'For Each ctrl In Me.Controls
        '    If (ctrl.GetType() Is GetType(TextBox)) Then
        '        Dim txt As TextBox = CType(ctrl, TextBox)
        '        txt.Clear()
        '    End If
        'Next
        'GlobalClass.ClearAllTextLabel(Me, "TextBox", strSectionNames)  This works but let's try more
        For y As Integer = 0 To TicketSummary.tblyTicketSummary.RowCount - 1

            For x As Integer = 0 To TicketSummary.tblyTicketSummary.ColumnCount - 1
                Dim lb As Label = TryCast(TicketSummary.tblyTicketSummary.GetControlFromPosition(x, y), Label)

                If lb IsNot Nothing Then
                    If lb.Name.Contains(strValue) Then
                        lb.Text = "NOTHING"
                    End If
                End If
            Next
        Next




        For y As Integer = 0 To Me.tbllyQuantity.RowCount - 1

            For x As Integer = 0 To Me.tbllyQuantity.ColumnCount - 1
                Dim tb As TextBox = TryCast(Me.tbllyQuantity.GetControlFromPosition(x, y), TextBox)

                If tb IsNot Nothing Then

                    tb.Text = "NOTHING"

                End If
            Next
        Next





        Dim intSectOrig As Integer = strSectionNames.Count() - 1  'don't forget to subtract 1 to dim the array holy god that was awful


        Dim strSectionLabelsTicket(intSectOrig) As String

        strSectionLabelsTicket = ArrayManipulation.StringArraySuffixer(strSectionNames, "Out")


        GlobalClass.ClearLabelsOnTblLyOut(strSectionLabelsTicket, TicketSummary.tblyTicketSummary)

    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnConfirmQty_MouseHover(sender As Object, e As EventArgs) Handles btnConfirmQty.MouseHover
        GlobalClass.ButtonFlash(btnConfirmQty)
    End Sub
End Class
