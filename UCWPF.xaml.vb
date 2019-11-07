Public Class UCWPF
    Private Sub OnUnselected(ByVal sender As Object, ByVal e As Windows.RoutedEventArgs)
        Dim lbi As Windows.Controls.ListBoxItem = TryCast(e.Source, Windows.Controls.ListBoxItem)

        If lbi IsNot Nothing Then
            Console.WriteLine(lbi.Content.ToString() & " is unselected.")
        End If
    End Sub
    Private Sub Ucwpf2lstwpfSeating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstwpfSeating.SelectionChanged
        For x = 0 To lstwpfSeating.SelectedItems.Count() - 1
            If lstwpfSeating.SelectedItem IsNot Nothing Then
                Console.WriteLine(lstwpfSeating.SelectedIndex.ToString())
                Console.WriteLine("Has " & (lstwpfSeating.SelectedItems.Count.ToString()) & " item(s) selected.")


            End If
            ' For Each ob In lstwpfSeating.SelectedItems
            'If CInt(ob) = x Then
            '    Console.WriteLine("We have  {0} as ob and {1} as x", ob, x)
            '    ' intLastActiveIndexes.Concat(ob).ToArray
            '    Console.WriteLine("Nex should be like the array or what")
            '    '   Console.WriteLine(intLastActiveIndexes(x).ToString())
            'End If
            If lstwpfSeating.SelectedItems.Count() > 0 Then
                Console.WriteLine(lstwpfSeating.SelectedItem.ToString())
            End If

            'Next ob
        Next x
        Dim j = 0

        For i As Integer = 0 To lstwpfSeating.Items.Count - 1
            If lstwpfSeating.Items(i) Is lstwpfSeating.SelectedItems(0) Then j += 1
        Next

        Console.WriteLine(lstwpfSeating.Items.IndexOf(lstwpfSeating.SelectedItems(0)).ToString & String.Format(vbCrLf & "There are {0} occurences of this object in this list", j))

    End Sub
    Private Sub fart(ByRef lstb As System.Windows.Controls.ListBox)

    End Sub
End Class
