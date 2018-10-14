
Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data

Imports Excel = Microsoft.Office.Interop.Excel



Public Class frmviewloans
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
    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select An option ", vbInformation)
        ElseIf txtsearch.Text = "" Then
            MsgBox("Space cannot be Empty", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                vouncher1()
            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                vouncher1()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                vouncher1()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                vouncher1()
            Else
                vouncher1()
            End If
       

        End If
    End Sub

    Sub vouncher1()
        Dim x As String
        x = txtsearch.Text
        Myconnection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("Select  * from loan", Myconnection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgw.DataSource = view1
        dgw.Refresh()
        source1.Filter = "ippsno = '" & x & "'"
        dgw.Refresh()
        Myconnection.Close()



    End Sub
    Private Sub frmviewloans_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        grid()
    End Sub

    Sub grid()

        Try
            Myconnection.Close()
            Myconnection.Open()

            Dim selectQuery As String = "select * from loan"
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


    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmmenu.Show()

    End Sub
    Sub vouncher()

        firstdate = CDate(dtp1.Text)
        seconddate = CDate(dtp2.Text)
        msg2 = DateDiff(DateInterval.Day, firstdate, seconddate)
        Myconnection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("Select  * from loan", Myconnection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgw.DataSource = view1
        dgw.Refresh()
        source1.Filter = "startdate >= '" & firstdate & "' and  startdate <= '" & seconddate & "'"
        dgw.Refresh()
        Myconnection.Close()
    End Sub



    Private Sub btnquery_Click(sender As System.Object, e As System.EventArgs) Handles btnquery.Click
        vouncher()

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        grid()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtsearch.Focus()
            End If
        End If
    End Sub

    Private Sub txtsearch_OnValueChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.OnValueChanged

    End Sub
End Class