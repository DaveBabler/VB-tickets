Public Class GlobalClass
    Public Shared decTotalGroupWGrandTotal(4) As Decimal 'yes I know you'd think it should be 3 but I'm putting in the grand total as well, for fun!
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
    Public Shared Sub ClearAllTextLabel(ByRef ctrlContainer As Control, ByVal strLbTxtOrBoth As String, ByVal arrOfNames As String() )
        Dim strValue As String = ""
        For i = 0 To arrOfNames.Count() - 1
            strValue = arrOfNames(i)  'for clarity 
            If strLbTxtOrBoth = "Both" Then
                ClearLabelTextByChunk(ctrlContainer, strValue)
                ClearTextBoxTextByChunk(ctrlContainer, strValue)
            ElseIf strLbTxtOrBoth = "Label" Then
                ClearLabelTextByChunk(ctrlContainer, strValue)
            ElseIf strLbTxtOrBoth = "TextBox" Then
                ClearTextBoxTextByChunk(ctrlContainer, strValue)
                'No Plain "Else" I don't want any accidents on implementation

            End If

        Next i

    End Sub

    Public Shared Sub ClearLabelTextByChunk(ByRef ctrlContainer As Control, strValue As String)
        'loops through and wipes labels if the label name has a specific string 
        'I know we traditionally use lowercase for LCVs but Control is a much more powerful entity than an int so
        'to future debuggers if you cry over this, I'm sorry this upsets you, but know you are loved.

        For Each C As Control In ctrlContainer.Controls
            If TypeOf C Is Label AndAlso CType(C, Label).Name.Contains(strValue) Then
                C.Text = ""

            ElseIf C.HasChildren Then
                ClearLabelTextByChunk(ctrlContainer, strValue)
            End If
        Next C
    End Sub

    Public Shared Sub ClearTableLabelTextByChunk(ByRef ctrlContainer As Control, strValue As String)
        'loops through and wipes labels if the label name has a specific string 
        'I know we traditionally use lowercase for LCVs but Control is a much more powerful entity than an int so
        'to future debuggers if you cry over this, I'm sorry this upsets you, but know you are loved.

        For Each C As Control In ctrlContainer.Controls
            If TypeOf C Is Label AndAlso CType(C, Label).Name.Contains(strValue) Then
                C.Text = ""

            ElseIf C.HasChildren Then
                ClearTableLabelTextByChunk(ctrlContainer, strValue)
            End If
        Next C
    End Sub
    Public Shared Sub ClearLabelsOnTblLyOut(ByVal strArray As String(), ByRef tblLayoutName As System.Windows.Forms.TableLayoutPanel)
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




    Public Shared Sub ClearTextBoxTextByChunk(ByRef ctrlContainer As Control, strValue As String)
        'loops through and wipes TextBoxs if the TextBox name has a specific string 
        'I know we traditionally use lowercase for LCVs but Control is a much more powerful entity than an int so
        'to future debuggers if you cry over this, I'm sorry this upsets you, but know you are loved.

        For Each C As Control In ctrlContainer.Controls
            If TypeOf C Is TextBox AndAlso CType(C, TextBox).Name.Contains(strValue) Then
                If TryCast(C, TextBox) IsNot Nothing Then
                    TryCast(C, TextBox).Text = [String].Empty
                End If

            ElseIf C.HasChildren Then
                ClearTextBoxTextByChunk(ctrlContainer, strValue)
            End If
        Next C
    End Sub

    Public Shared Sub ClearTextBox(parent As Control)

        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If

    End Sub
    Public Shared Sub ClearTextBox(parent As Control, strValue As String)

        For Each child As Control In parent.Controls
            If TypeOf child Is TextBox AndAlso CType(child, TextBox).Name.Contains(strValue) Then
                ClearTextBox(child, strValue)
            End If

        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = ""
        End If

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
    Public Shared Sub ButtonFlash(ByRef btnToModify As Button)
        'Switches the back and forecolor of a button
        btnToModify.BackColor = Color.FromArgb(0, 204, 255)
    End Sub

    Public Shared Sub ArrayEndTotal(ByRef arrToTotal As Decimal())
        'This subtotals an array and saves it in the last value of the array 
        Dim decSubtotal = 0D
        Dim i As Integer
        For i = 0 To arrToTotal.Count() - 2

            decSubtotal += arrToTotal(i)

        Next i

        arrToTotal(i) = decSubtotal

    End Sub

End Class
