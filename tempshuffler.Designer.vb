<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tempshuffler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTicketHeader = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lblTicketHeader
        '
        Me.lblTicketHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTicketHeader.AutoSize = True
        Me.lblTicketHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblTicketHeader.Font = New System.Drawing.Font("Madonna", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblTicketHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTicketHeader.Location = New System.Drawing.Point(252, 257)
        Me.lblTicketHeader.Name = "lblTicketHeader"
        Me.lblTicketHeader.Size = New System.Drawing.Size(545, 120)
        Me.lblTicketHeader.TabIndex = 19
        Me.lblTicketHeader.Text = "Madonna Tickets " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Receipt"
        Me.lblTicketHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSummaryForNameLabel
        '
        Me.lblSummaryForNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSummaryForNameLabel.AutoSize = True
        Me.lblSummaryForNameLabel.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryForNameLabel.Location = New System.Drawing.Point(360, 377)
        Me.lblSummaryForNameLabel.Name = "lblSummaryForNameLabel"
        Me.lblSummaryForNameLabel.Size = New System.Drawing.Size(162, 26)
        Me.lblSummaryForNameLabel.TabIndex = 20
        Me.lblSummaryForNameLabel.Text = "Ticket Holder: "
        Me.lblSummaryForNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPurchaserName
        '
        Me.lblPurchaserName.AutoSize = True
        Me.lblPurchaserName.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaserName.Location = New System.Drawing.Point(528, 377)
        Me.lblPurchaserName.Name = "lblPurchaserName"
        Me.lblPurchaserName.Size = New System.Drawing.Size(200, 26)
        Me.lblPurchaserName.TabIndex = 21
        Me.lblPurchaserName.Text = "Purchaser's Name"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(238, 424)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(126, 26)
        Me.lblTotalCost.TabIndex = 22
        Me.lblTotalCost.Text = "Total Cost:"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalTicketsPurchased
        '
        Me.lblTotalTicketsPurchased.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalTicketsPurchased.AutoSize = True
        Me.lblTotalTicketsPurchased.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTicketsPurchased.Location = New System.Drawing.Point(238, 464)
        Me.lblTotalTicketsPurchased.Name = "lblTotalTicketsPurchased"
        Me.lblTotalTicketsPurchased.Size = New System.Drawing.Size(267, 26)
        Me.lblTotalTicketsPurchased.TabIndex = 23
        Me.lblTotalTicketsPurchased.Text = "Total Tickets Purchased:"
        Me.lblTotalTicketsPurchased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBalcony
        '
        Me.lblBalcony.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblBalcony.AutoSize = True
        Me.lblBalcony.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalcony.Location = New System.Drawing.Point(238, 505)
        Me.lblBalcony.Name = "lblBalcony"
        Me.lblBalcony.Size = New System.Drawing.Size(163, 23)
        Me.lblBalcony.TabIndex = 24
        Me.lblBalcony.Text = "Balcony Tickets:"
        Me.lblBalcony.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGeneralTickets
        '
        Me.lblGeneralTickets.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGeneralTickets.AutoSize = True
        Me.lblGeneralTickets.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralTickets.Location = New System.Drawing.Point(238, 545)
        Me.lblGeneralTickets.Name = "lblGeneralTickets"
        Me.lblGeneralTickets.Size = New System.Drawing.Size(164, 23)
        Me.lblGeneralTickets.TabIndex = 25
        Me.lblGeneralTickets.Text = "General Tickets:"
        Me.lblGeneralTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMezzanine
        '
        Me.lblMezzanine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMezzanine.AutoSize = True
        Me.lblMezzanine.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMezzanine.Location = New System.Drawing.Point(238, 585)
        Me.lblMezzanine.Name = "lblMezzanine"
        Me.lblMezzanine.Size = New System.Drawing.Size(190, 23)
        Me.lblMezzanine.TabIndex = 26
        Me.lblMezzanine.Text = "Mezzanine Tickets:"
        Me.lblMezzanine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrchestra
        '
        Me.lblOrchestra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOrchestra.AutoSize = True
        Me.lblOrchestra.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrchestra.Location = New System.Drawing.Point(238, 625)
        Me.lblOrchestra.Name = "lblOrchestra"
        Me.lblOrchestra.Size = New System.Drawing.Size(182, 23)
        Me.lblOrchestra.TabIndex = 27
        Me.lblOrchestra.Text = "Orchestra Tickets:"
        Me.lblOrchestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProgramAuthor
        '
        Me.lblProgramAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblProgramAuthor.AutoSize = True
        Me.lblProgramAuthor.Font = New System.Drawing.Font("Madonna", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblProgramAuthor.Location = New System.Drawing.Point(339, 709)
        Me.lblProgramAuthor.Name = "lblProgramAuthor"
        Me.lblProgramAuthor.Size = New System.Drawing.Size(183, 21)
        Me.lblProgramAuthor.TabIndex = 28
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
        Me.Label1.Location = New System.Drawing.Point(528, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Dave Babler 0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrchestraOut
        '
        Me.lblOrchestraOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblOrchestraOut.AutoSize = True
        Me.lblOrchestraOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrchestraOut.Location = New System.Drawing.Point(766, 625)
        Me.lblOrchestraOut.Name = "lblOrchestraOut"
        Me.lblOrchestraOut.Size = New System.Drawing.Size(46, 23)
        Me.lblOrchestraOut.TabIndex = 30
        Me.lblOrchestraOut.Text = "888"
        Me.lblOrchestraOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMezzanineOut
        '
        Me.lblMezzanineOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMezzanineOut.AutoSize = True
        Me.lblMezzanineOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMezzanineOut.Location = New System.Drawing.Point(766, 585)
        Me.lblMezzanineOut.Name = "lblMezzanineOut"
        Me.lblMezzanineOut.Size = New System.Drawing.Size(46, 23)
        Me.lblMezzanineOut.TabIndex = 31
        Me.lblMezzanineOut.Text = "888"
        Me.lblMezzanineOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGeneralOut
        '
        Me.lblGeneralOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblGeneralOut.AutoSize = True
        Me.lblGeneralOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralOut.Location = New System.Drawing.Point(766, 545)
        Me.lblGeneralOut.Name = "lblGeneralOut"
        Me.lblGeneralOut.Size = New System.Drawing.Size(46, 23)
        Me.lblGeneralOut.TabIndex = 32
        Me.lblGeneralOut.Text = "888"
        Me.lblGeneralOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBalconyOut
        '
        Me.lblBalconyOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblBalconyOut.AutoSize = True
        Me.lblBalconyOut.Font = New System.Drawing.Font("AG Book Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalconyOut.Location = New System.Drawing.Point(766, 505)
        Me.lblBalconyOut.Name = "lblBalconyOut"
        Me.lblBalconyOut.Size = New System.Drawing.Size(46, 23)
        Me.lblBalconyOut.TabIndex = 33
        Me.lblBalconyOut.Text = "888"
        Me.lblBalconyOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPurchasedOut
        '
        Me.lblTotalPurchasedOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotalPurchasedOut.AutoSize = True
        Me.lblTotalPurchasedOut.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPurchasedOut.Location = New System.Drawing.Point(735, 464)
        Me.lblTotalPurchasedOut.Name = "lblTotalPurchasedOut"
        Me.lblTotalPurchasedOut.Size = New System.Drawing.Size(77, 26)
        Me.lblTotalPurchasedOut.TabIndex = 34
        Me.lblTotalPurchasedOut.Text = "88888"
        Me.lblTotalPurchasedOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCostOut
        '
        Me.lblTotalCostOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotalCostOut.AutoSize = True
        Me.lblTotalCostOut.Font = New System.Drawing.Font("AG Book Rounded", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOut.Location = New System.Drawing.Point(690, 424)
        Me.lblTotalCostOut.Name = "lblTotalCostOut"
        Me.lblTotalCostOut.Size = New System.Drawing.Size(122, 26)
        Me.lblTotalCostOut.TabIndex = 35
        Me.lblTotalCostOut.Text = "$88888.88"
        Me.lblTotalCostOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tempshuffler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 987)
        Me.Controls.Add(Me.lblTicketHeader)
        Me.Controls.Add(Me.lblSummaryForNameLabel)
        Me.Controls.Add(Me.lblPurchaserName)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalTicketsPurchased)
        Me.Controls.Add(Me.lblBalcony)
        Me.Controls.Add(Me.lblGeneralTickets)
        Me.Controls.Add(Me.lblMezzanine)
        Me.Controls.Add(Me.lblOrchestra)
        Me.Controls.Add(Me.lblProgramAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOrchestraOut)
        Me.Controls.Add(Me.lblMezzanineOut)
        Me.Controls.Add(Me.lblGeneralOut)
        Me.Controls.Add(Me.lblBalconyOut)
        Me.Controls.Add(Me.lblTotalPurchasedOut)
        Me.Controls.Add(Me.lblTotalCostOut)
        Me.Name = "tempshuffler"
        Me.Text = "tempshuffler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTicketHeader As Label
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
