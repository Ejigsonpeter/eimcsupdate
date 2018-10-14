﻿Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frmclearloan
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
    Dim use, x As String
    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select a search option", vbInformation)
        ElseIf txtsearch.Text = "" Then
            MsgBox("Please enter IPPS no to search", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then
            searchloan1()
       
        End If
    End Sub

    Sub totalshare()
        myconnection.Open()
        Dim selectQuery As String = "select * from shares where ippsno = '" & txtsearch.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, Myconnection)
        da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Dim a As Double
        For Line As Integer = 0 To DataGridView1.RowCount - 1
            a = (a + DataGridView1.Rows(Line).Cells(3).Value)


        Next
        txtshare.Text = a
        Myconnection.Close()
    End Sub
    Sub totalsavings()
        Myconnection.Open()
        Dim selectQuery As String = "select * from savings where ippsno = '" & txtsearch.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, Myconnection)
        da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Dim a As Double
        For Line As Integer = 0 To DataGridView1.RowCount - 1
            a = (a + DataGridView1.Rows(Line).Cells(3).Value)


        Next
        txtsavgs.Text = a
        Myconnection.Close()
    End Sub

    Sub emergency()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            typex = "Emergency Loan"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & typex & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String


                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString

                c = a * pay
                p = c - d

                x = "month(s) remaining"
                txtemer.Text = "Paid : " & d & " Balance: " & p & " :      O.M:" & pay
            Else
                txtemer.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub

    Sub loanstcl()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type2 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String


                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString

                c = a * pay
                p = c - d

                x = "month(s) remaining"
                txtstcl.Text = "Paid : " & d & " Balance: " & p & " :      O.M:" & pay
            Else
                txtstcl.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub


    Sub loanltcl()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type1 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String


                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString

                c = a * pay
                p = c - d

                x = "month(s) remaining"
                txtltcl.Text = "Paid : " & d & " Balance: " & p & " :      O.M:" & pay


                Myconnection.Close()

            Else
                txtltcl.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub loanltms()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type3 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String


                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString

                c = a * pay
                p = c - d

                x = "month(s) remaining"
                txtltms.Text = "Paid : " & d & " Balance: " & p & " :      O.M:" & pay

                Myconnection.Close()

            Else
                txtltms.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub

    Sub loanstms1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"


            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type4 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String


                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString

                c = a * pay
                p = c - d

                x = "month(s) remaining"
                txtstms.Text = "Paid : " & d & " Balance: " & p & " :      O.M:" & pay



            Else
                txtstms.Text = "0"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub loanstms11()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type5 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String


                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString

                c = a * pay
                p = c - d

                x = "month(s) remaining"
                stms1.Text = "Paid : " & d & " Balance: " & p & " :      O.M:" & pay


                Myconnection.Close()
            Else
                stms1.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub







 
    Sub searchloan1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim status As String
            status = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM members WHERE ippsno = '" & txtsearch.Text & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a As String
                MsgBox(count & " Matching Record found in Database  ", vbInformation)
                txtfname.Text = reader.Item("fullname").ToString
                txtipps.Text = reader.Item("ippsno").ToString
                txtd1.Text = reader.Item("applicantdate").ToString


                Dim imagepic As Byte() = CType(reader("passport"), Byte())
                Dim ms As New System.IO.MemoryStream(imagepic)
                Dim img As Image = Image.FromStream(ms)
                Me.loanpassport.Image = img
                'studPic.Image = image.FromFile("image.jpg")
                loanpassport.SizeMode = PictureBoxSizeMode.StretchImage
                loanpassport.Refresh()

                Dim imagepic1 As Byte() = CType(reader("signature"), Byte())
                Dim ms1 As New System.IO.MemoryStream(imagepic1)
                Dim img1 As Image = Image.FromStream(ms1)
                Me.loansign.Image = img1
                'studPic.Image = image.FromFile("image.jpg")
                loansign.SizeMode = PictureBoxSizeMode.StretchImage
                loansign.Refresh()

                Dim x As Date = Date.Today()
                txtd2.Text = x
                Dim firstdate = CDate(txtd1.Text)
                Dim seconddate = CDate(txtd2.Text)
                Dim msg2 As String = DateDiff(DateInterval.Month, firstdate, seconddate)
                txtmd.Text = msg2 & "  " & " month (s)"

                Myconnection.Close()

                totalshare()
                totalsavings()
                loanstcl()
                loanltms()
                loanltcl()
                loanstms1()
                loanstms11()
                emergency()

                loanltms()


            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
   

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmmenu.Show()

    End Sub

    Private Sub btnpay_Click(sender As System.Object, e As System.EventArgs) Handles btnpay.Click
        If txtipps.Text = "" Then
            MsgBox("Space cannot be empty ..please search and retrive users loan information first", vbInformation)
        ElseIf txtm.Text = "" Then
            MsgBox("please select a loan type to clear ", vbInformation)
        Else

            If txtm.SelectedIndex = 0 Then 'LTCL
               
                clearltcl()
            ElseIf txtm.SelectedIndex = 1 Then 'STCL
                clearstcl()
            ElseIf txtm.SelectedIndex = 2 Then 'LMTS
                clearltms()
            ElseIf txtm.SelectedIndex = 3 Then 'STML i
                clearstms1()
            ElseIf txtm.SelectedIndex = 4 Then 'STML ii
                clearstms2()
            ElseIf txtm.SelectedIndex = 5 Then ' emergencyloan
                clearemergency()
            ElseIf txtm.SelectedIndex = 6 Then ' saving

            ElseIf txtm.SelectedIndex = 7 Then 'emergency savings



            End If

        End If
    End Sub


    Sub clearltms()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type3 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String

                Dim amount, balance, m, i, dates As String




                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString
                amount = txtamount.Text


                c = a * pay
                p = c - d
                ' this will calculate how many months the price can cover .
                m = (amount / a)

                balance = c - amount
                i = m - a
                Myconnection.Close()
                Try
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim status As String
                    If amount = c Then
                        status = "paid"
                    Else
                        status = "unpaid"
                    End If
                    Dim sql As String
                    dates = Now


                    sql = "UPDATE loan set amountpaid = '" & txtamount.Text & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "' where ippsno = " & txtipps.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Trasaction Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                    logs()
                    totalshare()
                    totalsavings()
                    loanstcl()
                    loanltms()
                    loanltcl()
                    loanstms1()
                    loanstms11()
                    emergency()

                    loanltms()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MsgBox("No user Inoformation", vbInformation)
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub

    Sub logs()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = TextBox1.Text & "cleared Loan  " & txtm.SelectedValue & "for" & txtfname.Text


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", TextBox1.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()

            Myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub
    Sub clearltcl()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type1 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String

                Dim amount, balance, m, i, dates As String




                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString
                amount = txtamount.Text


                c = a * pay
                p = c - d
                ' this will calculate how many months the price can cover .
                m = (amount / a)

                balance = c - amount
                i = m - a
                Myconnection.Close()
                Try
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim status As String
                    If amount = c Then
                        status = "paid"
                    Else
                        status = "unpaid"
                    End If
                    Dim sql As String
                    dates = Now


                    sql = "UPDATE loan set amountpaid = '" & txtamount.Text & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "' where ippsno = " & txtipps.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Trasaction Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                    logs()
                    totalshare()
                    totalsavings()
                    loanstcl()
                    loanltms()
                    loanltcl()
                    loanstms1()
                    loanstms11()
                    emergency()

                    loanltms()

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MsgBox("No user Inoformation", vbInformation)
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub clearstcl()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type2 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String

                Dim amount, balance, m, i, dates As String




                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString
                amount = txtamount.Text


                c = a * pay
                p = c - d
                ' this will calculate how many months the price can cover .
                m = (amount / a)

                balance = c - amount
                i = m - a
                Myconnection.Close()
                Try
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim status As String
                    If amount = c Then
                        status = "paid"
                    Else
                        status = "unpaid"
                    End If
                    Dim sql As String
                    dates = Now


                    sql = "UPDATE loan set amountpaid = '" & txtamount.Text & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "' where ippsno = " & txtipps.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Trasaction Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                    logs()
                    totalshare()
                    totalsavings()
                    loanstcl()
                    loanltms()
                    loanltcl()
                    loanstms1()
                    loanstms11()
                    emergency()

                    loanltms()

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MsgBox("No user Inoformation", vbInformation)
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub clearstms1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type4 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String

                Dim amount, balance, m, i, dates As String




                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString
                amount = txtamount.Text


                c = a * pay
                p = c - d
                ' this will calculate how many months the price can cover .
                m = (amount / a)

                balance = c - amount
                i = m - a
                Myconnection.Close()
                Try
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim status As String
                    If amount = c Then
                        status = "paid"
                    Else
                        status = "unpaid"
                    End If
                    Dim sql As String
                    dates = Now


                    sql = "UPDATE loan set amountpaid = '" & txtamount.Text & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "' where ippsno = " & txtipps.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Trasaction Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                    logs()
                    totalshare()
                    totalsavings()
                    loanstcl()
                    loanltms()
                    loanltcl()
                    loanstms1()
                    loanstms11()
                    emergency()

                    loanltms()

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MsgBox("No user Inoformation", vbInformation)
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub clearstms2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type5 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String

                Dim amount, balance, m, i, dates As String




                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString
                amount = txtamount.Text


                c = a * pay
                p = c - d
                ' this will calculate how many months the price can cover .
                m = (amount / a)

                balance = c - amount
                i = m - a
                Myconnection.Close()
                Try
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim status As String
                    If amount = c Then
                        status = "paid"
                    Else
                        status = "unpaid"
                    End If
                    Dim sql As String
                    dates = Now


                    sql = "UPDATE loan set amountpaid = '" & txtamount.Text & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "' where ippsno = " & txtipps.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Trasaction Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                    logs()
                    totalshare()
                    totalsavings()
                    loanstcl()
                    loanltms()
                    loanltcl()
                    loanstms1()
                    loanstms11()
                    emergency()

                    loanltms()

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MsgBox("No user Inoformation", vbInformation)
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub

    Sub clearemergency()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, type6 As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"
            type6 = "Emergency Loan"


            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type1 & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d As String

                Dim pay As String
                Dim x As String

                Dim amount, balance, m, i, dates As String




                pay = reader.Item("paymentduration").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString
                amount = txtamount.Text


                c = a * pay
                p = c - d
                ' this will calculate how many months the price can cover .
                m = (amount / a)

                balance = c - amount
                i = m - a
                Myconnection.Close()
                Try
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim status As String
                    If amount = c Then
                        status = "paid"
                    Else
                        status = "unpaid"
                    End If
                    Dim sql As String
                    dates = Now


                    sql = "UPDATE loan set amountpaid = '" & txtamount.Text & "'," & " datepaid = '" & dates & "'," & " status = '" & status & "' where ippsno = " & txtipps.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Trasaction Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                    logs()
                    totalshare()
                    totalsavings()
                    loanstcl()
                    loanltms()
                    loanltcl()
                    loanstms1()
                    loanstms11()
                    emergency()

                    loanltms()

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MsgBox("No user Inoformation", vbInformation)
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
End Class