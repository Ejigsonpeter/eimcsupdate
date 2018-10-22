
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmscheduling
    Dim imgName1 As String
    Dim imgName2 As String
    Dim imgName3 As String
    Dim imgName4 As String
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As MySqlCommand
    Dim firstdate As Date
    Dim seconddate As Date
    Dim msg, msg2, msg3 As Double
    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}




    Sub grid()
        Try
            Myconnection.Close()
            Myconnection.Open()
            
            Dim selectQuery As String = "select sno,ippsno,loantype,amountpayble,status,datepaid,amountpaid from loan"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, Myconnection)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            dgw.DataSource = ds.Tables(0)
            Myconnection.Close()
            dgw.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmscheduling_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        grid()

    End Sub

    Private Sub ITalk_Button_23_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_23.Click
        Me.Hide()
        frmschedule.Show()

    End Sub
End Class