Imports System.IO
Imports MySql.Data.MySqlClient



Public Class Loan
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
    Dim paid As String
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand = New MySqlCommand
    Dim s, type1, type2, type3 As String
    Dim count As Integer
    Dim counter As Integer

    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    Dim use, x As String

    Sub clearloan()
        txtm.Text = ""
        txtamountneeded.Text = ""
        txtamountpayable.Text = ""
        txtmonth.Text = ""
        txtinterestRate.Text = ""
        DateTimePicker3.Text = ""
        DateTimePicker4.Text = ""
        txtmonth.Text = ""
        txtfname.Text = ""
        txtipps.Text = ""
        txtmd.Text = ""
        txtshare.Text = ""
        txtsavgs.Text = ""
        txtltcl.Text = ""
        txtltms.Text = ""
        txtstcl.Text = ""
        txtstms.Text = ""
        stms1.Text = ""
        txteno.Text = ""
        txtfno.Text = ""
        txtemer.Text = ""
        loanpassport.Image = BackgroundImage
        loansign.Image = BackgroundImage

    End Sub
    Sub validateloan()
        If txtfname.Text = "" Then
            MsgBox("Please perform a search query first to retrive Fullname", vbInformation)
        ElseIf txtipps.Text = "" Then
            MsgBox("Please perform a search query first to retrive IPPS NO", vbInformation)
        ElseIf txtm.Text = "" Then
            MsgBox("Please select a loan type", vbInformation)
            txtm.Focus()
        ElseIf txtamountneeded.Text = "" Then
            MsgBox("Please Enter amount needed", vbInformation)
            txtamountneeded.Focus()
        Else
            validateloan2()


        End If
    End Sub

    Sub validateloan2()
        Try

            If txtm.SelectedIndex = 0 Then 'LTCL
                Myconnection.Close()
                Myconnection.Open()

                command.Connection = Myconnection

                s = "unpaid"

                type1 = "Long Term Cash Loan LTCL"
                type2 = "Short Term Cash Loan STCL"
                type3 = "Long Term Material Sales LMTS"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and loantype = '" & type1 & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count <> 0 Then

                    ' MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    MsgBox(count & " MATCHING RECORDS FOUND IN DATABASE. YOU HAVE TO CLEAR YOUR OUSTANDING " & type1 & " BEFORE REQUESTING FOR ANOTHER", vbInformation)

                Else
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim reader As MySqlDataReader
                    Dim command As MySqlCommand = New MySqlCommand
                    command.Connection = Myconnection
                    Dim s, type1, type2, type3 As String

                    s = "unpaid"

                    type1 = "Long Term Cash Loan LTCL"
                    type2 = "Short Term Cash Loan STCL"
                    type3 = "Long Term Material Sales LMTS"
                    '----retrieve student's particulars
                    command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and   loantype = '" & type2 & "' or loantype = '" & type3 & "'  and ippsno  = '" & txtipps.Text & "' and status = '" & s & "'"
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection)

                    count = 0
                    While reader.Read
                        count = count + 1
                    End While
                    If count <> 0 Then

                        MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    Else
                        If ((txtamountneeded.Text) <= (txtsavgs.Text * 2)) Then
                            MsgBox("You are eligible for this loan", vbInformation)
                            insertloan()
                        Else
                            MsgBox("You are not eligible for this loan. your twice your savings is less than the amount needed", vbInformation)
                        End If

                    End If


                End If
                '---reset the timer to another five seconds---
                'Timer1.Enabled = False
                'Timer1.Enabled = True
                Myconnection.Close()

            ElseIf txtm.SelectedIndex = 1 Then 'STCL
                Myconnection.Close()
                Myconnection.Open()

                command.Connection = Myconnection

                s = "unpaid"

                type1 = "Long Term Cash Loan LTCL"
                type2 = "Short Term Cash Loan STCL"
                type3 = "Long Term Material Sales LMTS"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and loantype = '" & type2 & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count <> 0 Then

                    ' MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    MsgBox(count & " MATCHING RECORDS FOUND IN DATABASE. YOU HAVE TO CLEAR YOUR OUSTANDING " & type2 & " BEFORE REQUESTING FOR ANOTHER", vbInformation)

                Else
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim reader As MySqlDataReader
                    Dim command As MySqlCommand = New MySqlCommand
                    command.Connection = Myconnection
                    Dim s, type1, type2, type3 As String

                    s = "unpaid"

                    type1 = "Long Term Cash Loan LTCL"
                    type2 = "Short Term Cash Loan STCL"
                    type3 = "Long Term Material Sales LMTS"
                    '----retrieve student's particulars
                    command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and   loantype = '" & type1 & "' or loantype = '" & type3 & "'  and ippsno  = '" & txtipps.Text & "' and status = '" & s & "'"
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection)

                    count = 0
                    While reader.Read
                        count = count + 1
                    End While
                    If count <> 0 Then

                        MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    Else
                        insertloan()
                    End If


                End If
                '---reset the timer to another five seconds---
                'Timer1.Enabled = False
                'Timer1.Enabled = True
                Myconnection.Close()


            ElseIf txtm.SelectedIndex = 2 Then 'LMTS
                Myconnection.Close()
                Myconnection.Open()

                command.Connection = Myconnection

                s = "unpaid"

                type1 = "Long Term Cash Loan LTCL"
                type2 = "Short Term Cash Loan STCL"
                type3 = "Long Term Material Sales LMTS"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and loantype = '" & type3 & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count <> 0 Then

                    ' MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    MsgBox(count & " MATCHING RECORDS FOUND IN DATABASE. YOU HAVE TO CLEAR YOUR OUSTANDING " & type3 & " BEFORE REQUESTING FOR ANOTHER", vbInformation)

                Else
                    Myconnection.Close()
                    Myconnection.Open()
                    Dim reader As MySqlDataReader
                    Dim command As MySqlCommand = New MySqlCommand
                    command.Connection = Myconnection
                    Dim s, type1, type2, type3 As String

                    s = "unpaid"

                    type1 = "Long Term Cash Loan LTCL"
                    type2 = "Short Term Cash Loan STCL"
                    type3 = "Long Term Material Sales LMTS"
                    '----retrieve student's particulars
                    command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and   loantype = '" & type1 & "' or loantype = '" & type2 & "'  and ippsno  = '" & txtipps.Text & "' and status = '" & s & "'"
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection)

                    count = 0
                    While reader.Read
                        count = count + 1
                    End While
                    If count <> 0 Then

                        MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    Else
                        If (((txtamountneeded.Text) <= (txtsavgs.Text * 3)) And ((txtamountneeded.Text) <= (txtshare.Text * 3))) Then
                            MsgBox("You are eligible for this loan", vbInformation)
                            insertloan()
                        Else
                            MsgBox("You are not eligible for this loan. your twice your savings is less than the amount needed", vbInformation)
                        End If
                    End If


                End If
                Myconnection.Close()
            ElseIf txtm.SelectedIndex = 3 Then
                'food
                Myconnection.Close()
                Myconnection.Open()

                command.Connection = Myconnection

                s = "unpaid"

                type1 = "Food Items"
                type2 = "Non Food Items"
                type3 = "Emergency Loan"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and loantype = '" & type1 & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count <> 0 Then

                    ' MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    MsgBox(count & " MATCHING RECORDS FOUND IN DATABASE. YOU HAVE TO CLEAR YOUR OUSTANDING " & type1 & " BEFORE REQUESTING FOR ANOTHER", vbInformation)

                Else
                    Myconnection.Close()
                    insertloan()
                End If

                Myconnection.Close()
            ElseIf txtm.SelectedIndex = 4 Then
                'Non food
                Myconnection.Close()
                Myconnection.Open()

                command.Connection = Myconnection

                s = "unpaid"

                type1 = "Food Items"
                type2 = "Non Food Items"
                type3 = "Emergency Loan"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and loantype = '" & type2 & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count <> 0 Then

                    ' MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    MsgBox(count & " MATCHING RECORDS FOUND IN DATABASE. YOU HAVE TO CLEAR YOUR OUSTANDING " & type2 & " BEFORE REQUESTING FOR ANOTHER", vbInformation)

                Else
                    Myconnection.Close()
                    insertloan()
                End If

                Myconnection.Close()
            ElseIf txtm.SelectedIndex = 5 Then
                'emergency
                'food
                Myconnection.Close()
                Myconnection.Open()

                command.Connection = Myconnection

                s = "unpaid"

                type1 = "Food Items"
                type2 = "Non Food Items"
                type3 = "Emergency Loan"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and status = '" & s & "' and loantype = '" & type3 & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count <> 0 Then

                    ' MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)
                    MsgBox(count & " MATCHING RECORDS FOUND IN DATABASE. YOU HAVE TO CLEAR YOUR OUSTANDING " & type3 & " BEFORE REQUESTING FOR ANOTHER", vbInformation)

                Else
                    Myconnection.Close()
                    insertloan()
                End If

                Myconnection.Close()

            ElseIf txtm.SelectedIndex = 6 Then
                MsgBox("Use Trasaction Correction Area to carry out this Operation", vbInformation)
            ElseIf txtm.SelectedIndex = 7 Then
                MsgBox("Use Trasaction Correction Area to carry out this Operation", vbInformation)
            Else
                MsgBox("Select Loan Category", vbInformation)



            End If



        Catch ex As Exception

        End Try

    End Sub

    Sub insertloan()
        'Try
        Myconnection.Close()
        Myconnection.Open()


        Dim sql As String
        sql = "insert into loan (fullname,ippsno,loantype,paymentduration,amountpayble,amountneeded,profit,startdate,enddate,status,eimcsno,fileno,treasurername)" _
            & "VALUES(@fullname,@ippsno,@loantype,@paymentduration,@amountpayable,@amountneeded,@interestrate,@startdate,@enddate,@status,@eimcsno,@fileno,@tresname)"

        Dim cmdx As New MySqlCommand(sql, Myconnection)
        cmdx.Parameters.AddWithValue("@fullname", txtfname.Text)
        cmdx.Parameters.AddWithValue("@ippsno", txtipps.Text)
        cmdx.Parameters.AddWithValue("@loantype", txtm.Text)
        cmdx.Parameters.AddWithValue("@paymentduration", txtmonth.Text)
        cmdx.Parameters.AddWithValue("@amountpayable", txtamountpayable.Text)
        cmdx.Parameters.AddWithValue("@amountneeded", txtamountneeded.Text)
        cmdx.Parameters.AddWithValue("@eimcsno", txteno.Text)
        cmdx.Parameters.AddWithValue("@fileno", txtfno.Text)
        cmdx.Parameters.AddWithValue("@interestrate", txtinterestRate.Text)
        cmdx.Parameters.AddWithValue("@startdate", DateTimePicker3.Text)
        cmdx.Parameters.AddWithValue("@enddate", DateTimePicker4.Text)
        cmdx.Parameters.AddWithValue("@status", "unpaid")
        cmdx.Parameters.AddWithValue("@tresname", TextBox1.Text)



        cmdx.ExecuteNonQuery()
        MsgBox("Information Saved Successfully ", vbInformation)
        Myconnection.Close()
        logs()

        clearloan()

        ' Catch ex As Exception
        ' MsgBox(ex.Message)

        ' End Try
    End Sub


    Private Sub btnclear_Click(sender As System.Object, e As System.EventArgs) Handles btnclear.Click
        clearloan()

    End Sub

    Private Sub btnsubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnsubmit.Click
        validateloan()

    End Sub
    Sub logs()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = TextBox1.Text & "Granted a Loan of Type : " & txtm.SelectedValue & " to " & txtfname.Text


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", TextBox1.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub







    Sub totalshare()
        myconnection.Open()
        Dim selectQuery As String = "select * from shares where ippsno = '" & txtipps.Text & "'"
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
        Dim selectQuery As String = "select * from savings where ippsno = '" & txtipps.Text & "'"
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

            s = "unpaid"
            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            typex = "Emergency Loan"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtipps.Text & "' and loantype = '" & typex & "' and status ='" & s & "'"

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


                x = "month(s) remaining"
                txtemer.Text = "Paid : " & d & " Balance: " & c & " :      O.M:" & pay
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
            s = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtipps.Text & "' and loantype = '" & type2 & "' and status ='" & s & "'"

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


                x = "month(s) remaining"
                txtstcl.Text = "Paid : " & d & " Balance: " & c & " :      O.M:" & pay
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
            s = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtipps.Text & "' and loantype = '" & type1 & "' and status ='" & s & "'"

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


                x = "month(s) remaining"
                txtltcl.Text = "Paid : " & d & " Balance: " & c & " :      O.M:" & pay


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
            s = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            s = "unpaid"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtipps.Text & "' and loantype = '" & type3 & "' and status = '" & s & "'"

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


                x = "month(s) remaining"
                txtltms.Text = "Paid : " & d & " Balance: " & c & " :      O.M:" & pay

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
            s = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"


            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtipps.Text & "' and loantype = '" & type4 & "' and status ='" & s & "'"

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


                x = "month(s) remaining"
                txtstms.Text = "Paid : " & d & " Balance: " & c & " :      O.M:" & pay



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
            s = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtipps.Text & "' and loantype = '" & type5 & "' and status ='" & s & "'"

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


                x = "month(s) remaining"
                stms1.Text = "Paid : " & d & "  Balance : " & c & " :  O.M : " & pay


                Myconnection.Close()
            Else
                stms1.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub






    Sub searchloan()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM members WHERE fileno = '" & txtsearch.Text & "' and approvalstatus = '" & "active" & "'"

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
                txtfno.Text = reader.Item("fileno").ToString
                txteno.Text = reader.Item("eimcsno").ToString

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
                totalsp()




            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True
            Myconnection.Close()
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

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM members WHERE ippsno = '" & txtsearch.Text & "' and approvalstatus = '" & "active" & "'"

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
                txtfno.Text = reader.Item("fileno").ToString
                txteno.Text = reader.Item("eimcsno").ToString

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

                totalsp()

            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True
            Myconnection.Close()


        Catch ex As Exception

        End Try
    End Sub

    Sub totalsp()

        Myconnection.Open()
        Dim selectQuery As String = "select * from special where ippsno = '" & txtsearch.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, Myconnection)
        da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)
        Dim b As Double
        For Line As Integer = 0 To DataGridView2.RowCount - 1
            b = (b + DataGridView2.Rows(Line).Cells(3).Value)


        Next
        txtsp.Text = b
        Myconnection.Close()

    End Sub
    Sub searchloan2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection

            '----retrieve student's particularseimcs
            command.CommandText = "SELECT * FROM members WHERE eimcsno = '" & txtsearch.Text & "' and approvalstatus = '" & "active" & "'"

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
                txtfno.Text = reader.Item("fileno").ToString
                txteno.Text = reader.Item("eimcsno").ToString

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
                totalsp()
                emergency()


            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True
            Myconnection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_21.Click
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub txtamountneeded_OnValueChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnsearch_Click_1(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select a search option", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then
            searchloan()
        ElseIf txtoption.selectedIndex = 2 Then
            searchloan1()
        ElseIf txtoption.selectedIndex = 3 Then
            searchloan2()

        End If

    End Sub

    Private Sub txtm_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles txtm.SelectedIndexChanged
        If txtm.SelectedIndex = 0 Then 'LTCL
            txtmonth.Text = "24"
            txtinterestRate.Text = "0"
            txtinterestRate.Enabled = False

        ElseIf txtm.SelectedIndex = 1 Then 'STCL
            txtmonth.Text = "6"
            txtinterestRate.Text = "0"
            txtinterestRate.Enabled = False
        ElseIf txtm.SelectedIndex = 2 Then 'LMTS
            txtmonth.Text = "36"
            txtinterestRate.Text = "10"
            txtinterestRate.Enabled = True
        ElseIf txtm.SelectedIndex = 3 Then 'STML i
            txtmonth.Text = "4"
            txtinterestRate.Text = "5"
            txtinterestRate.Enabled = True
        ElseIf txtm.SelectedIndex = 4 Then 'STML ii
            txtmonth.Text = "12"
            txtinterestRate.Text = "10"
            txtinterestRate.Enabled = True
        ElseIf txtm.SelectedIndex = 5 Then ' emergencyloan
            txtmonth.Text = "4"
            txtinterestRate.Text = "0"
            txtinterestRate.Enabled = False
        ElseIf txtm.SelectedIndex = 6 Then ' saving
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
            txtinterestRate.Enabled = True
        ElseIf txtm.SelectedIndex = 7 Then 'emergency savings
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
            txtinterestRate.Enabled = True

        End If
    End Sub

    Private Sub txtamountneeded_OnValueChanged_2(sender As System.Object, e As System.EventArgs) Handles txtamountneeded.OnValueChanged

    End Sub

    Private Sub txtamountneeded_Validated1(sender As Object, e As System.EventArgs) Handles txtamountneeded.Validated
        Dim profit, jo, z As Double
        z = Val(txtinterestRate.Text) / 100
        profit = (Val(txtamountneeded.Text) * z) + Val(txtamountneeded.Text)
        jo = profit / Val(txtmonth.Text)

        If txtm.SelectedIndex = 0 Then  'LTCL
            If Val(txtamountneeded.Text) > 2000000 Then
                MsgBox("Maximum Amount for this Loan is 2,000,000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                txtamountpayable.Text = jo
                ' txtinterestRate.Text = "24"
            End If
        ElseIf txtm.SelectedIndex = 1 Then 'STCL
            If Val(txtamountneeded.Text) > 100000 Then
                MsgBox("Maximum Amount for this Loan is 100,000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                txtamountpayable.Text = jo
                ' txtinterestRate.Text = "6"
            End If
        ElseIf txtm.SelectedIndex = 2 Then 'LMTS

            txtamountpayable.Text = jo
            ' txtinterestRate.Text = "36"

        ElseIf txtm.SelectedIndex = 3 Then 'STML i
            'paid = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text))
            txtamountpayable.Text = jo
            'txtinterestRate.Text = "4"
        ElseIf txtm.SelectedIndex = 4 Then 'STML ii
            'paid = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text))
            txtamountpayable.Text = jo
            'txtinterestRate.Text = "12"
        ElseIf txtm.SelectedIndex = 5 Then ' emergencyloan
            If Val(txtamountneeded.Text) > 20000 Then
                MsgBox("Maximum Amount for this Loan is 20000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                'paid = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text))
                txtamountpayable.Text = jo
            End If

        ElseIf txtm.SelectedIndex = 6 Then ' saving
            txtmonth.Text = "1"
            ' txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 7 Then 'emergency savings
            txtmonth.Text = "1"
            ' txtinterestRate.Text = "0"
        End If

    End Sub

    Private Sub DateTimePicker3_ValueChanged_1(sender As System.Object, e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        Dim a As Integer
        a = Val(txtmonth.Text)
        DateTimePicker4.Value = DateTimePicker3.Value.AddMonths(a)
    End Sub

    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click
        If txtipps.Text = "" Then
            MsgBox("Please Perform a search query and try printing again", vbCritical)
        Else
            printreport.txtfname.Text = Me.txtfname.Text
            printreport.txtemer.Text = Me.txtemer.Text
            printreport.txteno.Text = Me.txteno.Text
            printreport.txtfno.Text = Me.txtfno.Text
            printreport.txtipps.Text = Me.txtipps.Text
            printreport.txtltcl.Text = Me.txtltcl.Text
            printreport.txtremark.Text = Me.txtremark.Text
            printreport.txtltms.Text = Me.txtltms.Text
            printreport.txtmd.Text = Me.txtmd.Text
            printreport.txtsavgs.Text = Me.txtsavgs.Text
            printreport.txtshare.Text = Me.txtshare.Text
            printreport.txtstcl.Text = Me.txtstcl.Text
            printreport.txtstms.Text = Me.txtstms.Text
            printreport.stms1.Text = Me.stms1.Text
            printreport.txtsp.Text = Me.txtsp.Text
            printreport.loanpassport.Image = Me.loanpassport.Image
            printreport.loansign.Image = Me.loansign.Image
            logss()
            Me.Hide()
            printreport.Show()

        End If
    End Sub
    Sub logss()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Printed Summary " & txtipps.Text


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", TextBox1.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
    Private Sub BunifuCustomLabel6_Click(sender As System.Object, e As System.EventArgs) Handles BunifuCustomLabel6.Click

    End Sub
    Private Sub ITalk_Panel1_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Panel1.Click

    End Sub
End Class