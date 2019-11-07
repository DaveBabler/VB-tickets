Public Class GlobalClass
    Public Shared dicSeatingPrices As New Dictionary(Of String, Decimal)
    Public Shared tblLayout As TableLayoutPanel 'this exists only to shut up the optional paramaters of a sub
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

    Public Shared Sub PopulateListBoxWithDictionary(ByRef lbToPopulate As ListBox, ByVal dicDataToUse As IDictionary)
        ' Sub uses a generic dictionary interface to populate a listbox, clears it first.
        lbToPopulate.Items.Clear()
        For Each pair In dicDataToUse
            lbToPopulate.Items.Add(pair.Key.ToString())  'to string just to be safe.
        Next
    End Sub

    Public Shared Sub ShowTblRowsBasedOnString(ByVal strLookup As String)
        'In theory this will display or hide table rows based upon the name passed on a dictionary 
        'this name should be part of the labels name on the form 
        'the index should correspond to the dictionary assuming the developer put things in alphabetical order
        'which means it can be used to hide table rows.


        For Each label In frmTicketEntryMain.Controls.OfType(Of Label).Where(Function(x) x.Name.Contains(strLookup))  'lambda expressions, which I only kinda sorta understand  
            If label.Visible = False Then
                label.Visible = True
            End If
        Next

        For Each txtBox In frmTicketEntryMain.Controls.OfType(Of TextBox).Where(Function(f) f.Name.Contains(strLookup))
            If txtBox.Visible = False Then
                txtBox.Visible = True
            End If
        Next
    End Sub
    Public Shared Sub CheckLabels(Container As Control, Value As String, ByRef blCurrentState As Boolean, ByRef blDesiredState As Boolean)
        'This sub checks Controls to see if they contain a specific string in their assigned name
        'Then if switches their visibility if their visibility is in an undesired state. 
        'For example if the visibility is set to True and the desired state is False, it will flip.
        'If the visibility is set to false and the desired state false it will do nothing!
        'Recursively checks child elements as well.
        'ATTENTION PROFESSOR THOMAS, I DO NOT KNOW HOW I FIGURED THIS OUT  AND I CANNOT RECREATE MY THOUGHT PROCESS BUT IT WORKS, WHY?
        For Each C As Control In Container.Controls
            If TypeOf C Is Label AndAlso CType(C, Label).Name.Contains(Value) Then
                If C.Visible = blCurrentState Then
                    C.Visible = blDesiredState
                End If
            ElseIf C.HasChildren Then
                CheckLabels(C, Value, blCurrentState, blDesiredState)
            End If

            If TypeOf C Is TextBox AndAlso CType(C, TextBox).Name.Contains(Value) Then
                If C.Visible = blCurrentState Then
                    C.Visible = blDesiredState
                ElseIf C.HasChildren Then
                    CheckLabels(C, Value, blCurrentState, blDesiredState)
                End If
            End If
        Next
    End Sub

    Public Shared Sub ReduceTableLayoutRowPercent(ByRef tblLyToChange As TableLayoutPanel, ByVal intRowToModify As Integer, ByVal strDoWhat As String)
        Dim decPercent As Decimal = 0.25D
        Dim intNewHeight = CInt(tblLyToChange.Height * decPercent)
        Dim intRow As Integer = intRowToModify
        If strDoWhat = "reduce" Then
            tblLyToChange.RowStyles(intRow).SizeType = SizeType.Absolute
            tblLyToChange.RowStyles(intRow).Height = 0
        ElseIf strDoWhat = "grow" Then
            'Incase we want to add thigns otehr than reduce and grow lets use Else If
            tblLyToChange.RowStyles(intRow).SizeType = SizeType.Percent
            tblLyToChange.RowStyles(intRow).Height = intNewHeight

        End If


    End Sub

End Class
