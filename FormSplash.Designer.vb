<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSplash
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.picSplashMadameX = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picSplashMadameX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Version, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ApplicationTitle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Copyright, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.picSplashMadameX, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Semplicita", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, -1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(496, 305)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Version
        '
        Me.Version.Font = New System.Drawing.Font("Semplicita", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Version.Location = New System.Drawing.Point(251, 203)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(242, 22)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version  {0}.{1:00}"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.Font = New System.Drawing.Font("Semplicita", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ApplicationTitle.Location = New System.Drawing.Point(78, 203)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(167, 88)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Program Name"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Font = New System.Drawing.Font("Semplicita", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(251, 291)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(65, 14)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copywrite"
        '
        'picSplashMadameX
        '
        Me.picSplashMadameX.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picSplashMadameX.BackgroundImage = Global.Tickets.My.Resources.Resources.rvxX_h9ldzk_QCKYehkgo5D35v8
        Me.picSplashMadameX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.SetColumnSpan(Me.picSplashMadameX, 2)
        Me.picSplashMadameX.Location = New System.Drawing.Point(3, 3)
        Me.picSplashMadameX.Name = "picSplashMadameX"
        Me.picSplashMadameX.Size = New System.Drawing.Size(490, 197)
        Me.picSplashMadameX.TabIndex = 3
        Me.picSplashMadameX.TabStop = False
        '
        'FormSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picSplashMadameX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents picSplashMadameX As PictureBox
End Class
