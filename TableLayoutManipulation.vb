Public Class TableLayoutManipulation



    Public Shared Sub CheckLabelVisibilityOnTableLayout(ByVal strArray As String(), ByRef tblLayoutName As System.Windows.Forms.TableLayoutPanel)
        'This sub clears labels that exist on a TableLayOutPanel which involves some more work than simple label clearing
        'This was a nightmare to figure out--Dave Babler
        Dim strValue As String = ""
        For y As Integer = 0 To tblLayoutName.RowCount - 1
            For x As Integer = 0 To tblLayoutName.ColumnCount - 1
                Dim lb As Label = TryCast(tblLayoutName.GetControlFromPosition(x, y), Label)

                If lb IsNot Nothing Then
                    For q As Integer = 0 To strArray.Count - 1
                        strValue = strArray(q)
                        If lb.Name.Contains(strValue) Then
                            lb.Text = ""
                        End If
                    Next q

                End If

            Next x
        Next y

    End Sub



    Public Shared Sub ReduceTableLayoutRowPercent(ByRef tblLyToChange As TableLayoutPanel, ByVal intRowToModify As Integer, ByVal strDoWhat As String)
        'THIS WAS SUPPOSED TO BE AWESOME IT WAS SUPPOSED TO ACTUALLY SMUSH THE LABELS TOGETHER BASED UPON SELECTS BUT NO IT WOULDN'T WORK!!!
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



    'Public Shared Sub ShowTblRowsBasedOnString(ByVal strLookup As String)
    ''DEPRECIATED!!!! 
    '    'In theory this will display or hide table rows based upon the name passed on a dictionary 
    '    'this name should be part of the labels name on the form 
    '    'the index should correspond to the dictionary assuming the developer put things in alphabetical order
    '    'which means it can be used to hide table rows.


    '    For Each label In frmTicketEntryMain.Controls.OfType(Of Label).Where(Function(x) x.Name.Contains(strLookup))  'lambda expressions, which I only kinda sorta understand  
    '        If label.Visible = False Then
    '            label.Visible = True
    '        End If
    '    Next

    '    For Each txtBox In frmTicketEntryMain.Controls.OfType(Of TextBox).Where(Function(f) f.Name.Contains(strLookup))
    '        If txtBox.Visible = False Then
    '            txtBox.Visible = True
    '        End If
    '    Next
    'End Sub
End Class
