﻿' Program:                Yachts 
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

Public Class frmTicketEntryMain
    Private Sub frmTicketEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstSeatLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeatLocations.SelectedIndexChanged
        ''''TESTING METHOD!
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
                End If

            Next x

        ''''END TESTING METHOD
    End Sub

    Private Sub btnAddQuantities_Click(sender As Object, e As EventArgs) Handles btnAddQuantities.Click
        GlobalClass.UserErrorMessage("Hey Dave, you haven't programmed anything here yet!", "Oops!")
    End Sub
End Class
