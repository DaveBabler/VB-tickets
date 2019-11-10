Public Class TicketSummary

    Public Shared Sub ClearSummaryFields()
        'This sub clears specific fields that do not fit well on an array clearing function
        TicketSummary.lblPurchaserName.Text = ""
        TicketSummary.lblTotalPurchasedOut.Text = ""
        TicketSummary.lblTotalCostOut.Text = ""

    End Sub
End Class