Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Signin


    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim fn As String
    Dim use As String
        
    

    Sub clear()
        txtid.Text = ""
        txtpass.Text = ""
    End Sub

    Sub logfailed()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task, n As String
            at = Now
            task = "login Failed"

            n = txtid.Text
            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", n)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()

            Myconnection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub
    Sub logs()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "login Success"


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", fn)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()

            clear()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub



   



    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If txtid.Text = "" Then
            MsgBox("Enter user ID", vbCritical)
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter user pass ", vbCritical)
        ElseIf txtid.Text = "admin" And txtpass.Text = "12345" Then
            MsgBox("Access Granted", vbInformation)
            Me.Hide()
            frmmenu.Show()
        Else
            Try
                Myconnection.Open()
                Dim query As String
                Dim reader As MySqlDataReader
                Dim status As String
                status = "active"
                query = "Select * from users where userid = '" & txtid.Text & "' and password = '" & txtpass.Text & "' and status = '" & status & "'"
                cmd = New MySqlCommand(query, Myconnection)
                reader = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then

                    Dim x As String

                    x = reader.Item("fullname").ToString
                    frmmenu.Label2.Text = x
                    members.Label2.Text = x
                    Loan.TextBox1.Text = x
                    viewmembers.Label2.Text = x
                    frmclearloan.TextBox1.Text = x

                    frmviewloans.Label2.Text = x




                    fn = reader.Item("fullname").ToString

                    MsgBox("Access Granted  " & fn, vbInformation)
                    Me.Hide()
                    frmmenu.Show()
                    logs()


                Else
                    MsgBox("Access Denied! Incorret Login Details", vbCritical)
                    logfailed()
                    clear()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        clear()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class