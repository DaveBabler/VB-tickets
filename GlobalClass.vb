Public Class GlobalClass
    Public Shared dicSeatingPrices As New Dictionary(Of String, Decimal)

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
