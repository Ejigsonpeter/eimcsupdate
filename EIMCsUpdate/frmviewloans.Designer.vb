<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewloans
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnRefresh = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_25 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnquery = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel30 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnback = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtoption = New Bunifu.Framework.UI.BunifuDropdown()
        Me.btnsearch = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.txtsearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgw.Location = New System.Drawing.Point(27, 138)
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
        Me.dgw.TabIndex = 196
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(874, 88)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(259, 25)
        Me.BunifuCustomLabel4.TabIndex = 195
        Me.BunifuCustomLabel4.Text = "Database Operations    :"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(1117, 401)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 29)
        Me.btnRefresh.TabIndex = 194
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_25
        '
        Me.ITalk_Button_25.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_25.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Image = Nothing
        Me.ITalk_Button_25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_25.Location = New System.Drawing.Point(1008, 502)
        Me.ITalk_Button_25.Name = "ITalk_Button_25"
        Me.ITalk_Button_25.Size = New System.Drawing.Size(150, 37)
        Me.ITalk_Button_25.TabIndex = 193
        Me.ITalk_Button_25.Text = "Export Database"
        Me.ITalk_Button_25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(874, 458)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(284, 21)
        Me.BunifuCustomLabel3.TabIndex = 192
        Me.BunifuCustomLabel3.Text = "Export Back up to Excel worksheet :"
        '
        'btnquery
        '
        Me.btnquery.BackColor = System.Drawing.Color.White
        Me.btnquery.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquery.ForeColor = System.Drawing.Color.White
        Me.btnquery.Image = Nothing
        Me.btnquery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquery.Location = New System.Drawing.Point(1008, 401)
        Me.btnquery.Name = "btnquery"
        Me.btnquery.Size = New System.Drawing.Size(75, 29)
        Me.btnquery.TabIndex = 191
        Me.btnquery.Text = "Query"
        Me.btnquery.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dtp2
        '
        Me.dtp2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(1008, 351)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(184, 26)
        Me.dtp2.TabIndex = 190
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(1008, 291)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(184, 26)
        Me.dtp1.TabIndex = 189
        '
        'BunifuCustomLabel25
        '
        Me.BunifuCustomLabel25.AutoSize = True
        Me.BunifuCustomLabel25.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(886, 351)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(68, 17)
        Me.BunifuCustomLabel25.TabIndex = 188
        Me.BunifuCustomLabel25.Text = "End Date"
        '
        'BunifuCustomLabel30
        '
        Me.BunifuCustomLabel30.AutoSize = True
        Me.BunifuCustomLabel30.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel30.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel30.Location = New System.Drawing.Point(881, 296)
        Me.BunifuCustomLabel30.Name = "BunifuCustomLabel30"
        Me.BunifuCustomLabel30.Size = New System.Drawing.Size(73, 17)
        Me.BunifuCustomLabel30.TabIndex = 187
        Me.BunifuCustomLabel30.Text = "Start Date"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(870, 243)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(232, 21)
        Me.BunifuCustomLabel2.TabIndex = 186
        Me.BunifuCustomLabel2.Text = "Query Records Using Date    :"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = Nothing
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(27, 42)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 33)
        Me.btnback.TabIndex = 185
        Me.btnback.Text = "Back"
        Me.btnback.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(351, 103)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(234, 32)
        Me.BunifuCustomLabel1.TabIndex = 184
        Me.BunifuCustomLabel1.Text = "LOAN RECORDS"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(874, 138)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(179, 21)
        Me.BunifuCustomLabel5.TabIndex = 183
        Me.BunifuCustomLabel5.Text = "Select  Option Below :"
        '
        'txtoption
        '
        Me.txtoption.BackColor = System.Drawing.Color.Transparent
        Me.txtoption.BorderRadius = 3
        Me.txtoption.DisabledColor = System.Drawing.Color.Gray
        Me.txtoption.ForeColor = System.Drawing.Color.Black
        Me.txtoption.Items = New String() {"", "IPPS Number"}
        Me.txtoption.Location = New System.Drawing.Point(874, 162)
        Me.txtoption.Name = "txtoption"
        Me.txtoption.NomalColor = System.Drawing.Color.White
        Me.txtoption.onHoverColor = System.Drawing.Color.White
        Me.txtoption.selectedIndex = -1
        Me.txtoption.Size = New System.Drawing.Size(154, 35)
        Me.txtoption.TabIndex = 182
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Nothing
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(1174, 163)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 34)
        Me.btnsearch.TabIndex = 181
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
        Me.txtsearch.Location = New System.Drawing.Point(1046, 163)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(115, 35)
        Me.txtsearch.TabIndex = 180
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(601, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Welcome"
        Me.Label2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.spaced2
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 684)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmviewloans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 645)
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
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.txtoption)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmviewloans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmviewloans"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnRefresh As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_25 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnquery As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel30 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnback As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtoption As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btnsearch As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents txtsearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
