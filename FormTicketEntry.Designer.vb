﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketEntryMain))
        Me.btnConfirmQty = New System.Windows.Forms.Button()
        Me.lstSeatLocations = New System.Windows.Forms.ListBox()
        Me.ttTicketInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTicketPurchaser = New System.Windows.Forms.TextBox()
        Me.lblTicketPurchaser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSubtotalOut = New System.Windows.Forms.Label()
        Me.mnuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintTicketDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintCumulativeSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAllDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.tbllyQuantity = New System.Windows.Forms.TableLayoutPanel()
        Me.lblQtyOrchestra = New System.Windows.Forms.Label()
        Me.lblQtyGeneral = New System.Windows.Forms.Label()
        Me.lblQtyBalcony = New System.Windows.Forms.Label()
        Me.txtQtyMezzanine = New System.Windows.Forms.TextBox()
        Me.txtQtyGeneral = New System.Windows.Forms.TextBox()
        Me.txtQtyBalcony = New System.Windows.Forms.TextBox()
        Me.txtQtyOrchestra = New System.Windows.Forms.TextBox()
        Me.lblQtyMezzanine = New System.Windows.Forms.Label()
        Me.printDialogue = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.mnuStripMain.SuspendLayout()
        Me.tbllyQuantity.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirmQty
        '
        Me.btnConfirmQty.BackColor = System.Drawing.Color.Black
        Me.btnConfirmQty.Enabled = False
        Me.btnConfirmQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirmQty.Location = New System.Drawing.Point(392, 164)
        Me.btnConfirmQty.Name = "btnConfirmQty"
        Me.btnConfirmQty.Size = New System.Drawing.Size(161, 30)
        Me.btnConfirmQty.TabIndex = 3
        Me.btnConfirmQty.Text = "Confirm &Quantities"
        Me.ttTicketInfo.SetToolTip(Me.btnConfirmQty, "This button will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unlock only when " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "at least one non-zerio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entry has been set" &
        ".")
        Me.btnConfirmQty.UseVisualStyleBackColor = False
        '
        'lstSeatLocations
        '
        Me.lstSeatLocations.BackColor = System.Drawing.Color.Gainsboro
        Me.lstSeatLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSeatLocations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lstSeatLocations.FormattingEnabled = True
        Me.lstSeatLocations.ItemHeight = 16
        Me.lstSeatLocations.Items.AddRange(New Object() {"dddd", "sss", "fffff"})
        Me.lstSeatLocations.Location = New System.Drawing.Point(15, 219)
        Me.lstSeatLocations.Name = "lstSeatLocations"
        Me.lstSeatLocations.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSeatLocations.Size = New System.Drawing.Size(116, 84)
        Me.lstSeatLocations.TabIndex = 2
        Me.ttTicketInfo.SetToolTip(Me.lstSeatLocations, "Click to select each area you want seats." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WARNING: deselecting an area will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cl" &
        "ear the quantity for that area!")
        '
        'txtTicketPurchaser
        '
        Me.txtTicketPurchaser.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTicketPurchaser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.txtTicketPurchaser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtTicketPurchaser.Location = New System.Drawing.Point(252, 112)
        Me.txtTicketPurchaser.Name = "txtTicketPurchaser"
        Me.txtTicketPurchaser.Size = New System.Drawing.Size(211, 22)
        Me.txtTicketPurchaser.TabIndex = 1
        Me.ttTicketInfo.SetToolTip(Me.txtTicketPurchaser, "Whom will these tickets be for?")
        '
        'lblTicketPurchaser
        '
        Me.lblTicketPurchaser.AutoSize = True
        Me.lblTicketPurchaser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketPurchaser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTicketPurchaser.Location = New System.Drawing.Point(105, 120)
        Me.lblTicketPurchaser.Name = "lblTicketPurchaser"
        Me.lblTicketPurchaser.Size = New System.Drawing.Size(129, 16)
        Me.lblTicketPurchaser.TabIndex = 3
        Me.lblTicketPurchaser.Text = "Ticket Purchaser:"
        Me.lblTicketPurchaser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Madonna", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Madonna Ticket Sales"
        Me.ttTicketInfo.SetToolTip(Me.Label1, "This font is from Madonna's Confessions on a Dancefloor album." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It's her best alb" &
        "um (so far), and the greatest album in human history (so far).")
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(392, 276)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.ttTicketInfo.SetToolTip(Me.btnClear, "This clears the entries from this form.")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(392, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ttTicketInfo.SetToolTip(Me.btnExit, "Exits program.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Madonna", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(145, 405)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(169, 30)
        Me.lblSubtotal.TabIndex = 8
        Me.lblSubtotal.Text = "Subtotal:"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSubtotal.Visible = False
        '
        'lblSubtotalOut
        '
        Me.lblSubtotalOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSubtotalOut.AutoSize = True
        Me.lblSubtotalOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSubtotalOut.Location = New System.Drawing.Point(331, 405)
        Me.lblSubtotalOut.Name = "lblSubtotalOut"
        Me.lblSubtotalOut.Size = New System.Drawing.Size(93, 24)
        Me.lblSubtotalOut.TabIndex = 12
        Me.lblSubtotalOut.Text = "$8888.88"
        Me.lblSubtotalOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSubtotalOut.Visible = False
        '
        'mnuStripMain
        '
        Me.mnuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripMain.Name = "mnuStripMain"
        Me.mnuStripMain.Size = New System.Drawing.Size(568, 24)
        Me.mnuStripMain.TabIndex = 13
        Me.mnuStripMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PrintTicketDataToolStripMenuItem, Me.PrintCumulativeSummaryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Quits program."
        '
        'PrintTicketDataToolStripMenuItem
        '
        Me.PrintTicketDataToolStripMenuItem.Name = "PrintTicketDataToolStripMenuItem"
        Me.PrintTicketDataToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PrintTicketDataToolStripMenuItem.Text = "&Print Ticket Data"
        Me.PrintTicketDataToolStripMenuItem.ToolTipText = "Prints Individual Ticket Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The same as Printing a Receipt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PrintCumulativeSummaryToolStripMenuItem
        '
        Me.PrintCumulativeSummaryToolStripMenuItem.Name = "PrintCumulativeSummaryToolStripMenuItem"
        Me.PrintCumulativeSummaryToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PrintCumulativeSummaryToolStripMenuItem.Text = "Print &Cumulative Summary"
        Me.PrintCumulativeSummaryToolStripMenuItem.ToolTipText = "For office use only!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This shows the tabulation of all sales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "made while this pro" &
    "gram is running!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearFormToolStripMenuItem1, Me.ResetAllDataToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'ClearFormToolStripMenuItem1
        '
        Me.ClearFormToolStripMenuItem1.Name = "ClearFormToolStripMenuItem1"
        Me.ClearFormToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ClearFormToolStripMenuItem1.Text = "&Clear Form"
        '
        'ResetAllDataToolStripMenuItem
        '
        Me.ResetAllDataToolStripMenuItem.Name = "ResetAllDataToolStripMenuItem"
        Me.ResetAllDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetAllDataToolStripMenuItem.Text = "&Reset All Data"
        Me.ResetAllDataToolStripMenuItem.ToolTipText = "This will reset all data in the program to default!"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Program Information"
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.Black
        Me.btnPrintReceipt.Enabled = False
        Me.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnPrintReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrintReceipt.Location = New System.Drawing.Point(392, 220)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(161, 30)
        Me.btnPrintReceipt.TabIndex = 4
        Me.btnPrintReceipt.Text = "&Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
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
        Me.tbllyQuantity.Location = New System.Drawing.Point(177, 190)
        Me.tbllyQuantity.Name = "tbllyQuantity"
        Me.tbllyQuantity.RowCount = 4
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllyQuantity.Size = New System.Drawing.Size(172, 142)
        Me.tbllyQuantity.TabIndex = 15
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
        'txtQtyMezzanine
        '
        Me.txtQtyMezzanine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtQtyMezzanine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.txtQtyMezzanine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtQtyMezzanine.Location = New System.Drawing.Point(112, 41)
        Me.txtQtyMezzanine.Name = "txtQtyMezzanine"
        Me.txtQtyMezzanine.Size = New System.Drawing.Size(57, 22)
        Me.txtQtyMezzanine.TabIndex = 14
        Me.txtQtyMezzanine.TabStop = False
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
        Me.txtQtyGeneral.TabStop = False
        Me.txtQtyGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyGeneral.Visible = False
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
        Me.txtQtyBalcony.TabStop = False
        Me.txtQtyBalcony.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyBalcony.Visible = False
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
        Me.txtQtyOrchestra.TabStop = False
        Me.txtQtyOrchestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyOrchestra.Visible = False
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
        'printDialogue
        '
        Me.printDialogue.DocumentName = "document"
        Me.printDialogue.Form = Me
        Me.printDialogue.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.printDialogue.PrinterSettings = CType(resources.GetObject("printDialogue.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.printDialogue.PrintFileName = Nothing
        '
        'frmTicketEntryMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.tbllyQuantity)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.lblSubtotalOut)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTicketPurchaser)
        Me.Controls.Add(Me.txtTicketPurchaser)
        Me.Controls.Add(Me.lstSeatLocations)
        Me.Controls.Add(Me.btnConfirmQty)
        Me.Controls.Add(Me.mnuStripMain)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MainMenuStrip = Me.mnuStripMain
        Me.Name = "frmTicketEntryMain"
        Me.Text = "Ticket Entry"
        Me.mnuStripMain.ResumeLayout(False)
        Me.mnuStripMain.PerformLayout()
        Me.tbllyQuantity.ResumeLayout(False)
        Me.tbllyQuantity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmQty As Button
    Friend WithEvents lstSeatLocations As ListBox
    Friend WithEvents ttTicketInfo As ToolTip
    Friend WithEvents txtTicketPurchaser As TextBox
    Friend WithEvents lblTicketPurchaser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSubtotalOut As Label
    Friend WithEvents mnuStripMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintTicketDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintCumulativeSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ResetAllDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents tbllyQuantity As TableLayoutPanel
    Friend WithEvents lblQtyOrchestra As Label
    Friend WithEvents lblQtyGeneral As Label
    Friend WithEvents lblQtyBalcony As Label
    Friend WithEvents txtQtyMezzanine As TextBox
    Friend WithEvents txtQtyGeneral As TextBox
    Friend WithEvents txtQtyBalcony As TextBox
    Friend WithEvents txtQtyOrchestra As TextBox
    Friend WithEvents lblQtyMezzanine As Label
    Friend WithEvents printDialogue As PowerPacks.Printing.PrintForm
End Class
