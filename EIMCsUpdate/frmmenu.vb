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

        members.Label2.Text = Me.Label2.Text

        Me.Hide()
        members.Show()

    End Sub

    Private Sub BunifuTileButton4_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton4.Click
        'fully logged
        viewmembers.Label2.Text = Me.Label2.Text
        Me.Hide()
        viewmembers.Show()


       
    End Sub


    Private Sub btnloan_Click(sender As System.Object, e As System.EventArgs) Handles btnloan.Click
        'logged fully
        Me.Hide()
        Loan.Show()

        Loan.TextBox1.Text = Me.Label2.Text

    End Sub

    Private Sub BunifuTileButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton2.Click
        'logged
        clearloan.TextBox1.Text = Me.Label2.Text
        Me.Hide()
        clearloan.Show()

    End Sub

    Private Sub BunifuTileButton3_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton3.Click
        'fully logged
        frmviewloans.Label2.Text = Me.Label2.Text
        Me.Hide()
        frmviewloans.Show()


    End Sub

    Private Sub BunifuTileButton6_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton6.Click
        'fully logged
        frmschedule.Label2.Text = Me.Label2.Text
        frmschedule.Show()
        Me.Hide()



    End Sub

    Private Sub BunifuTileButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton5.Click
        frmaddadminvb.Labelx.Text = Me.Label2.Text
        'fully logged
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
        'logged
        Me.Hide()
        controlpanel.Label2.Text = Me.Label2.Text
        controlpanel.Show()

    End Sub


    Private Sub BunifuTileButton9_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton9.Click
        'fully logged
        MsgBox("Loging out " & Label2.Text, vbInformation)
        logs()
        Me.Hide()
        Signin.Show()
    End Sub

    Private Sub BunifuTileButton8_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton8.Click
        'fully logged

        systemlog.Label2.Text = Me.Label2.Text
        Me.Hide()

        systemlog.Show()
    End Sub
End Class