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
    Dim type1, type2, type3, type4, type5, type6 As String
    Dim sh, sv As String

    Dim x, y, z, p, n, g As Double



    Sub grid()
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Sub loading()
        Try
            'Chart2.Series.Clear()
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

                'liability
                a = dgw.Rows(Line).Cells(6).Value * dgw.Rows(Line).Cells(7).Value
                b = a * ((dgw.Rows(Line).Cells(9).Value) / (100))
                c = a - b

                x = x + c


                'total amountpaid
                y = y + (dgw.Rows(Line).Cells(12).Value - (dgw.Rows(Line).Cells(12).Value * dgw.Rows(Line).Cells(9).Value / 100))
            Next
            Dim F, G As Double

            'liability

            F = x
            txtliability.Text = x
            'Profit
            G = (10 / 100) * y
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
            da = New MySqlDataAdapter("Select  * from shares", connect)
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
                x = x + x1.Rows(Line).Cells(7).Value * x1.Rows(Line).Cells(6).Value
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
                y = y + x2.Rows(Line).Cells(7).Value * x2.Rows(Line).Cells(6).Value
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
                p = p + x3.Rows(Line).Cells(7).Value * x3.Rows(Line).Cells(6).Value
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
                z = z + x4.Rows(Line).Cells(7).Value * x4.Rows(Line).Cells(6).Value
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
                n = n + x5.Rows(Line).Cells(7).Value * x5.Rows(Line).Cells(6).Value
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
                g = g + x6.Rows(Line).Cells(6).Value * x6.Rows(Line).Cells(7).Value
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


    Sub display()
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


    Private Sub btnquery_Click(sender As System.Object, e As System.EventArgs) Handles btnquery.Click
        Me.Hide()

        Me.Show()

        totalsaving()
        totalshares()
        totalmembers()
        loantype1()
        loantype2()
        loantype3()
        loantype4()
        loantype5()
        loantype6()
        grid()
    End Sub
   

    Sub deduct()
        Try
            Dim a, b, c, e, f As Long

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            type6 = "Emergency Loan"

            Dim id, ip As Integer

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m, ty As String

            m = "unpaid"

            da = New MySqlDataAdapter("Select  * from loan where status = '" & m & "'", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            g1.DataSource = view1
            g1.Refresh()


            For Line As Integer = 0 To g1.RowCount - 1
                f = (g1.Rows(Line).Cells(8).Value * (g1.Rows(Line).Cells(9).Value / 100)) + g1.Rows(Line).Cells(8).Value
                a = g1.Rows(Line).Cells(6).Value - 1
                b = g1.Rows(Line).Cells(7).Value
                c = b + g1.Rows(Line).Cells(12).Value
                e = g1.Rows(Line).Cells(0).Value
                ty = g1.Rows(Line).Cells(5).Value
                id = g1.Rows(Line).Cells(2).Value



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




                If ty = type1 Then
                    connect.Close()
                    connect.Open()
                    dates = Now
                    sql = "UPDATE schedule set LTCL = '" & b & "'," & " REMARK  = '" & dates & "' where IPPS_NO = " & id

                    Dim cmdxx As New MySqlCommand(sql, connect)
                    cmdxx.ExecuteNonQuery()
                    connect.Close()
                ElseIf ty = type2 Then
                    connect.Close()
                    connect.Open()
                    dates = Now
                    sql = "UPDATE schedule set STCL = '" & b & "' ," & " REMARK  = '" & dates & "' where IPPS_NO = " & id

                    Dim cmdxx As New MySqlCommand(sql, connect)
                    cmdxx.ExecuteNonQuery()
                    connect.Close()
                ElseIf ty = type3 Then
                    connect.Close()
                    connect.Open()
                    dates = Now
                    sql = "UPDATE schedule set LTMS = '" & b & "' ," & " REMARK  = '" & dates & "'  where IPPS_NO = " & id
                    Dim cmdxx As New MySqlCommand(sql, connect)
                    cmdxx.ExecuteNonQuery()
                    connect.Close()
                ElseIf ty = type4 Then
                    connect.Close()
                    connect.Open()
                    dates = Now
                    sql = "UPDATE schedule set FOOD_ITEMS = '" & b & "' ," & " REMARK  = '" & dates & "' where IPPS_NO = " & id
                    Dim cmdxx As New MySqlCommand(sql, connect)
                    cmdxx.ExecuteNonQuery()
                    connect.Close()
                ElseIf ty = type5 Then
                    connect.Close()
                    connect.Open()
                    dates = Now
                    sql = "UPDATE schedule set NON_FOOD_ITEMS = '" & b & "' ," & " REMARK  = '" & dates & "' where IPPS_NO = " & id
                    Dim cmdxx As New MySqlCommand(sql, connect)
                    cmdxx.ExecuteNonQuery()
                    connect.Close()
                ElseIf ty = type6 Then
                    connect.Close()
                    connect.Open()

                    dates = Now
                    sql = "UPDATE schedule set EMERGENCY = '" & b & "' ," & " REMARK = '" & dates & "' where IPPS_NO = " & id
                    Dim cmdxx As New MySqlCommand(sql, connect)
                    cmdxx.ExecuteNonQuery()
                    connect.Close()

                End If




            Next


            g1.Refresh()

            connect.Close()
            MsgBox("Transaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    'calculate total
    Sub total()
        Try
            Dim l1, l2, l3, l4, l5, l6, tc, total As Long



            Dim id As Integer

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String



            da = New MySqlDataAdapter("Select  * from schedule ", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            gx.DataSource = view1
            gx.Refresh()

            For Line As Integer = 0 To gx.RowCount - 1
                l1 = gx.Rows(Line).Cells(8).Value
                l2 = gx.Rows(Line).Cells(9).Value
                l3 = gx.Rows(Line).Cells(10).Value
                l4 = gx.Rows(Line).Cells(11).Value
                l5 = gx.Rows(Line).Cells(12).Value
                l6 = gx.Rows(Line).Cells(13).Value
                tc = gx.Rows(Line).Cells(14).Value
                id = gx.Rows(Line).Cells(1).Value


                total = l1 + l2 + l3 + l4 + l5 + l6 + tc

                connect.Close()
                connect.Open()
                Dim status As String
                Dim dates As String
                Dim sql As String


                'MsgBox(total)

                sql = "UPDATE schedule set TOTAL = '" & total & "' where IPPS_NO = " & id

                Dim cmdx As New MySqlCommand(sql, connect)


                cmdx.ExecuteNonQuery()

                connect.Close()

            Next
            gx.Refresh()

            connect.Close()
            ' MsgBox("Transaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    'update shares 
    Sub shares()
        Try
            Dim total, l1 As Long

            Dim id As Integer

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As Long

            da = New MySqlDataAdapter("Select  * from shares", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            dg2.DataSource = view1
            dg2.Refresh()

            For Line As Integer = 0 To dg2.RowCount - 1
                l1 = dg2.Rows(Line).Cells(3).Value
                id = dg2.Rows(Line).Cells(2).Value


                connect.Close()
                connect.Open()
                Dim reader As MySqlDataReader
                Dim command As MySqlCommand = New MySqlCommand
                command.Connection = connect


                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM members WHERE ippsno = '" & id & "'"

                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then
                    ' MsgBox(count & " Matching Record found in Database  ", vbInformation)
                    m = reader.Item("shares").ToString
                    connect.Close()
                    connect.Open()
                    Dim sql As String

                    total = m + l1

                    ' MsgBox(total)

                    sql = "UPDATE shares set shareamount = '" & total & "' where ippsno = " & id

                    Dim cmdx As New MySqlCommand(sql, connect)


                    cmdx.ExecuteNonQuery()

                    connect.Close()
                End If


            Next
            dg2.Refresh()

            connect.Close()
            MsgBox("Transaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    'update savings


    Sub savings()
        Try
            Dim total, l1 As Long

            Dim id As Integer

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As Long

            da = New MySqlDataAdapter("Select  * from savings", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            dg1.DataSource = view1
            dg1.Refresh()

            For Line As Integer = 0 To dg1.RowCount - 1
                l1 = dg1.Rows(Line).Cells(3).Value
                id = dg1.Rows(Line).Cells(2).Value


                connect.Close()
                connect.Open()
                Dim reader As MySqlDataReader
                Dim command As MySqlCommand = New MySqlCommand
                command.Connection = connect


                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM members WHERE ippsno = '" & id & "'"

                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then
                    ' MsgBox(count & " Matching Record found in Database  ", vbInformation)
                    m = reader.Item("savings").ToString
                    connect.Close()
                    connect.Open()
                    Dim sql As String

                    total = m + l1

                    ' MsgBox(total)

                    sql = "UPDATE savings set amount = '" & total & "' where ippsno = " & id

                    Dim cmdx As New MySqlCommand(sql, connect)


                    cmdx.ExecuteNonQuery()

                    connect.Close()
                End If


            Next
            dg1.Refresh()

            connect.Close()
            MsgBox("Transaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub


    'admin savings

    Sub admin()
        Try
            Dim total, l1 As Long

            Dim id As Integer

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As Long

            da = New MySqlDataAdapter("Select  * from admincharges", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            a1.DataSource = view1
            a1.Refresh()

            For Line As Integer = 0 To a1.RowCount - 1
                l1 = a1.Rows(Line).Cells(3).Value
                id = a1.Rows(Line).Cells(2).Value


                connect.Close()
                connect.Open()
                Dim reader As MySqlDataReader
                Dim command As MySqlCommand = New MySqlCommand
                command.Connection = connect


                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM members WHERE ippsno = '" & id & "'"

                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then
                    ' MsgBox(count & " Matching Record found in Database  ", vbInformation)
                    m = reader.Item("admin").ToString
                    connect.Close()
                    connect.Open()
                    Dim sql As String

                    total = m + l1

                    ' MsgBox(total)

                    sql = "UPDATE admincharges set amount = '" & total & "' where ippsno = " & id

                    Dim cmdx As New MySqlCommand(sql, connect)


                    cmdx.ExecuteNonQuery()

                    connect.Close()
                End If


            Next
            a1.Refresh()

            connect.Close()
            MsgBox("Transaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub
    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles gen.Click
        reset()
        deduct()
        total()
        shares()
        savings()
        admin()
        grid()
        logs()
    End Sub
    Sub logs()
        Try
            connect.Close()
            connect.Open()
            Dim at, task As String
            at = Now
            task = "Generated Schedule "


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, connect)
            cmdx.Parameters.AddWithValue("@fullname", Label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub


    Private Sub ITalk_Button_23_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_23.Click
        Me.Hide()
        frmmenu.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ITalk_Button_22_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_22.Click
        frmscheduling.Label2.Text = Me.Label2.Text
        Me.Hide()
        frmscheduling.Show()

    End Sub

    Private Sub frmschedule_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'loading()
        'plot()
        display()
        grid()


    End Sub

    'Reset Values
    Sub reset()
        Try
            Dim l1, l2, l3, l4, l5, l6, tc, total As Long



            Dim id As Integer

            Dim ds As DataSet = New DataSet
            Dim da As MySqlDataAdapter
            Dim tables As DataTableCollection = ds.Tables
            Dim source1 As New BindingSource()
            Dim m As String
            Dim dates As String
            dates = Now



            da = New MySqlDataAdapter("Select  * from schedule ", connect)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            source1.DataSource = view1
            gx.DataSource = view1
            gx.Refresh()

            For Line As Integer = 0 To gx.RowCount - 1
                l1 = 0
                l2 = 0
                l3 = 0
                l4 = 0
                l5 = 0
                l6 = 0

                tc = gx.Rows(Line).Cells(14).Value
                id = gx.Rows(Line).Cells(1).Value


                total = l1 + l2 + l3 + l4 + l5 + l6 + tc

                connect.Close()
                connect.Open()
               
                Dim sql As String


                'MsgBox(total)

                sql = "UPDATE schedule set TOTAL = '" & total & "'," & "LTCL = '" & l1 & "'," & " STCL = '" & l2 & "'," & " LTMS = '" & l3 & "'," & " FOOD_ITEMS = '" & l4 & "' ," & " NON_FOOD_ITEMS = '" & l5 & "' ," & " EMERGENCY = '" & l6 & "'," & " REMARK = '" & dates & "' where IPPS_NO = " & id

                Dim cmdx As New MySqlCommand(sql, connect)


                cmdx.ExecuteNonQuery()

                connect.Close()

            Next
            gx.Refresh()

            connect.Close()
            MsgBox("Transaction Successfull ", vbInformation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
End Class