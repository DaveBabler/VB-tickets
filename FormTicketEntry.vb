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


        Debug.Print(lstSeatLocations.Items.Count)
        For x = 0 To lstSeatLocations.SelectedItems.Count() - 1
            For Each ob In lstSeatLocations.SelectedIndices
                If CInt(ob) = x Then
                    Console.WriteLine("We have {0:N} as ob and {1:N} as x", ob, x)
                End If

            Next ob

            If lstSeatLocations.SelectedItems.Count() > 0 Then

                Console.WriteLine(lstSeatLocations.SelectedItems(x).ToString())
                GlobalClass.CheckLabels(Me, lstSeatLocations.SelectedItems(x).ToString(), False, True)
            End If
            List0_BeforeUpdate(x, lstSeatLocations)
            If lstSeatLocations.GetSelected(x) = False Then
                Console.WriteLine("HEY FAGGOT " & x & "has been unselcted YOU SLUTWHOREAIDS!")
            End If
        Next x

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


    End Sub


    Private Sub List0_BeforeUpdate(Cancel As Integer, ByVal List0 As ListBox)
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
