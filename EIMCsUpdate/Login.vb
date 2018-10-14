
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    '' creating mysql connection
    'Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    'Dim dr As MySqlDataReader
    'Dim da As MySqlDataAdapter
    'Dim cmd As MySqlCommand
    'Dim fn As String


    'Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click

    '    If txtid.Text = "" Then
    '        MsgBox("Enter user ID", vbCritical)
    '    ElseIf txtpass.Text = "" Then
    '        MsgBox("Enter user pass ", vbCritical)
    '    ElseIf txtid.Text = "admin" And txtpass.Text = "12345" Then
    '        MsgBox("Access Granted", vbInformation)
    '        Me.Hide()
    '        frmmenu.Show()
    '    Else
    '        'Try
    '        Myconnection.Open()
    '        Dim query As String
    '        Dim reader As MySqlDataReader
    '        Dim status As String
    '        status = "active"
    '        query = "Select * from users where userid = '" & txtid.Text & "' and password = '" & txtpass.Text & "' and status = '" & status & "'"
    '        cmd = New MySqlCommand(query, Myconnection)
    '        reader = cmd.ExecuteReader
    '        Dim count As Integer
    '        count = 0
    '        While reader.Read
    '            count = count + 1
    '        End While
    '        If count > 0 Then
    '            MsgBox("Access Granted ", vbInformation)
    '            frmmenu.Label2.Text = reader.Item("fullname").ToString
    '            members.Label2.Text = reader.Item("fullname").ToString
    '            fn = reader.Item("fullname").ToString

    '            MsgBox("Access Granted  " & fn, vbInformation)


    '            Me.Hide()
    '            frmmenu.Show()

    '            'logfailed()

    '        Else
    '            MsgBox("Access Denied! Incorret Login Details", vbCritical)
    '            logfailed()
    '            clear()
    '        End If


    '        'Catch ex As Exception
    '        '    MsgBox(ex.Message)
    '        'End Try
    '    End If
    'End Sub
    'Sub clear()
    '    txtid.Text = ""
    '    txtpass.Text = ""
    'End Sub

    'Sub logfailed()
    '    Try
    '        Myconnection.Close()
    '        Myconnection.Open()
    '        Dim at, task, n As String
    '        at = Now
    '        task = "login Failed"

    '        n = txtid.Text
    '        Dim sql As String



    '        sql = "insert into logs (fullname,Task,activity_time)" _
    '                & "VALUES(@fullname,@task,@activitytime)"

    '        Dim cmdx As New MySqlCommand(sql, Myconnection)
    '        cmdx.Parameters.AddWithValue("@fullname", n)
    '        cmdx.Parameters.AddWithValue("@task", task)
    '        cmdx.Parameters.AddWithValue("@activitytime", at)

    '        cmdx.ExecuteNonQuery()

    '        Myconnection.Close()

    '        clear()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try



    'End Sub
    'Sub logs()
    '    'Try
    '    Myconnection.Close()
    '    Myconnection.Open()
    '    Dim at, task As String
    '    at = Now
    '    task = "login Success"


    '    Dim sql As String



    '    sql = "insert into logs (fullname,Task,activity_time)" _
    '            & "VALUES(@fullname,@task,@activitytime)"

    '    Dim cmdx As New MySqlCommand(sql, Myconnection)
    '    cmdx.Parameters.AddWithValue("@fullname", fn)
    '    cmdx.Parameters.AddWithValue("@task", task)
    '    cmdx.Parameters.AddWithValue("@activitytime", at)

    '    cmdx.ExecuteNonQuery()

    '    clear()


    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)

    '    'End Try



    'End Sub




    'Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs)

    End Sub

   
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncancel = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.btnLogin = New EIMCsUpdate.iTalk.iTalk_Button_2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(926, 263)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 29)
        Me.TextBox1.TabIndex = 136
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(926, 317)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(252, 29)
        Me.TextBox2.TabIndex = 137
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.EIMCsUpdate.My.Resources.Resources.xx
        Me.Label2.Location = New System.Drawing.Point(922, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 21)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.EIMCsUpdate.My.Resources.Resources.xx
        Me.Label1.Location = New System.Drawing.Point(926, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = " Username :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.login_pagef
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 643)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Image = Nothing
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(1060, 370)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(118, 31)
        Me.btncancel.TabIndex = 134
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
        Me.btnLogin.Location = New System.Drawing.Point(926, 370)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(118, 31)
        Me.btnLogin.TabIndex = 133
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1264, 645)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    
    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click

    End Sub
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
