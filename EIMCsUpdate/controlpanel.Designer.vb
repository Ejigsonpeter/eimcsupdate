<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlpanel
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
        Me.BunifuCustomLabel57 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtm = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtoption = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtsearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtextend = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtd2 = New System.Windows.Forms.TextBox()
        Me.txtd1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtshares = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtsavings = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ITalk_Button_24 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_22 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_21 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnsearch = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_23 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel57
        '
        Me.BunifuCustomLabel57.AutoSize = True
        Me.BunifuCustomLabel57.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel57.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel57.Location = New System.Drawing.Point(12, 25)
        Me.BunifuCustomLabel57.Name = "BunifuCustomLabel57"
        Me.BunifuCustomLabel57.Size = New System.Drawing.Size(215, 22)
        Me.BunifuCustomLabel57.TabIndex = 220
        Me.BunifuCustomLabel57.Text = " Select Loan Category"
        '
        'txtm
        '
        Me.txtm.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtm.FormattingEnabled = True
        Me.txtm.Items.AddRange(New Object() {"Long Term Cash Loan LTCL", "Short Term Cash Loan STCL", "Long Term Material Sales LMTS", "4 months Short Term Material Sales STMS ", "12 months Short Term Material Sales STMS ", "Emergency Loan", "Savings Withdrawal", "Special Savings"})
        Me.txtm.Location = New System.Drawing.Point(15, 55)
        Me.txtm.Name = "txtm"
        Me.txtm.Size = New System.Drawing.Size(331, 30)
        Me.txtm.TabIndex = 219
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(748, 73)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(179, 21)
        Me.BunifuCustomLabel5.TabIndex = 218
        Me.BunifuCustomLabel5.Text = "Select  Option Below :"
        '
        'txtoption
        '
        Me.txtoption.BackColor = System.Drawing.Color.Transparent
        Me.txtoption.BorderRadius = 3
        Me.txtoption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtoption.DisabledColor = System.Drawing.Color.Gray
        Me.txtoption.ForeColor = System.Drawing.Color.Black
        Me.txtoption.Items = New String() {"", "IPPS Number"}
        Me.txtoption.Location = New System.Drawing.Point(752, 97)
        Me.txtoption.Name = "txtoption"
        Me.txtoption.NomalColor = System.Drawing.Color.White
        Me.txtoption.onHoverColor = System.Drawing.Color.White
        Me.txtoption.selectedIndex = -1
        Me.txtoption.Size = New System.Drawing.Size(154, 35)
        Me.txtoption.TabIndex = 217
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
        Me.txtsearch.Location = New System.Drawing.Point(924, 98)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(115, 35)
        Me.txtsearch.TabIndex = 216
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(516, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(300, 34)
        Me.BunifuCustomLabel1.TabIndex = 215
        Me.BunifuCustomLabel1.Text = "Resolve Transactions"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(12, 88)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(191, 22)
        Me.BunifuCustomLabel4.TabIndex = 227
        Me.BunifuCustomLabel4.Text = "Extend Duration by "
        '
        'txtextend
        '
        Me.txtextend.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextend.Location = New System.Drawing.Point(15, 113)
        Me.txtextend.Name = "txtextend"
        Me.txtextend.Size = New System.Drawing.Size(292, 31)
        Me.txtextend.TabIndex = 226
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(785, 609)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 254
        Me.TextBox2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(910, 598)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(143, 31)
        Me.DataGridView1.TabIndex = 251
        Me.DataGridView1.Visible = False
        '
        'txtd2
        '
        Me.txtd2.Location = New System.Drawing.Point(910, 560)
        Me.txtd2.Name = "txtd2"
        Me.txtd2.Size = New System.Drawing.Size(100, 20)
        Me.txtd2.TabIndex = 248
        Me.txtd2.Visible = False
        '
        'txtd1
        '
        Me.txtd1.Location = New System.Drawing.Point(785, 560)
        Me.txtd1.Name = "txtd1"
        Me.txtd1.Size = New System.Drawing.Size(100, 20)
        Me.txtd1.TabIndex = 247
        Me.txtd1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ITalk_Button_21)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.txtm)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel57)
        Me.GroupBox1.Controls.Add(Me.txtextend)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(141, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 202)
        Me.GroupBox1.TabIndex = 256
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extend Loan Payment"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(313, 119)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(91, 22)
        Me.BunifuCustomLabel6.TabIndex = 228
        Me.BunifuCustomLabel6.Text = "Month(s)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.spaced
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 655)
        Me.PictureBox1.TabIndex = 212
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.ITalk_Button_24)
        Me.GroupBox2.Controls.Add(Me.txtshares)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox2.Controls.Add(Me.ITalk_Button_22)
        Me.GroupBox2.Controls.Add(Me.txtsavings)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(640, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 202)
        Me.GroupBox2.TabIndex = 257
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Update Shares and Savings"
        '
        'txtshares
        '
        Me.txtshares.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshares.Location = New System.Drawing.Point(15, 110)
        Me.txtshares.Name = "txtshares"
        Me.txtshares.Size = New System.Drawing.Size(292, 31)
        Me.txtshares.TabIndex = 230
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(12, 85)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(121, 22)
        Me.BunifuCustomLabel3.TabIndex = 231
        Me.BunifuCustomLabel3.Text = "New Shares "
        '
        'txtsavings
        '
        Me.txtsavings.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsavings.Location = New System.Drawing.Point(14, 48)
        Me.txtsavings.Name = "txtsavings"
        Me.txtsavings.Size = New System.Drawing.Size(292, 31)
        Me.txtsavings.TabIndex = 226
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(11, 25)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(127, 22)
        Me.BunifuCustomLabel7.TabIndex = 227
        Me.BunifuCustomLabel7.Text = "New Savings"
        '
        'ITalk_Button_24
        '
        Me.ITalk_Button_24.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_24.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_24.Image = Nothing
        Me.ITalk_Button_24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_24.Location = New System.Drawing.Point(313, 113)
        Me.ITalk_Button_24.Name = "ITalk_Button_24"
        Me.ITalk_Button_24.Size = New System.Drawing.Size(162, 34)
        Me.ITalk_Button_24.TabIndex = 232
        Me.ITalk_Button_24.Text = "Update Transaction"
        Me.ITalk_Button_24.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_22
        '
        Me.ITalk_Button_22.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_22.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Image = Nothing
        Me.ITalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_22.Location = New System.Drawing.Point(312, 45)
        Me.ITalk_Button_22.Name = "ITalk_Button_22"
        Me.ITalk_Button_22.Size = New System.Drawing.Size(162, 34)
        Me.ITalk_Button_22.TabIndex = 229
        Me.ITalk_Button_22.Text = "Update Transaction"
        Me.ITalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(145, 150)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(162, 34)
        Me.ITalk_Button_21.TabIndex = 229
        Me.ITalk_Button_21.Text = "Update Transaction"
        Me.ITalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Nothing
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(1062, 99)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 34)
        Me.btnsearch.TabIndex = 255
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_23
        '
        Me.ITalk_Button_23.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_23.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_23.Image = Nothing
        Me.ITalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_23.Location = New System.Drawing.Point(24, 35)
        Me.ITalk_Button_23.Name = "ITalk_Button_23"
        Me.ITalk_Button_23.Size = New System.Drawing.Size(135, 32)
        Me.ITalk_Button_23.TabIndex = 214
        Me.ITalk_Button_23.Text = "Back"
        Me.ITalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(387, 102)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 13)
        Me.label2.TabIndex = 258
        Me.label2.Text = "Label1"
        Me.label2.Visible = False
        '
        'controlpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 645)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtd2)
        Me.Controls.Add(Me.txtd1)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.txtoption)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.ITalk_Button_23)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "controlpanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "controlpanel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ITalk_Button_23 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel57 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtm As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtoption As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtsearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtextend As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtd1 As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ITalk_Button_21 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ITalk_Button_24 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents txtshares As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ITalk_Button_22 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents txtsavings As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents label2 As System.Windows.Forms.Label
End Class
