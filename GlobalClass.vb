Public Class GlobalClass
    Public Shared decTotalPerSection(3) As Decimal
    Public Shared intCumulativePurchPerSection(3) As Integer
    Public Shared decCumulativePerSection(3) As Integer

    Public Shared decTotalGroupWGrandTotal(4) As Decimal 'yes I know you'd think it should be 3 but I'm putting in the grand total as well, for fun!
    Public Shared dicSeatingPrices As New Dictionary(Of String, Decimal)
    Public Shared tblLayout As TableLayoutPanel 'this exists only to shut up the optional paramaters of a sub
    Public Shared strVisibleEntries(3) As String 'visible entries of the form we will wipe the text boxes of the iinvisible ones




    Public Shared Sub ButtonFlash(ByRef btnToModify As Button)
        'Switches the back and forecolor of a button
        btnToModify.BackColor = Color.FromArgb(0, 204, 255)
    End Sub

    Public Shared Sub ClearSpecificIndividualControls()
        'This clears some individual labels and textboxes that don't really properly fit into an array
        frmTicketEntryMain.ClearTicketEntryControls()
        TicketSummary.ClearSummaryFields()
        CumulativeTicketSummary.ClearCumulativeFields()

    End Sub


    Public Shared Sub ClearAllTextLabel(ByRef ctrlContainer As Control, ByVal strLbTxtOrBoth As String, ByVal arrOfNames As String())
        'Due to the nature of the forms it is entirely likely this method will not get used.
        'That being said, it's so well written, and its now going to be part of my permanant visual basic repitoire it can stay for now.

        Dim strValue As String = ""
        For i = 0 To arrOfNames.Count() - 1
            strValue = arrOfNames(i)  'for clarity 
            If strLbTxtOrBoth = "Both" Then
                LabelManipulation.ClearLabelTextByChunk(ctrlContainer, strValue)
                TextBoxManipulation.ClearTextBoxTextByChunk(ctrlContainer, strValue)
            ElseIf strLbTxtOrBoth = "Label" Then
                LabelManipulation.ClearLabelTextByChunk(ctrlContainer, strValue)
            ElseIf strLbTxtOrBoth = "TextBox" Then
                TextBoxManipulation.ClearTextBoxTextByChunk(ctrlContainer, strValue)
                'No Plain "Else" I don't want any accidents on implementation

            End If

        Next i

    End Sub

    Public Shared Sub PopulateListBoxWithDictionary(ByRef lbToPopulate As ListBox, ByVal dicDataToUse As IDictionary)
        ' Sub uses a generic dictionary interface to populate a listbox, clears it first.
        lbToPopulate.Items.Clear()
        For Each pair In dicDataToUse
            lbToPopulate.Items.Add(pair.Key.ToString())  'to string just to be safe.
        Next
    End Sub

    Public Shared Sub PopulateStrDecDictionary(ByVal strArray As String(), ByVal decArray As Decimal(), ByRef dicPopulated As Dictionary(Of String, Decimal))
        Dim intCountStrArray As Integer = strArray.Length
        Dim intCountDecArray As Integer = decArray.Length
        If intCountDecArray = intCountStrArray Then
            For i = 0 To intCountStrArray - 1
                dicPopulated.Add(strArray(i), decArray(i))
            Next i
        Else
            MsgBox("Arrays don't match in length dictionary will not be populated", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Critical program error")
        End If
    End Sub

    Public Shared Sub UserErrorMessage(ByVal strMessage As String, ByVal strTitle As String)
        ' a quick way of sending a popup error box instead of recoding the thing the whole time I am tired of it.
        MsgBox(strMessage, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, strTitle)

    End Sub







End Class
