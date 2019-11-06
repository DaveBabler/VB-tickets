<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTicketHeader = New System.Windows.Forms.Label()
        Me.tblyTicketSummary = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSummaryForNameLabel = New System.Windows.Forms.Label()
        Me.lblPurchaserName = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalTicketsPurchased = New System.Windows.Forms.Label()
        Me.lblBalcony = New System.Windows.Forms.Label()
        Me.lblGeneralTickets = New System.Windows.Forms.Label()
        Me.lblMezzanine = New System.Windows.Forms.Label()
        Me.lblOrchestra = New System.Windows.Forms.Label()
        Me.lblProgramAuthor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOrchestraOut = New System.Windows.Forms.Label()
        Me.lblMezzanineOut = New System.Windows.Forms.Label()
        Me.lblGeneralOut = New System.Windows.Forms.Label()
        Me.lblBalconyOut = New System.Windows.Forms.Label()
        Me.lblTotalPurchasedOut = New System.Windows.Forms.Label()
        Me.lblTotalCostOut = New System.Windows.Forms.Label()
        Me.tblyTicketSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTicketHeader
        '
        Me.lblTicketHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTicketHeader.AutoSize = True
        Me.lblTicketHeader.BackColor = System.Drawing.Color.Transparent
        Me.tblyTicketSummary.SetColumnSpan(Me.lblTicketHeader, 2)
        Me.lblTicketHeader.Font = New System.Drawing.Font("Madonna", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblTicketHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTicketHeader.Location = New System.Drawing.Point(17, 0)
        Me.lblTicketHeader.Name = "lblTicketHeader"
        Me.lblTicketHeader.Size = New System.Drawing.Size(545, 120)
        Me.lblTicketHeader.TabIndex = 0
        Me.lblTicketHeader.Text = "Madonna Tickets " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Receipt"
        Me.lblTicketHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tblyTicketSummary
        '
        Me.tblyTicketSummary.BackColor = System.Drawing.Color.Transparent
        Me.tblyTicketSummary.ColumnCount = 2
        Me.tblyTicketSummary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblyTicketSummary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblyTicketSummary.Controls.Add(Me.lblTicketHeader, 0, 0)
        Me.tblyTicketSummary.Controls.Add(Me.lblSummaryForNameLabel, 0, 1)
        Me.tblyTicketSummary.Controls.Add(Me.lblPurchaserName, 1, 1)
        Me.tblyTicketSummary.Controls.Add(Me.lblTotalCost, 0, 2)
        Me.tblyTicketSummary.Controls.Add(Me.lblTotalTicketsPurchased, 0, 3)
        Me.tblyTicketSummary.Controls.Add(Me.lblBalcony, 0, 4)
        Me.tblyTicketSummary.Controls.Add(Me.lblGeneralTickets, 0, 5)
        Me.tblyTicketSummary.Controls.Add(Me.lblMezzanine, 0, 6)
        Me.tblyTicketSummary.Controls.Add(Me.lblOrchestra, 0, 7)
        Me.tblyTicketSummary.Controls.Add(Me.lblProgramAuthor, 0, 8)
        Me.tblyTicketSummary.Controls.Add(Me.Label1, 1, 8)
        Me.tblyTicketSummary.Controls.Add(Me.lblOrchestraOut, 1, 7)
        Me.tblyTicketSummary.Controls.Add(Me.lblMezzanineOut, 1, 6)
        Me.tblyTicketSummary.Controls.Add(Me.lblGeneralOut, 1, 5)
        Me.tblyTicketSummary.Controls.Add(Me.lblBalconyOut, 1, 4)
        Me.tblyTicketSummary.Controls.Add(Me.lblTotalPurchasedOut, 1, 3)
        Me.tblyTicketSummary.Controls.Add(Me.lblTotalCostOut, 1, 2)
        Me.tblyTicketSummary.Location = New System.Drawing.Point(8, -6)
        Me.tblyTicketSummary.Name = "tblyTicketSummary"
        Me.tblyTicketSummary.RowCount = 9
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblyTicketSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblyTicketSummary.Size = New System.Drawing.Size(580, 526)
        Me.tblyTicketSummary.TabIndex = 1
        '
        'lblSummaryForNameLabel
        '
        Me.lblSummaryForNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSummaryForNameLabel.AutoSize = True
        Me.lblSummaryForNameLabel.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryForNameLabel.Location = New System.Drawing.Point(125, 120)
        Me.lblSummaryForNameLabel.Name = "lblSummaryForNameLabel"
        Me.lblSummaryForNameLabel.Size = New System.Drawing.Size(162, 26)
        Me.lblSummaryForNameLabel.TabIndex = 1
        Me.lblSummaryForNameLabel.Text = "Ticket Holder: "
        Me.lblSummaryForNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPurchaserName
        '
        Me.lblPurchaserName.AutoSize = True
        Me.lblPurchaserName.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaserName.Location = New System.Drawing.Point(293, 120)
        Me.lblPurchaserName.Name = "lblPurchaserName"
        Me.lblPurchaserName.Size = New System.Drawing.Size(200, 26)
        Me.lblPurchaserName.TabIndex = 2
        Me.lblPurchaserName.Text = "Purchaser's Name"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(3, 167)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(126, 26)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Total Cost:"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalTicketsPurchased
        '
        Me.lblTotalTicketsPurchased.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalTicketsPurchased.AutoSize = True
        Me.lblTotalTicketsPurchased.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTicketsPurchased.Location = New System.Drawing.Point(3, 207)
        Me.lblTotalTicketsPurchased.Name = "lblTotalTicketsPurchased"
        Me.lblTotalTicketsPurchased.Size = New System.Drawing.Size(267, 26)
        Me.lblTotalTicketsPurchased.TabIndex = 4
        Me.lblTotalTicketsPurchased.Text = "Total Tickets Purchased:"
        Me.lblTotalTicketsPurchased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBalcony
        '
        Me.lblBalcony.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblBalcony.AutoSize = True
        Me.lblBalcony.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalcony.Location = New System.Drawing.Point(3, 248)
        Me.lblBalcony.Name = "lblBalcony"
        Me.lblBalcony.Size = New System.Drawing.Size(163, 23)
        Me.lblBalcony.TabIndex = 5
        Me.lblBalcony.Text = "Balcony Tickets:"
        Me.lblBalcony.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGeneralTickets
        '
        Me.lblGeneralTickets.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGeneralTickets.AutoSize = True
        Me.lblGeneralTickets.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralTickets.Location = New System.Drawing.Point(3, 288)
        Me.lblGeneralTickets.Name = "lblGeneralTickets"
        Me.lblGeneralTickets.Size = New System.Drawing.Size(164, 23)
        Me.lblGeneralTickets.TabIndex = 6
        Me.lblGeneralTickets.Text = "General Tickets:"
        Me.lblGeneralTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMezzanine
        '
        Me.lblMezzanine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMezzanine.AutoSize = True
        Me.lblMezzanine.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMezzanine.Location = New System.Drawing.Point(3, 328)
        Me.lblMezzanine.Name = "lblMezzanine"
        Me.lblMezzanine.Size = New System.Drawing.Size(190, 23)
        Me.lblMezzanine.TabIndex = 7
        Me.lblMezzanine.Text = "Mezzanine Tickets:"
        Me.lblMezzanine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrchestra
        '
        Me.lblOrchestra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOrchestra.AutoSize = True
        Me.lblOrchestra.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrchestra.Location = New System.Drawing.Point(3, 368)
        Me.lblOrchestra.Name = "lblOrchestra"
        Me.lblOrchestra.Size = New System.Drawing.Size(182, 23)
        Me.lblOrchestra.TabIndex = 8
        Me.lblOrchestra.Text = "Orchestra Tickets:"
        Me.lblOrchestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProgramAuthor
        '
        Me.lblProgramAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblProgramAuthor.AutoSize = True
        Me.lblProgramAuthor.Font = New System.Drawing.Font("Madonna", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblProgramAuthor.Location = New System.Drawing.Point(104, 452)
        Me.lblProgramAuthor.Name = "lblProgramAuthor"
        Me.lblProgramAuthor.Size = New System.Drawing.Size(183, 21)
        Me.lblProgramAuthor.TabIndex = 11
        Me.lblProgramAuthor.Text = "0 Authored By: "
        Me.lblProgramAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "lblProgramAuthorOutput"
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Madonna", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(293, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Dave Babler 0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrchestraOut
        '
        Me.lblOrchestraOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblOrchestraOut.AutoSize = True
        Me.lblOrchestraOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrchestraOut.Location = New System.Drawing.Point(531, 368)
        Me.lblOrchestraOut.Name = "lblOrchestraOut"
        Me.lblOrchestraOut.Size = New System.Drawing.Size(46, 23)
        Me.lblOrchestraOut.TabIndex = 13
        Me.lblOrchestraOut.Text = "888"
        Me.lblOrchestraOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMezzanineOut
        '
        Me.lblMezzanineOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMezzanineOut.AutoSize = True
        Me.lblMezzanineOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMezzanineOut.Location = New System.Drawing.Point(531, 328)
        Me.lblMezzanineOut.Name = "lblMezzanineOut"
        Me.lblMezzanineOut.Size = New System.Drawing.Size(46, 23)
        Me.lblMezzanineOut.TabIndex = 14
        Me.lblMezzanineOut.Text = "888"
        Me.lblMezzanineOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGeneralOut
        '
        Me.lblGeneralOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblGeneralOut.AutoSize = True
        Me.lblGeneralOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralOut.Location = New System.Drawing.Point(531, 288)
        Me.lblGeneralOut.Name = "lblGeneralOut"
        Me.lblGeneralOut.Size = New System.Drawing.Size(46, 23)
        Me.lblGeneralOut.TabIndex = 15
        Me.lblGeneralOut.Text = "888"
        Me.lblGeneralOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBalconyOut
        '
        Me.lblBalconyOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblBalconyOut.AutoSize = True
        Me.lblBalconyOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalconyOut.Location = New System.Drawing.Point(531, 248)
        Me.lblBalconyOut.Name = "lblBalconyOut"
        Me.lblBalconyOut.Size = New System.Drawing.Size(46, 23)
        Me.lblBalconyOut.TabIndex = 16
        Me.lblBalconyOut.Text = "888"
        Me.lblBalconyOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPurchasedOut
        '
        Me.lblTotalPurchasedOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotalPurchasedOut.AutoSize = True
        Me.lblTotalPurchasedOut.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPurchasedOut.Location = New System.Drawing.Point(500, 207)
        Me.lblTotalPurchasedOut.Name = "lblTotalPurchasedOut"
        Me.lblTotalPurchasedOut.Size = New System.Drawing.Size(77, 26)
        Me.lblTotalPurchasedOut.TabIndex = 17
        Me.lblTotalPurchasedOut.Text = "88888"
        Me.lblTotalPurchasedOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCostOut
        '
        Me.lblTotalCostOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotalCostOut.AutoSize = True
        Me.lblTotalCostOut.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOut.Location = New System.Drawing.Point(455, 167)
        Me.lblTotalCostOut.Name = "lblTotalCostOut"
        Me.lblTotalCostOut.Size = New System.Drawing.Size(122, 26)
        Me.lblTotalCostOut.TabIndex = 18
        Me.lblTotalCostOut.Text = "$88888.88"
        Me.lblTotalCostOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TicketSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Tickets.My.Resources.Resources.disco_pattern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(596, 753)
        Me.Controls.Add(Me.tblyTicketSummary)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "TicketSummary"
        Me.Padding = New System.Windows.Forms.Padding(58, 52, 58, 52)
        Me.Text = "TicketSummary"
        Me.tblyTicketSummary.ResumeLayout(False)
        Me.tblyTicketSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTicketHeader As Label
    Friend WithEvents tblyTicketSummary As TableLayoutPanel
    Friend WithEvents lblSummaryForNameLabel As Label
    Friend WithEvents lblPurchaserName As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotalTicketsPurchased As Label
    Friend WithEvents lblBalcony As Label
    Friend WithEvents lblGeneralTickets As Label
    Friend WithEvents lblMezzanine As Label
    Friend WithEvents lblOrchestra As Label
    Friend WithEvents lblProgramAuthor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOrchestraOut As Label
    Friend WithEvents lblMezzanineOut As Label
    Friend WithEvents lblGeneralOut As Label
    Friend WithEvents lblBalconyOut As Label
    Friend WithEvents lblTotalPurchasedOut As Label
    Friend WithEvents lblTotalCostOut As Label
End Class
