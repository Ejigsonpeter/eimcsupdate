<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signin))
        Me.btncancel = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnLogin = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtid = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        Me.txtpass = New EIMCsUpdate.iTalk.iTalk_TextBox_Small()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Image = Nothing
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(1060, 389)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(118, 42)
        Me.btncancel.TabIndex = 142
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(926, 389)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(118, 42)
        Me.btnLogin.TabIndex = 141
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.EIMCsUpdate.My.Resources.Resources.xx
        Me.Label2.Location = New System.Drawing.Point(922, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 21)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.EIMCsUpdate.My.Resources.Resources.xx
        Me.Label1.Location = New System.Drawing.Point(919, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = " Username :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.login_pagef
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 643)
        Me.PictureBox1.TabIndex = 140
        Me.PictureBox1.TabStop = False
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(926, 262)
        Me.txtid.MaxLength = 32767
        Me.txtid.Multiline = False
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = False
        Me.txtid.Size = New System.Drawing.Size(252, 38)
        Me.txtid.TabIndex = 147
        Me.txtid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtid.UseSystemPasswordChar = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!)
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(925, 334)
        Me.txtpass.MaxLength = 32767
        Me.txtpass.Multiline = False
        Me.txtpass.Name = "txtpass"
        Me.txtpass.ReadOnly = False
        Me.txtpass.Size = New System.Drawing.Size(253, 38)
        Me.txtpass.TabIndex = 148
        Me.txtpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 645)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Signin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancel As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents btnLogin As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtid As EIMCsUpdate.iTalk.iTalk_TextBox_Small
    Friend WithEvents txtpass As EIMCsUpdate.iTalk.iTalk_TextBox_Small
End Class
