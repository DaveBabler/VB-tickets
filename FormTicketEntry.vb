' Program:                Yachts 
' Author:                 Dave Babler
' Date:                   2019-11-03
' Purpose:                Produces a summary report showing total revuneu, number of charters, and average hours per charter based on user input
' Colors used:            #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc) Fluorescent Magenta
'                         #00ccff|rgb(0, 204, 255) Electric Blue
'                         #ccff00|rgb(204, 255, 0) Electric Lime
'                         End split complementary color scheme
'                         Standard Windows colors: Black, Gainsboro
' Assignment Paramaters:  Create a project to input boat chartering and produce a summary report showing total revenue, number of charters, and average hours per charter. 
'                         User will input party name & hours wanted, Select yacht type & length (dropdown combo boxes), Then cost will be calculated And displayed With OK button.
'                         Menu bar sample With hotkeys & shortcuts
'                         ______________________________________________________________________________________________
'                         Ability to: add/ remove a yacht type, list count Of types, print a list/report of all types. 
'                         Summary Report includes:  # charters, total revenue, average hours chartered, And programmer name. 
'                         Yacht Type Report will list the yacht types in the combo box with programmer name And title at top.

'dynamic text box generation https://stackoverflow.com/questions/11827527/how-to-get-value-in-dynamic-generated-textbox
'hiding table layout panel columns & rows https://stackoverflow.com/questions/3290414/hide-and-show-a-cell-of-the-tablelayoutpanel

Public Class frmTicketEntryMain
    Dim strLastActiveSelects(3) As String
    Dim strCurrActiveSelects(3) As String
    Dim strNotSelects(3) As String
    Dim intFlag As Integer = 0 'flag test

    Public strSectionNames As String() = {"Orchestra", "Mezzanine", "General", "Balcony"}
    Public decPrices As Decimal() = {40.0, 27.5, 15.0, 10.0}
    Private Sub frmTicketEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalClass.PopulateStrDecDictionary(Me.strSectionNames, Me.decPrices, GlobalClass.dicSeatingPrices)
        'Dictionary is populated on splash screen!!!!
        GlobalClass.PopulateListBoxWithDictionary(lstSeatLocations, GlobalClass.dicSeatingPrices)
        'Dim host As New ElementHost()
        'host.Dock = DockStyle.Fill

        '' Create the WPF UserControl.
        'Dim uc As New UCWPF


        '' Assign the WPF UserControl to the ElementHost control's
        '' Child property.
        'host.Child = uc

        '' Add the ElementHost control to the form's
        '' collection of child controls.
        'Me.Controls.Add(host)


        GlobalClass.PopulateListBoxWithDictionary(Ucwpf2.lstwpfSeating, GlobalClass.dicSeatingPrices)
    End Sub


    Private Sub lstSeatLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeatLocations.SelectedIndexChanged

        Dim indexList As New List(Of Integer)

        For i As Integer = 0 To lstSeatLocations.Items.Count - 1
            If Not lstSeatLocations.SelectedIndices.Contains(i) Then
                indexList.Add(i)
            End If
        Next

        If indexList.Count > 0 Then
            Dim sb As New System.Text.StringBuilder

            For Each i As Integer In indexList
                sb.AppendLine(lstSeatLocations.Items(i).ToString)
            Next

            If sb.Length > 0 Then
                MessageBox.Show(sb.ToString)
            End If
        End If





        ''''END TESTING METHOD
    End Sub

    Private Sub btnAddQuantities_Click(sender As Object, e As EventArgs) Handles btnAddQuantities.Click

        Console.WriteLine("{0:C}", decPrices(1))
        For Each pair In GlobalClass.dicSeatingPrices
            Console.WriteLine("{0} | {1:C}", pair.Key, pair.Value)
        Next
    End Sub

    Private Sub ResetAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllDataToolStripMenuItem.Click
        'Verify the customer wants to totaly remove all data before you do it!
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GlobalClass.CheckLabels(Me, "Orchestra", True, False)

    End Sub

    Private Sub CheckThatSelect(strForComparison As String, strArrayToLookIn As String())
        'In theory this will hide selections based on assumed variables but it's 20 minutes before the assignment is due and I'm exhausted
        If strArrayToLookIn.Contains(strForComparison) Then
            Console.WriteLine("It's in there!")
        Else
            GlobalClass.CheckLabels(Me, strForComparison, True, False)
        End If

    End Sub
    Private Sub List0_BeforeUpdate(Cancel As Integer, ByVal List0 As ListBox)
        ''This should have worked but it did not!!!!
        Dim varItem As Object, bolItemSelected As Boolean
        For Each varItem In List0.SelectedItems

            If varItem = List0.SelectedItem Then
                bolItemSelected = True
            End If
        Next
        If bolItemSelected Then
            Console.WriteLine("You just selected the item.")
        Else
            Console.WriteLine("You just unselected the item.")
        End If
    End Sub


End Class
