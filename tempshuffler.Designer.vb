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
        Me.tbllyQuantity = New System.Windows.Forms.TableLayoutPanel()
        Me.txtQtyOrchestra = New System.Windows.Forms.TextBox()
        Me.txtQtyMezzanine = New System.Windows.Forms.TextBox()
        Me.txtQtyGeneral = New System.Windows.Forms.TextBox()
        Me.lblQtyBalcony = New System.Windows.Forms.Label()
        Me.lblQtyGeneral = New System.Windows.Forms.Label()
        Me.lblQtyMezzanine = New System.Windows.Forms.Label()
        Me.lblQtyOrchestra = New System.Windows.Forms.Label()
        Me.txtQtyBalcony = New System.Windows.Forms.TextBox()
        Me.tbllyQuantity.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbllyQuantity
        '
        Me.tbllyQuantity.ColumnCount = 2
        Me.tbllyQuantity.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.47032!))
        Me.tbllyQuantity.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.52968!))
        Me.tbllyQuantity.Controls.Add(Me.lblQtyOrchestra, 0, 0)
        Me.tbllyQuantity.Controls.Add(Me.lblQtyGeneral, 0, 2)
        Me.tbllyQuantity.Controls.Add(Me.lblQtyBalcony, 0, 3)
        Me.tbllyQuantity.Controls.Add(Me.txtQtyMezzanine, 1, 1)
        Me.tbllyQuantity.Controls.Add(Me.txtQtyGeneral, 1, 2)
        Me.tbllyQuantity.Controls.Add(Me.txtQtyBalcony, 1, 3)
        Me.tbllyQuantity.Controls.Add(Me.txtQtyOrchestra, 1, 0)
        Me.tbllyQuantity.Controls.Add(Me.lblQtyMezzanine, 0, 1)
        Me.tbllyQuantity.Location = New System.Drawing.Point(439, 422)
        Me.tbllyQuantity.Name = "tbllyQuantity"
        Me.tbllyQuantity.RowCount = 4
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.Size = New System.Drawing.Size(172, 142)
        Me.tbllyQuantity.TabIndex = 5
        '
        'txtQtyOrchestra
        '
        Me.txtQtyOrchestra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtQtyOrchestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.txtQtyOrchestra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtQtyOrchestra.Location = New System.Drawing.Point(112, 6)
        Me.txtQtyOrchestra.Name = "txtQtyOrchestra"
        Me.txtQtyOrchestra.Size = New System.Drawing.Size(57, 22)
        Me.txtQtyOrchestra.TabIndex = 15
        Me.txtQtyOrchestra.Text = "888"
        Me.txtQtyOrchestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyOrchestra.Visible = False
        '
        'txtQtyMezzanine
        '
        Me.txtQtyMezzanine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtQtyMezzanine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.txtQtyMezzanine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtQtyMezzanine.Location = New System.Drawing.Point(112, 41)
        Me.txtQtyMezzanine.Name = "txtQtyMezzanine"
        Me.txtQtyMezzanine.Size = New System.Drawing.Size(57, 22)
        Me.txtQtyMezzanine.TabIndex = 14
        Me.txtQtyMezzanine.Text = "888"
        Me.txtQtyMezzanine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyMezzanine.Visible = False
        '
        'txtQtyGeneral
        '
        Me.txtQtyGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtQtyGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.txtQtyGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtQtyGeneral.Location = New System.Drawing.Point(112, 76)
        Me.txtQtyGeneral.Name = "txtQtyGeneral"
        Me.txtQtyGeneral.Size = New System.Drawing.Size(57, 22)
        Me.txtQtyGeneral.TabIndex = 13
        Me.txtQtyGeneral.Text = "888"
        Me.txtQtyGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyGeneral.Visible = False
        '
        'lblQtyBalcony
        '
        Me.lblQtyBalcony.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQtyBalcony.AutoSize = True
        Me.lblQtyBalcony.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyBalcony.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQtyBalcony.Location = New System.Drawing.Point(38, 115)
        Me.lblQtyBalcony.Name = "lblQtyBalcony"
        Me.lblQtyBalcony.Size = New System.Drawing.Size(68, 16)
        Me.lblQtyBalcony.TabIndex = 8
        Me.lblQtyBalcony.Text = "Balcony:"
        Me.lblQtyBalcony.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblQtyBalcony.Visible = False
        '
        'lblQtyGeneral
        '
        Me.lblQtyGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQtyGeneral.AutoSize = True
        Me.lblQtyGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQtyGeneral.Location = New System.Drawing.Point(39, 79)
        Me.lblQtyGeneral.Name = "lblQtyGeneral"
        Me.lblQtyGeneral.Size = New System.Drawing.Size(67, 16)
        Me.lblQtyGeneral.TabIndex = 9
        Me.lblQtyGeneral.Text = "General:"
        Me.lblQtyGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblQtyGeneral.Visible = False
        '
        'lblQtyMezzanine
        '
        Me.lblQtyMezzanine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQtyMezzanine.AutoSize = True
        Me.lblQtyMezzanine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyMezzanine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQtyMezzanine.Location = New System.Drawing.Point(21, 44)
        Me.lblQtyMezzanine.Name = "lblQtyMezzanine"
        Me.lblQtyMezzanine.Size = New System.Drawing.Size(85, 16)
        Me.lblQtyMezzanine.TabIndex = 10
        Me.lblQtyMezzanine.Text = "Mezzanine:"
        Me.lblQtyMezzanine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblQtyMezzanine.Visible = False
        '
        'lblQtyOrchestra
        '
        Me.lblQtyOrchestra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQtyOrchestra.AutoSize = True
        Me.lblQtyOrchestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyOrchestra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQtyOrchestra.Location = New System.Drawing.Point(27, 9)
        Me.lblQtyOrchestra.Name = "lblQtyOrchestra"
        Me.lblQtyOrchestra.Size = New System.Drawing.Size(79, 16)
        Me.lblQtyOrchestra.TabIndex = 11
        Me.lblQtyOrchestra.Text = "Orchestra:"
        Me.lblQtyOrchestra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblQtyOrchestra.Visible = False
        '
        'txtQtyBalcony
        '
        Me.txtQtyBalcony.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtQtyBalcony.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.txtQtyBalcony.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtQtyBalcony.Location = New System.Drawing.Point(112, 112)
        Me.txtQtyBalcony.Name = "txtQtyBalcony"
        Me.txtQtyBalcony.Size = New System.Drawing.Size(57, 22)
        Me.txtQtyBalcony.TabIndex = 12
        Me.txtQtyBalcony.Text = "888"
        Me.txtQtyBalcony.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyBalcony.Visible = False
        '
        'tempshuffler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1050, 987)
        Me.Controls.Add(Me.tbllyQuantity)
        Me.Name = "tempshuffler"
        Me.Text = "tempshuffler"
        Me.tbllyQuantity.ResumeLayout(False)
        Me.tbllyQuantity.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbllyQuantity As TableLayoutPanel
    Friend WithEvents txtQtyOrchestra As TextBox
    Friend WithEvents txtQtyMezzanine As TextBox
    Friend WithEvents txtQtyGeneral As TextBox
    Friend WithEvents lblQtyBalcony As Label
    Friend WithEvents lblQtyGeneral As Label
    Friend WithEvents lblQtyMezzanine As Label
    Friend WithEvents lblQtyOrchestra As Label
    Friend WithEvents txtQtyBalcony As TextBox
End Class
