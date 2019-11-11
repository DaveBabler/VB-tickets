Public Class TextBoxManipulation
    Public Shared Sub ClearTableLayoutTextBoxByChunk(ByVal strArray As String(), ByRef tblLayoutName As System.Windows.Forms.TableLayoutPanel)
        'loops through and wipes labels if the label name has a specific string 
        'I know we traditionally use lowercase for LCVs but Control is a much more powerful entity than an int so
        'to future debuggers if you cry over this, I'm sorry this upsets you, but know you are loved.

        'This sub clears labels that exist on a TableLayOutPanel which involves some more work than simple label clearing
        'This was a nightmare to figure out--Dave Babler
        Dim strValue As String = ""
        For y As Integer = 0 To tblLayoutName.RowCount - 1
            For x As Integer = 0 To tblLayoutName.ColumnCount - 1
                Dim tb As TextBox = TryCast(tblLayoutName.GetControlFromPosition(x, y), TextBox)

                If tb IsNot Nothing Then
                    For q As Integer = 0 To strArray.Count - 1
                        strValue = strArray(q)
                        Console.WriteLine("String is " & strValue)
                        If tb.Name.Contains(strValue) Then

                            tb.Clear()

                        End If
                    Next q

                End If

            Next x
        Next y
    End Sub


    Public Shared Sub SaveTableLayOutTextBoxToArray(ByVal strArray As String(), ByRef tblLayoutName As System.Windows.Forms.TableLayoutPanel, ByRef intNewArray As Integer())
        'loops through textboxes in a tablelayout and then shoves them in an array
        'this can be overloaded in the future to accomodate decimals with very little effort. Save this to your codebase
        Dim intArrayLength As Integer = (strArray.Count - 1)


        'This sub clears labels that exist on a TableLayOutPanel which involves some more work than simple label clearing
        'This was a nightmare to figure out--Dave Babler
        Dim strValue As String = ""
        For y As Integer = 0 To tblLayoutName.RowCount - 1
            For x As Integer = 0 To tblLayoutName.ColumnCount - 1
                Dim tb As TextBox = TryCast(tblLayoutName.GetControlFromPosition(x, y), TextBox)

                If tb IsNot Nothing Then
                    Console.WriteLine("This is text box name {0}, this is textbox value {1}", tb.Name, tb.Text.ToString())
                    For q As Integer = 0 To strArray.Count - 1
                        strValue = strArray(q)
                        Console.WriteLine("String is " & strValue)
                        If tb.Name.Contains(strValue) Then

                            Int16.TryParse(tb.Text, intNewArray(q))
                            Console.WriteLine("intNewArray is {0}", intNewArray(q).ToString())

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


    '''''''''''''''''''Depreciated functions are below
    '''
    Public Shared Sub ClearTextBox(parent As Control, strValue As String)

        'overload of poorly working clearTextbox 

        For Each child As Control In parent.Controls
            If TypeOf child Is TextBox AndAlso CType(child, TextBox).Name.Contains(strValue) Then
                ClearTextBox(child, strValue)
            End If

        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = ""
        End If

    End Sub





    Public Shared Sub ClearTextBox(parent As Control)

        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If

    End Sub

    '''''''''

End Class
