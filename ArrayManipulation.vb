Public Class ArrayManipulation
    'this class is soley for manipulating arrays 
    ' the class variables are there in case I need to manipulate them or use them as holding tanks
    Public strArray() As String
    Public intArray() As Integer
    Public decArray() As Decimal

    Public Shared Function StringArrayPrefixer(strArrayToManipulate As String(), strPrefix As String) As String()
        Dim i As Integer
        Dim intCount As Integer = strArrayToManipulate.Count()
        Dim strArrayOut(intCount) As String
        For i = 0 To intCount - 1
            strArrayOut(i) = strPrefix & strArrayToManipulate(i)
            Console.WriteLine("String Array value is " & strArrayOut(i))
        Next i
        Return strArrayOut

    End Function

    Public Shared Function StringArraySuffixer(strArrayToManipulate As String(), strSuffix As String) As String()
        Dim i As Integer
        Dim intCount As Integer = strArrayToManipulate.Count()
        Dim strArrayOut(intCount) As String
        For i = 0 To intCount - 1
            strArrayOut(i) = strArrayToManipulate(i) & strSuffix
            Console.WriteLine("String Array value is " & strArrayOut(i))
        Next i
        Return strArrayOut

    End Function




End Class
