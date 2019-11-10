Public Class TextBoxManipulation
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
