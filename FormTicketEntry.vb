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
    Dim strNotSelcted As String
    Dim intFlag As Integer = 0 'flag test

    Public strSectionNames As String() = {"Orchestra", "Mezzanine", "General", "Balcony"}
    Public decPrices As Decimal() = {40.0, 27.5, 15.0, 10.0}
    Private Sub frmTicketEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dictionary is populated on splash screen!!!!
        GlobalClass.PopulateListBoxWithDictionary(lstSeatLocations, GlobalClass.dicSeatingPrices)
    End Sub

    Private Sub lstSeatLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeatLocations.SelectedIndexChanged
        ''''TESTING METHOD!
        '''
        '''
        'Array.Clear(strLastActiveSelects, 0, 4)



        Debug.Print(lstSeatLocations.Items.Count)
        'For x = 0 To lstSeatLocations.SelectedItems.Count() - 1

        '    For Each ob In lstSeatLocations.SelectedIndices
        '        If CInt(ob) = x Then
        '            Console.WriteLine("We have  {0:N} as ob and {1:N} as x", ob, x)
        '            ' intLastActiveIndexes.Concat(ob).ToArray
        '            Console.WriteLine("Nex should be like the array or what")
        '            '   Console.WriteLine(intLastActiveIndexes(x).ToString())
        '        End If

        '    Next ob

        '    If lstSeatLocations.SelectedItems.Count() > 0 Then
        '        If intFlag > 0 Then
        '            strLastActiveSelects = strCurrActiveSelects
        '        End If



        '        Dim strSelectedValue As String
        '        strSelectedValue = lstSeatLocations.SelectedItems(x).ToString()
        '        Console.WriteLine("We just assigned the variable of " & strSelectedValue)
        '        strCurrActiveSelects(x) = strSelectedValue

        '        For p = 0 To strLastActiveSelects.Count - 1
        '            Console.WriteLine(strLastActiveSelects(p) & " <<<from Array  |||  from from current >>>" & strCurrActiveSelects(p))
        '        Next p

        '        If strLastActiveSelects.Contains(strSelectedValue) Then
        '            'Do nothing!
        '        Else
        '            GlobalClass.CheckLabels(Me, strSelectedValue, True, False)
        '        End If

        '        Console.WriteLine(lstSeatLocations.SelectedItems(x).ToString())
        '        GlobalClass.CheckLabels(Me, strSelectedValue, False, True)
        '        Array.Clear(strCurrActiveSelects, 0, 4)

        '        intFlag += 1

        '    End If

        ''''try this https://social.msdn.microsoft.com/Forums/en-US/e7b42e0b-1c3e-4356-a424-291ca1ae01ba/list-box-how-put-all-unselected-items-in-a-textbox
        'List0_BeforeUpdate(x, lstSeatLocations)
        'If lstSeatLocations.GetSelected(x) = False Then
        '        ''maybe put this on top and then you can set the stepper to 4
        '    End If
        'Next x
        Dim strUnselected As String = ""
        Dim strSelectedValue As String = ""
        For i As Integer = 0 To lstSeatLocations.Items.Count - 1
            If lstSeatLocations.SelectedIndices.Contains(i) Then
                strSelectedValue = lstSeatLocations.Items(i).ToString()
                GlobalClass.CheckLabels(Me, strSelectedValue, False, True)
            End If


            If Not lstSeatLocations.SelectedIndices.Contains(i) Then
                '  Console.WriteLine("Not Selected" & i.ToString() & " the value is: " & lstSeatLocations.Items(i).ToString())

                strUnselected = lstSeatLocations.Items(i).ToString()
                GlobalClass.CheckLabels(Me, strUnselected, True, False)


            End If

        Next




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
