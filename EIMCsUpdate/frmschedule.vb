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

    Dim x, y, z, p, n, g As String



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



    Sub loantype1()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "Long Term Cash Loan LTCL"
            da = New MySqlDataAdapter("Select  * from loan where loantype ='" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            x1.DataSource = view1
            x1.Refresh()


            For Line As Integer = 0 To x1.RowCount - 1
                x = x + x1.Rows(Line).Cells(4).Value * x1.Rows(Line).Cells(5).Value
            Next

            x1.Refresh()

            connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub loantype2()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "Long Term Material Sales LMTS"
            da = New MySqlDataAdapter("Select  * from loan where loantype ='" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            x2.DataSource = view1
            x2.Refresh()


            For Line As Integer = 0 To x2.RowCount - 1
                y = y + x2.Rows(Line).Cells(4).Value * x2.Rows(Line).Cells(5).Value
            Next

            x2.Refresh()

            connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Sub loantype3()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "Short Term Cash Loan STCL"
            da = New MySqlDataAdapter("Select  * from loan where loantype ='" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            x3.DataSource = view1
            x3.Refresh()


            For Line As Integer = 0 To x3.RowCount - 1
                p = p + x3.Rows(Line).Cells(4).Value * x3.Rows(Line).Cells(5).Value
            Next

            x3.Refresh()

            connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Sub loantype4()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "4 months Short Term Material Sales STMS "
            da = New MySqlDataAdapter("Select  * from loan where loantype ='" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            x4.DataSource = view1
            x4.Refresh()


            For Line As Integer = 0 To x4.RowCount - 1
                z = z + x4.Rows(Line).Cells(4).Value * x4.Rows(Line).Cells(5).Value
            Next

            x4.Refresh()

            connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Sub loantype5()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "12 months Short Term Material Sales STMS "
            da = New MySqlDataAdapter("Select  * from loan where loantype ='" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            x5.DataSource = view1
            x5.Refresh()


            For Line As Integer = 0 To x5.RowCount - 1
                n = n + x5.Rows(Line).Cells(4).Value * x5.Rows(Line).Cells(5).Value
            Next

            x5.Refresh()

            connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Sub loantype6()
        Try
            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "Emergency Loan"
            da = New MySqlDataAdapter("Select  * from loan where loantype ='" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            x6.DataSource = view1
            x6.Refresh()


            For Line As Integer = 0 To x6.RowCount - 1
                g = g + x6.Rows(Line).Cells(4).Value * x6.Rows(Line).Cells(5).Value
            Next

            x6.Refresh()

            connect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Sub plot()

        Chart2.Series("Monitor").Points.AddXY("LTCL", x)
        Chart2.Series("Monitor").Points.AddXY("LTMS", y)
        Chart2.Series("Monitor").Points.AddXY("STCL", p)
        Chart2.Series("Monitor").Points.AddXY("FOOD", z)
        Chart2.Series("Monitor").Points.AddXY("N-FOOD", n)
        Chart2.Series("Monitor").Points.AddXY("EMERGENCY.L", g)
    End Sub


    Private Sub btnquery_Click(sender As System.Object, e As System.EventArgs) Handles btnquery.Click
        loading()
        totalsaving()
        totalshares()
        totalmembers()
        loantype1()
        loantype2()
        loantype3()
        loantype4()
        loantype5()
        loantype6()
        plot()


    End Sub

    
    Sub deduct()
        Try
            Dim a, b, c, e, f As Long

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            m = "unpaid"

            da = New MySqlDataAdapter("Select  * from loan where status = '" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            g1.DataSource = view1
            g1.Refresh()


            For Line As Integer = 0 To g1.RowCount - 1
                f = g1.Rows(Line).Cells(4).Value * g1.Rows(Line).Cells(5).Value
                a = g1.Rows(Line).Cells(4).Value - 1
                b = g1.Rows(Line).Cells(5).Value
                c = b + g1.Rows(Line).Cells(10).Value
                e = g1.Rows(Line).Cells(0).Value

                connect.Close()
                connect.Open()
                Dim status As String
                Dim dates As String
                Dim sql As String
                dates = Now
                If c >= f Then
                    status = "paid"
                Else
                    status = "unpaid"
                End If


                sql = "UPDATE loan set amountpaid = '" & c & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "'," & " paymentduration = '" & a & "' where sno = " & e

                Dim cmdx As New MySqlCommand(sql, connect)


                cmdx.ExecuteNonQuery()

                connect.Close()

            Next


            g1.Refresh()

            connect.Close()
            MsgBox("Trasaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles gen.Click
        deduct()
    End Sub

    Private Sub ITalk_Button_23_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_23.Click
        Me.Hide()
        frmmenu.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ITalk_Button_22_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_22.Click
        Me.Hide()
        frmscheduling.Show()

    End Sub
End Class