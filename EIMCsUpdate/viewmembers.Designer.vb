﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewmembers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtoption = New Bunifu.Framework.UI.BunifuDropdown()
        Me.btnsearch = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.txtsearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnDeactivate = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnactivate = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnback = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel30 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnquery = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ITalk_Button_25 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnRefresh = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.spaced
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 643)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(877, 108)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(179, 21)
        Me.BunifuCustomLabel5.TabIndex = 144
        Me.BunifuCustomLabel5.Text = "Select  Option Below :"
        '
        'txtoption
        '
        Me.txtoption.BackColor = System.Drawing.Color.Transparent
        Me.txtoption.BorderRadius = 3
        Me.txtoption.DisabledColor = System.Drawing.Color.Gray
        Me.txtoption.ForeColor = System.Drawing.Color.Black
        Me.txtoption.Items = New String() {"", "File Number", "IPPS Number", "EIMCS Number"}
        Me.txtoption.Location = New System.Drawing.Point(877, 132)
        Me.txtoption.Name = "txtoption"
        Me.txtoption.NomalColor = System.Drawing.Color.White
        Me.txtoption.onHoverColor = System.Drawing.Color.White
        Me.txtoption.selectedIndex = -1
        Me.txtoption.Size = New System.Drawing.Size(154, 35)
        Me.txtoption.TabIndex = 143
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Nothing
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(1177, 133)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 34)
        Me.btnsearch.TabIndex = 142
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.HintForeColor = System.Drawing.Color.Black
        Me.txtsearch.HintText = "Enter  no"
        Me.txtsearch.isPassword = False
        Me.txtsearch.LineFocusedColor = System.Drawing.Color.Gray
        Me.txtsearch.LineIdleColor = System.Drawing.Color.Gray
        Me.txtsearch.LineMouseHoverColor = System.Drawing.Color.SlateGray
        Me.txtsearch.LineThickness = 3
        Me.txtsearch.Location = New System.Drawing.Point(1049, 133)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(115, 35)
        Me.txtsearch.TabIndex = 141
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(354, 73)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(275, 32)
        Me.BunifuCustomLabel1.TabIndex = 146
        Me.BunifuCustomLabel1.Text = "MEMBER RECORDS"
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BackColor = System.Drawing.Color.White
        Me.btnDeactivate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeactivate.ForeColor = System.Drawing.Color.White
        Me.btnDeactivate.Image = Nothing
        Me.btnDeactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeactivate.Location = New System.Drawing.Point(881, 200)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(175, 35)
        Me.btnDeactivate.TabIndex = 147
        Me.btnDeactivate.Text = "DEACTIVATE USER"
        Me.btnDeactivate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnactivate
        '
        Me.btnactivate.BackColor = System.Drawing.Color.White
        Me.btnactivate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactivate.ForeColor = System.Drawing.Color.White
        Me.btnactivate.Image = Nothing
        Me.btnactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactivate.Location = New System.Drawing.Point(1087, 200)
        Me.btnactivate.Name = "btnactivate"
        Me.btnactivate.Size = New System.Drawing.Size(165, 35)
        Me.btnactivate.TabIndex = 148
        Me.btnactivate.Text = "REACTIVATE USER"
        Me.btnactivate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = Nothing
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(30, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 33)
        Me.btnback.TabIndex = 149
        Me.btnback.Text = "Back"
        Me.btnback.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(877, 286)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(232, 21)
        Me.BunifuCustomLabel2.TabIndex = 151
        Me.BunifuCustomLabel2.Text = "Query Records Using Date    :"
        '
        'dtp2
        '
        Me.dtp2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(1011, 383)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(184, 26)
        Me.dtp2.TabIndex = 155
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(1011, 323)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(184, 26)
        Me.dtp1.TabIndex = 154
        '
        'BunifuCustomLabel25
        '
        Me.BunifuCustomLabel25.AutoSize = True
        Me.BunifuCustomLabel25.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(889, 383)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(68, 17)
        Me.BunifuCustomLabel25.TabIndex = 153
        Me.BunifuCustomLabel25.Text = "End Date"
        '
        'BunifuCustomLabel30
        '
        Me.BunifuCustomLabel30.AutoSize = True
        Me.BunifuCustomLabel30.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel30.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel30.Location = New System.Drawing.Point(884, 328)
        Me.BunifuCustomLabel30.Name = "BunifuCustomLabel30"
        Me.BunifuCustomLabel30.Size = New System.Drawing.Size(73, 17)
        Me.BunifuCustomLabel30.TabIndex = 152
        Me.BunifuCustomLabel30.Text = "Start Date"
        '
        'btnquery
        '
        Me.btnquery.BackColor = System.Drawing.Color.White
        Me.btnquery.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquery.ForeColor = System.Drawing.Color.White
        Me.btnquery.Image = Nothing
        Me.btnquery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquery.Location = New System.Drawing.Point(1011, 430)
        Me.btnquery.Name = "btnquery"
        Me.btnquery.Size = New System.Drawing.Size(75, 29)
        Me.btnquery.TabIndex = 156
        Me.btnquery.Text = "Query"
        Me.btnquery.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(877, 491)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(284, 21)
        Me.BunifuCustomLabel3.TabIndex = 157
        Me.BunifuCustomLabel3.Text = "Export Back up to Excel worksheet :"
        '
        'ITalk_Button_25
        '
        Me.ITalk_Button_25.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_25.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Image = Nothing
        Me.ITalk_Button_25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_25.Location = New System.Drawing.Point(1011, 524)
        Me.ITalk_Button_25.Name = "ITalk_Button_25"
        Me.ITalk_Button_25.Size = New System.Drawing.Size(150, 37)
        Me.ITalk_Button_25.TabIndex = 158
        Me.ITalk_Button_25.Text = "Export Database"
        Me.ITalk_Button_25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(1120, 430)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 29)
        Me.btnRefresh.TabIndex = 159
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(877, 58)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(259, 25)
        Me.BunifuCustomLabel4.TabIndex = 160
        Me.BunifuCustomLabel4.Text = "Database Operations    :"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 34
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.Black
        Me.dgw.Location = New System.Drawing.Point(30, 108)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(841, 464)
        Me.dgw.TabIndex = 179
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(595, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Welcome"
        Me.Label2.Visible = False
        '
        'viewmembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 645)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.ITalk_Button_25)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.btnquery)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.BunifuCustomLabel25)
        Me.Controls.Add(Me.BunifuCustomLabel30)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnactivate)
        Me.Controls.Add(Me.btnDeactivate)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.txtoption)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "viewmembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtoption As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btnsearch As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents txtsearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnDeactivate As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents btnactivate As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents btnback As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel30 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnquery As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ITalk_Button_25 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents btnRefresh As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class