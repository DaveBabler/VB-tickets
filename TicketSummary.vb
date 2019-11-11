Public Class TicketSummary

    Public Shared Sub ClearSummaryFields()
        'This sub clears specific fields that do not fit well on an array clearing function
        TicketSummary.lblPurchaserName.Text = ""
        TicketSummary.lblTotalPurchasedOut.Text = ""
        TicketSummary.lblTotalCostOut.Text = ""

    End Sub
    Public Shared Sub PopulateReceipt()
        TicketSummary.lblPurchaserName.Text = GlobalClass.strTicketPurchaser.ToString()
        ' TicketSummary.lblTotalCost = 
        TicketSummary.lblTotalPurchasedOut.Text = ArrayManipulation.ArrayTotaler(GlobalClass.intTotalPerSection).ToString()
        LabelManipulation.FillLabelsOnTblLayOut(ArrayManipulation.StringArraySuffixer(frmTicketEntryMain.strSectionNames, "Out"), GlobalClass.intTotalPerSection, TicketSummary.tblyTicketSummary)


    End Sub
    Private Sub TicketSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Shown, MyBase.Load
        PopulateReceipt()
    End Sub
End Class