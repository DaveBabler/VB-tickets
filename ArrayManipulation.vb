Public Class ArrayManipulation
    'this class is soley for manipulating arrays 
    ' the class variables are there in case I need to manipulate them or use them as holding tanks
    Public strArray() As String
    Public intArray() As Integer
    Public decArray() As Decimal

    Public Shared Sub ArrayEndTotal(ByRef arrToTotal As Decimal())
        'This subtotals an array and saves it in the last value of the array 
        'I was going to use this to tabulate my arrays but I decided manipulating jagged arrays was garbage
        Dim decSubtotal = 0D
        Dim i As Integer
        For i = 0 To arrToTotal.Count() - 2

            decSubtotal += arrToTotal(i)

        Next i

        arrToTotal(i) = decSubtotal

    End Sub

    Public Shared Function ArrayTotaler(ByRef arrToTotal As Decimal()) As Decimal
        Dim decSubtotal = 0D
        Dim i As Integer
        For i = 0 To arrToTotal.Count() - 1

            decSubtotal += arrToTotal(i)

        Next i
        Return decSubtotal
    End Function
    Public Shared Function ArrayTotaler(ByRef arrToTotal As Integer()) As Integer
        Dim intSubTotal = 0I
        Dim i As Integer
        For i = 0 To arrToTotal.Count() - 1

            intSubTotal += arrToTotal(i)

        Next i
        Return intSubTotal
    End Function

    Public Shared Function ArrayVisibilityVerifier(strStartingArray() As String) As String()
        Dim strArrayToManipulate(strStartingArray.Count() - 1)
        strArrayToManipulate = strStartingArray 'we don't necissarily want to manipulate the original array and VB will do that
        Return strArrayToManipulate

    End Function

    Public Shared Function StringArrayPrefixer(strArrayToManipulate As String(), strPrefix As String) As String()
        'Uncertain if this will be used but it was an easy copy of the Suffixer so I wanted it on hand, just in case.
        Dim i As Integer
        Dim intCount As Integer = strArrayToManipulate.Count() - 1  'always subtract 1 when Dimming an array based on an array count!
        Dim strArrayOut(intCount) As String
        For i = 0 To intCount
            strArrayOut(i) = strPrefix & strArrayToManipulate(i)

        Next i
        Return strArrayOut

    End Function

    Public Shared Function StringArraySuffixer(strArrayToManipulate As String(), strSuffix As String) As String()
        Dim i As Integer
        Dim intCount As Integer = strArrayToManipulate.Count() - 1 'always subtract 1 when Dimming an array based on an array count!
        Dim strArrayOut(intCount) As String
        For i = 0 To intCount
            strArrayOut(i) = strArrayToManipulate(i) & strSuffix
        Next i
        Return strArrayOut

    End Function



    Public Shared Sub ArrayRemoveEmpty(ByRef strArrayToTrim() As String, ByVal boolWhiteSpaceFlag As Boolean)
        'This finds all the empty elements of an array then trims it 
        'The boolean flag is a helpful flag to determine if we want to count whitespace as null
        Dim intCurrIndex As Integer = (strArrayToTrim.Count - 1)
        Dim arrToManipulate(intCurrIndex) As String
        Dim intNewIndex As Integer = 0
        Dim intLCV As Integer = 0

        arrToManipulate = strArrayToTrim  'may not want to mess with the original array
        If boolWhiteSpaceFlag Then
            If String.IsNullOrEmpty(strArrayToTrim(0)) Or String.IsNullOrWhiteSpace(strArrayToTrim(0)) Then
                'If the first value in the array is something we don't want we're going to bump up i by 1
                intLCV = 1
            End If

            For i = intLCV To intCurrIndex
                If String.IsNullOrEmpty(strArrayToTrim(i)) = False Or String.IsNullOrWhiteSpace(strArrayToTrim(i)) = False Then
                    arrToManipulate(intNewIndex) = strArrayToTrim(i)
                    intNewIndex += 1
                End If


            Next i

        Else
            If String.IsNullOrEmpty(strArrayToTrim(0)) Then
                'If the first value in the array is something we don't want we're going to bump up i by 1
                intLCV = 1
            End If

            For i = intLCV To intCurrIndex
                If String.IsNullOrEmpty(strArrayToTrim(i)) = False Then
                    arrToManipulate(intNewIndex) = strArrayToTrim(i)
                    intNewIndex += 1
                End If

            Next i



        End If
        If intNewIndex > 0 Then
            intNewIndex -= 1
            'gotta remove the straggling digit
        End If
        ReDim Preserve arrToManipulate(intNewIndex)
        Dim intUpperBound As Integer = arrToManipulate.GetUpperBound(0)
        Dim intLength As Integer = arrToManipulate.Length()
        Dim intCount As Integer = arrToManipulate.Count
        For u = 0 To intNewIndex
        Next



    End Sub


End Class
