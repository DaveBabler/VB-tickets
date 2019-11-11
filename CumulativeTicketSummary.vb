Public Class CumulativeTicketSummary
    Public Shared Sub ClearCumulativeFields()
        'This sub clears fields that do not readily fit into an array 
        CumulativeTicketSummary.lblTotalCumulativeOut.Text = ""
    End Sub
    Public Shared Sub PopulateCumulativeReport()
        'This does no math, it only does string/array manipulation and printing to screen
        'populate price sheet
        LabelManipulation.FillLabelsOnTblLayOut(ArrayManipulation.StringArraySuffixer((frmTicketEntryMain.strSectionNames), "PriceOut"), frmTicketEntryMain.decPrices, CumulativeTicketSummary.tlblyCumulative)
        'cumulative sold tickets
        ArrayManipulation.StringArraySuffixer(frmTicketEntryMain.strSectionNames, "Out")
        'Cumulative Price
        ArrayManipulation.StringArraySuffixer(frmTicketEntryMain.strSectionNames, "CumulativeOut")
        'Grand Total
        CumulativeTicketSummary.lblTotalCumulativeOut.Text = GlobalClass.decTicketGrandTotal.ToString("N2")
    End Sub

    Private Sub CumulativeTicketSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCumulativeReport()
    End Sub
End Class