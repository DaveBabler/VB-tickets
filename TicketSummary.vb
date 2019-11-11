Public Class TicketSummary

    Public Shared Sub ClearSummaryFields()
        'This sub clears specific fields that do not fit well on an array clearing function
        TicketSummary.lblPurchaserName.Text = ""
        TicketSummary.lblTotalPurchasedOut.Text = ""
        TicketSummary.lblTotalCostOut.Text = ""

    End Sub
    Public Shared Sub PopulateReceipt()
        TicketSummary.lblPurchaserName.Text = GlobalClass.strTicketPurchaser
        TicketSummary.lblTotalPurchasedOut.Text = GlobalClass.intSubTotalNumTicks.ToString()
        LabelManipulation.FillLabelsOnTblLayOut(ArrayManipulation.StringArraySuffixer(frmTicketEntryMain.strSectionNames, "Out"), GlobalClass.intTotalPerSection, TicketSummary.tblyTicketSummary)
        TicketSummary.lblTotalCostOut.Text = GlobalClass.decTicketSubTotal.ToString("C")


    End Sub
    Private Sub TicketSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Shown, MyBase.Load
        PopulateReceipt()
    End Sub
End Class