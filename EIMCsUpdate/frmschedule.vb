Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions



Public Class frmschedule
    Dim connect As New MySqlConnection With {.ConnectionString = "server = localhost ;userid = root; password =; database = eimcs;"}
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Dim cmd As MySqlCommand
    Dim sql As String



    Sub loading()


        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            da = New MySqlDataAdapter("Select  * from loan", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            dgw.DataSource = view1
            dgw.Refresh()

            Dim a, b, c, d, t, h, i, j, x, y As Double
            For Line As Integer = 0 To dgw.RowCount - 1
                '10.....
                'total liability
                a = a + dgw.Rows(Line).Cells(6).Value
                'total debt
                x = x + dgw.Rows(Line).Cells(4).Value * dgw.Rows(Line).Cells(5).Value
                'total amountpaid
                y = y + dgw.Rows(Line).Cells(10).Value
            Next
            Dim F, G As String
            'liability

            F = a
            txtliability.Text = F - y
            'Profit

            G = x - a
            txtprofit.Text = G
            

            Chart1.Series("Monitor").Points.AddXY("Liability", F)
            Chart1.Series("Monitor").Points.AddXY("Profit", G)
            


            dgw.Refresh()

            connect.Close()

            '  connect.Open()
            'Dim query As String
            'query = "select * from gas"
            'cmd = New MySqlCommand(query, connect)
            'dr = cmd.ExecuteReader
            'While dr.Read

            '    End While
            '    connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub totalsaving()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            da = New MySqlDataAdapter("Select  * from savings", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            dg1.DataSource = view1
            dg1.Refresh()
            Dim a As Double
            For Line As Integer = 0 To dg1.RowCount - 1
                'total savings
                a = a + dg1.Rows(Line).Cells(3).Value

            Next
            txtsavings.Text = a
            dg1.Refresh()

            connect.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub totalshares()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            da = New MySqlDataAdapter("Select  * from savings", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            dg2.DataSource = view1
            dg2.Refresh()
            Dim a As Double
            For Line As Integer = 0 To dg2.RowCount - 1
                'total savings
                a = a + dg2.Rows(Line).Cells(3).Value

            Next
            txtshares.Text = a
            dg1.Refresh()

            connect.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub totalmembers()
        Try
            connect.Open()

          



            Dim sql As String = "select COUNT(*) FROM members"
            Dim cmde As New MySqlCommand(sql, connect)
            dr = cmde.ExecuteReader()
            While (dr.Read())
                txtmembers.Text = (dr(0).ToString())
            End While
            connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Private Sub btnquery_Click(sender As System.Object, e As System.EventArgs) Handles btnquery.Click
        loading()
        totalsaving()
        totalshares()
        totalmembers()

    End Sub
End Class