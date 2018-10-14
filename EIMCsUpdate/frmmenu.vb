Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmmenu
    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim fn As String
    Dim use As String
    Private Sub BunifuTileButton1_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        members.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton4.Click
        Me.Hide()
        viewmembers.Show()

    End Sub


    Private Sub btnloan_Click(sender As System.Object, e As System.EventArgs) Handles btnloan.Click
        Me.Hide()
        Loan.Show()

    End Sub

    Private Sub BunifuTileButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton2.Click
        Me.Hide()
        frmclearloan.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton3.Click
        Me.Hide()


        frmviewloans.Show()


    End Sub

    Private Sub BunifuTileButton6_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton6.Click
        Me.Hide()
        frmschedule.Show()
    End Sub

    Private Sub BunifuTileButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton5.Click
        Me.Hide()
        frmaddadminvb.Show()

    End Sub

    Sub logs()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "logged out"


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", Label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub BunifuTileButton7_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton7.Click
        Me.Hide()
        controlpanel.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        MsgBox("Loging out " & Label2.Text, vbInformation)
        logs()
        Me.Hide()
        Signin.Show()
    End Sub
End Class