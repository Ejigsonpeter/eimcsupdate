<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class systemlog
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
        Me.BunifuCustomLabel30 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ITalk_Button_25 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_21 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Panel2 = New EIMCsUpdate.iTalk.iTalk_Panel()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.btnquery = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnRefresh = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnback = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ITalk_Panel2.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.spaced2
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 684)
        Me.PictureBox1.TabIndex = 227
        Me.PictureBox1.TabStop = False
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
        'ITalk_Button_25
        '
        Me.ITalk_Button_25.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_25.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_25.Image = Nothing
        Me.ITalk_Button_25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_25.Location = New System.Drawing.Point(1079, 578)
        Me.ITalk_Button_25.Name = "ITalk_Button_25"
        Me.ITalk_Button_25.Size = New System.Drawing.Size(150, 37)
        Me.ITalk_Button_25.TabIndex = 230
        Me.ITalk_Button_25.Text = "Export Database"
        Me.ITalk_Button_25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(916, 578)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(147, 39)
        Me.ITalk_Button_21.TabIndex = 235
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
        Me.ITalk_Panel2.Location = New System.Drawing.Point(564, 87)
        Me.ITalk_Panel2.Name = "ITalk_Panel2"
        Me.ITalk_Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.ITalk_Panel2.Size = New System.Drawing.Size(665, 83)
        Me.ITalk_Panel2.TabIndex = 234
        Me.ITalk_Panel2.Text = "ITalk_Panel2"
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
        'dgw
        '
        Me.dgw.AllowUserToOrderColumns = True
        Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgw.Location = New System.Drawing.Point(18, 176)
        Me.dgw.Name = "dgw"
        Me.dgw.Size = New System.Drawing.Size(1211, 396)
        Me.dgw.TabIndex = 232
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(923, 607)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Welcome"
        Me.Label2.Visible = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = Nothing
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(18, 17)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 33)
        Me.btnback.TabIndex = 229
        Me.btnback.Text = "Back"
        Me.btnback.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(538, 17)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(210, 34)
        Me.BunifuCustomLabel1.TabIndex = 228
        Me.BunifuCustomLabel1.Text = "SYSTEM LOGS"
        '
        'systemlog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 645)
        Me.Controls.Add(Me.ITalk_Button_25)
        Me.Controls.Add(Me.ITalk_Button_21)
        Me.Controls.Add(Me.ITalk_Panel2)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "systemlog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "systemlog"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ITalk_Panel2.ResumeLayout(False)
        Me.ITalk_Panel2.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel30 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ITalk_Button_25 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_21 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Panel2 As EIMCsUpdate.iTalk.iTalk_Panel
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnquery As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents btnRefresh As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnback As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
