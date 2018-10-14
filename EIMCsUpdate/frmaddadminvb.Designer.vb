<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddadminvb
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
        Me.btnback = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtpass = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.txtid = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnpassword = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ITalk_Button_21 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_22 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.txtcpassword = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.txtusername = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = Nothing
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(31, 46)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 33)
        Me.btnback.TabIndex = 154
        Me.btnback.Text = "Back"
        Me.btnback.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.spaced
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 643)
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(237, 286)
        Me.txtpass.MaxLength = 32767
        Me.txtpass.Multiline = False
        Me.txtpass.Name = "txtpass"
        Me.txtpass.ReadOnly = False
        Me.txtpass.Size = New System.Drawing.Size(351, 31)
        Me.txtpass.TabIndex = 158
        Me.txtpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(238, 214)
        Me.txtid.MaxLength = 32767
        Me.txtid.Multiline = False
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = False
        Me.txtid.Size = New System.Drawing.Size(350, 31)
        Me.txtid.TabIndex = 157
        Me.txtid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtid.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(234, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 21)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Old Password :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(231, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = " Username :"
        '
        'txtnpassword
        '
        Me.txtnpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtnpassword.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpassword.ForeColor = System.Drawing.Color.Black
        Me.txtnpassword.Location = New System.Drawing.Point(236, 372)
        Me.txtnpassword.MaxLength = 32767
        Me.txtnpassword.Multiline = False
        Me.txtnpassword.Name = "txtnpassword"
        Me.txtnpassword.ReadOnly = False
        Me.txtnpassword.Size = New System.Drawing.Size(352, 31)
        Me.txtnpassword.TabIndex = 160
        Me.txtnpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnpassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(233, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 21)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "New Password:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(545, 36)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(270, 32)
        Me.BunifuCustomLabel1.TabIndex = 213
        Me.BunifuCustomLabel1.Text = "ACCESS CONTROL"
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(237, 453)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(351, 46)
        Me.ITalk_Button_21.TabIndex = 214
        Me.ITalk_Button_21.Text = "SUBMIT"
        Me.ITalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_22
        '
        Me.ITalk_Button_22.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_22.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Image = Nothing
        Me.ITalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_22.Location = New System.Drawing.Point(727, 453)
        Me.ITalk_Button_22.Name = "ITalk_Button_22"
        Me.ITalk_Button_22.Size = New System.Drawing.Size(351, 46)
        Me.ITalk_Button_22.TabIndex = 221
        Me.ITalk_Button_22.Text = "SUBMIT"
        Me.ITalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtcpassword
        '
        Me.txtcpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtcpassword.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpassword.ForeColor = System.Drawing.Color.Black
        Me.txtcpassword.Location = New System.Drawing.Point(726, 372)
        Me.txtcpassword.MaxLength = 32767
        Me.txtcpassword.Multiline = False
        Me.txtcpassword.Name = "txtcpassword"
        Me.txtcpassword.ReadOnly = False
        Me.txtcpassword.Size = New System.Drawing.Size(352, 31)
        Me.txtcpassword.TabIndex = 220
        Me.txtcpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcpassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(723, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 21)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "Confirm Password:"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(727, 286)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.Multiline = False
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.ReadOnly = False
        Me.txtpassword.Size = New System.Drawing.Size(351, 31)
        Me.txtpassword.TabIndex = 218
        Me.txtpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(728, 214)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.Multiline = False
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = False
        Me.txtusername.Size = New System.Drawing.Size(350, 31)
        Me.txtusername.TabIndex = 217
        Me.txtusername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtusername.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(724, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 21)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "Password :"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(721, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 21)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = " Username :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(282, 138)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(234, 24)
        Me.BunifuCustomLabel2.TabIndex = 222
        Me.BunifuCustomLabel2.Text = "CHANGE PASSWORD"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(755, 138)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(176, 24)
        Me.BunifuCustomLabel3.TabIndex = 223
        Me.BunifuCustomLabel3.Text = "ADD NEW USER"
        '
        'frmaddadminvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 645)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.ITalk_Button_22)
        Me.Controls.Add(Me.txtcpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ITalk_Button_21)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtnpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmaddadminvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmaddadminvb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpass As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents txtid As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnpassword As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ITalk_Button_21 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_22 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents txtcpassword As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents txtusername As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
