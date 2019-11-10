Public Class LabelManipulation
    Public Shared Sub CheckLabelVisibility(Container As Control, Value As String, ByRef blCurrentState As Boolean, ByRef blDesiredState As Boolean, ByVal strVarType As String)
        'This sub checks Controls to see if they contain a specific string in their assigned name
        'Then if switches their visibility if their visibility is in an undesired state. 
        'For example if the visibility is set to True and the desired state is False, it will flip.
        'If the visibility is set to false and the desired state false it will do nothing!
        'Recursively checks child elements as well.
        'ATTENTION PROFESSOR THOMAS, I DO NOT KNOW HOW I FIGURED THIS OUT  AND I CANNOT RECREATE MY THOUGHT PROCESS BUT IT WORKS, WHY?
        Dim varValue As String

        strVarType = strVarType.ToLower()
        If strVarType = "string" Then
            varValue = ""
        Else
            varValue = "0"
        End If

        For Each C As Control In Container.Controls
            If TypeOf C Is Label AndAlso CType(C, Label).Name.Contains(Value) Then
                If C.Visible = blCurrentState Then
                    C.Visible = blDesiredState
                End If
            ElseIf C.HasChildren Then
                CheckLabelVisibility(C, Value, blCurrentState, blDesiredState, strVarType)
            End If

            If TypeOf C Is TextBox AndAlso CType(C, TextBox).Name.Contains(Value) Then
                'With Text boxes you want them to lose thier value when they hide
                If blDesiredState = False Then
                    C.Text = varValue
                End If
                If C.Visible = blCurrentState Then
                    C.Visible = blDesiredState
                ElseIf C.HasChildren Then
                    CheckLabelVisibility(C, Value, blCurrentState, blDesiredState, strVarType)
                End If
            End If
        Next
    End Sub


    Public Shared Sub ClearLabelsOnTblLyOut(ByVal strArray As String(), ByRef tblLayoutName As System.Windows.Forms.TableLayoutPanel)
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


End Class
