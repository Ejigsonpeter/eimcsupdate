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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ITalk_Button_21 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Panel2 = New EIMCsUpdate.iTalk.iTalk_Panel()
        Me.BunifuCustomLabel30 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.btnquery = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnRefresh = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Panel1 = New EIMCsUpdate.iTalk.iTalk_Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtoption = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtsearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnsearch = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_25 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnback = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ITalk_Panel2.SuspendLayout()
        Me.ITalk_Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(543, 25)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(236, 34)
        Me.BunifuCustomLabel1.TabIndex = 184
        Me.BunifuCustomLabel1.Text = "LOAN RECORDS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(928, 615)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Welcome"
        Me.Label2.Visible = False
        '
        'dgw
        '
        Me.dgw.AllowUserToOrderColumns = True
        Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgw.Location = New System.Drawing.Point(23, 184)
        Me.dgw.Name = "dgw"
        Me.dgw.Size = New System.Drawing.Size(1231, 396)
        Me.dgw.TabIndex = 219
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(941, 588)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(147, 39)
        Me.ITalk_Button_21.TabIndex = 226
        Me.ITalk_Button_21.Text = "Print Records"
        Me.ITalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Panel2
        '
        Me.ITalk_Panel2.BackColor = System.Drawing.Color.White
        Me.ITalk_Panel2.Controls.Add(Me.BunifuCustomLabel30)
        Me.ITalk_Panel2.Controls.Add(Me.dtp1)
        Me.ITalk_Panel2.Controls.Add(Me.BunifuCustomLabel25)
        Me.ITalk_Panel2.Controls.Add(Me.dtp2)
        Me.ITalk_Panel2.Controls.Add(Me.btnquery)
        Me.ITalk_Panel2.Controls.Add(Me.btnRefresh)
        Me.ITalk_Panel2.Location = New System.Drawing.Point(589, 90)
        Me.ITalk_Panel2.Name = "ITalk_Panel2"
        Me.ITalk_Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.ITalk_Panel2.Size = New System.Drawing.Size(665, 83)
        Me.ITalk_Panel2.TabIndex = 221
        Me.ITalk_Panel2.Text = "ITalk_Panel2"
        '
        'BunifuCustomLabel30
        '
        Me.BunifuCustomLabel30.AutoSize = True
        Me.BunifuCustomLabel30.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel30.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel30.Location = New System.Drawing.Point(18, 16)
        Me.BunifuCustomLabel30.Name = "BunifuCustomLabel30"
        Me.BunifuCustomLabel30.Size = New System.Drawing.Size(73, 17)
        Me.BunifuCustomLabel30.TabIndex = 187
        Me.BunifuCustomLabel30.Text = "Start Date"
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(21, 37)
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
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(255, 16)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(68, 17)
        Me.BunifuCustomLabel25.TabIndex = 188
        Me.BunifuCustomLabel25.Text = "End Date"
        '
        'dtp2
        '
        Me.dtp2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(258, 37)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(184, 26)
        Me.dtp2.TabIndex = 190
        '
        'btnquery
        '
        Me.btnquery.BackColor = System.Drawing.Color.White
        Me.btnquery.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquery.ForeColor = System.Drawing.Color.White
        Me.btnquery.Image = Nothing
        Me.btnquery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquery.Location = New System.Drawing.Point(477, 34)
        Me.btnquery.Name = "btnquery"
        Me.btnquery.Size = New System.Drawing.Size(75, 29)
        Me.btnquery.TabIndex = 191
        Me.btnquery.Text = "Query"
        Me.btnquery.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(563, 34)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 29)
        Me.btnRefresh.TabIndex = 194
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Panel1
        '
        Me.ITalk_Panel1.BackColor = System.Drawing.Color.White
        Me.ITalk_Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.ITalk_Panel1.Controls.Add(Me.txtoption)
        Me.ITalk_Panel1.Controls.Add(Me.txtsearch)
        Me.ITalk_Panel1.Controls.Add(Me.btnsearch)
        Me.ITalk_Panel1.Location = New System.Drawing.Point(27, 90)
        Me.ITalk_Panel1.Name = "ITalk_Panel1"
        Me.ITalk_Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.ITalk_Panel1.Size = New System.Drawing.Size(538, 83)
        Me.ITalk_Panel1.TabIndex = 220
        Me.ITalk_Panel1.Text = "ITalk_Panel1"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(8, 16)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(146, 17)
        Me.BunifuCustomLabel3.TabIndex = 188
        Me.BunifuCustomLabel3.Text = "Select Option Below :"
        '
        'txtoption
        '
        Me.txtoption.BackColor = System.Drawing.Color.Transparent
        Me.txtoption.BorderRadius = 3
        Me.txtoption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtoption.DisabledColor = System.Drawing.Color.Gray
        Me.txtoption.ForeColor = System.Drawing.Color.Black
        Me.txtoption.Items = New String() {"", "IPPS Number"}
        Me.txtoption.Location = New System.Drawing.Point(11, 36)
        Me.txtoption.Name = "txtoption"
        Me.txtoption.NomalColor = System.Drawing.Color.White
        Me.txtoption.onHoverColor = System.Drawing.Color.White
        Me.txtoption.selectedIndex = -1
        Me.txtoption.Size = New System.Drawing.Size(154, 27)
        Me.txtoption.TabIndex = 182
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txtsearch.Location = New System.Drawing.Point(172, 36)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(115, 27)
        Me.txtsearch.TabIndex = 180
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Nothing
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(294, 36)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 27)
        Me.btnsearch.TabIndex = 181
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_25
        '
        Me.ITalk_Button_25.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_25.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Image = Nothing
        Me.ITalk_Button_25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_25.Location = New System.Drawing.Point(1104, 588)
        Me.ITalk_Button_25.Name = "ITalk_Button_25"
        Me.ITalk_Button_25.Size = New System.Drawing.Size(150, 37)
        Me.ITalk_Button_25.TabIndex = 193
        Me.ITalk_Button_25.Text = "Export Database"
        Me.ITalk_Button_25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = Nothing
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(23, 25)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 33)
        Me.btnback.TabIndex = 185
        Me.btnback.Text = "Back"
        Me.btnback.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.Controls.Add(Me.ITalk_Button_21)
        Me.Controls.Add(Me.ITalk_Panel2)
        Me.Controls.Add(Me.ITalk_Panel1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ITalk_Button_25)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmviewloans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmviewloans"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ITalk_Panel2.ResumeLayout(False)
        Me.ITalk_Panel2.PerformLayout()
        Me.ITalk_Panel1.ResumeLayout(False)
        Me.ITalk_Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRefresh As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_25 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents btnquery As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel30 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnback As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtoption As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btnsearch As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents txtsearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents ITalk_Panel1 As EIMCsUpdate.iTalk.iTalk_Panel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ITalk_Panel2 As EIMCsUpdate.iTalk.iTalk_Panel
    Friend WithEvents ITalk_Button_21 As EIMCsUpdate.iTalk.iTalk_Button_2
End Class
