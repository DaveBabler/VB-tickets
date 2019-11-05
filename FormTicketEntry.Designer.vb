<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketEntryMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnAddQuantities = New System.Windows.Forms.Button()
        Me.lstSeatLocations = New System.Windows.Forms.ListBox()
        Me.ttTicketInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnAddQuantities
        '
        Me.btnAddQuantities.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddQuantities.Font = New System.Drawing.Font("Noto Sans", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnAddQuantities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddQuantities.Location = New System.Drawing.Point(232, 343)
        Me.btnAddQuantities.Name = "btnAddQuantities"
        Me.btnAddQuantities.Size = New System.Drawing.Size(93, 46)
        Me.btnAddQuantities.TabIndex = 0
        Me.btnAddQuantities.Text = "Add Quantities"
        Me.btnAddQuantities.UseVisualStyleBackColor = False
        '
        'lstSeatLocations
        '
        Me.lstSeatLocations.BackColor = System.Drawing.Color.Gainsboro
        Me.lstSeatLocations.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSeatLocations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lstSeatLocations.FormattingEnabled = True
        Me.lstSeatLocations.ItemHeight = 21
        Me.lstSeatLocations.Items.AddRange(New Object() {"dddd", "sss", "fffff"})
        Me.lstSeatLocations.Location = New System.Drawing.Point(12, 217)
        Me.lstSeatLocations.Name = "lstSeatLocations"
        Me.lstSeatLocations.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSeatLocations.Size = New System.Drawing.Size(203, 172)
        Me.lstSeatLocations.TabIndex = 1
        '
        'frmTicketEntryMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.lstSeatLocations)
        Me.Controls.Add(Me.btnAddQuantities)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Name = "frmTicketEntryMain"
        Me.Text = "Ticket Entry"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddQuantities As Button
    Friend WithEvents lstSeatLocations As ListBox
    Friend WithEvents ttTicketInfo As ToolTip
End Class
