Imports System.IO
Imports MySql.Data.MySqlClient

Public Class controlpanel
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
    Private Sub ITalk_Button_23_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_23.Click
        Me.Hide()
        frmmenu.Show()
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

                MsgBox(count & "Matching record found in Database", vbInformation)

            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
   

    Sub emergency()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            typex = "Emergency Loan"
            s = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & typex & "' and status = '" & s & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d, g, id, y As String


               

                Dim d1 As Date
                Dim d2 As Date

                d1 = reader.Item("enddate").ToString

                p = reader.Item("ippsno")
                a = reader.Item("amountpayble").ToString
                id = reader.Item("sno").ToString
                g = reader.Item("paymentduration").ToString
                'MsgBox(a)
                y = g + 1

                d = reader.Item("amountpaid").ToString
                c = d - a


                y = Val(txtextend.Text)               
                d2 = d1.AddMonths(y)

                Myconnection.Close()

                Myconnection.Open()

                Dim sql, status As String
                status = "unpaid"

                'MsgBox(total)

                sql = "UPDATE loan set enddate = '" & d2 & "'," & "amountpaid = '" & c & "'," & " status = '" & status & "'," & " paymentduration = '" & y & "'  where sno = '" & id & "'"

                Dim cmdx As New MySqlCommand(sql, Myconnection)


                cmdx.ExecuteNonQuery()

                Myconnection.Close()

                MsgBox("Transaction Successfull ", vbInformation)
                ' MsgBox(d2)
                log1()
                txtsearch.Text = ""
                txtextend.Text = ""
                txtm.SelectedIndex = 0
            Else
                MsgBox("No Records Found", vbCritical)

            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub

    Sub m1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            typex = "Emergency Loan"
            s = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type1 & "' and status = '" & s & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d, g, id, y As String




                Dim d1 As Date
                Dim d2 As Date

                d1 = reader.Item("enddate").ToString

                p = reader.Item("ippsno")
                a = reader.Item("amountpayble").ToString
                id = reader.Item("sno").ToString
                g = reader.Item("paymentduration").ToString
                'MsgBox(a)
                y = g + 1

                d = reader.Item("amountpaid").ToString
                c = d - a


                y = Val(txtextend.Text)
                d2 = d1.AddMonths(y)

                Myconnection.Close()

                Myconnection.Open()

                Dim sql, status As String
                status = "unpaid"

                'MsgBox(total)

                sql = "UPDATE loan set enddate = '" & d2 & "'," & "amountpaid = '" & c & "'," & " status = '" & status & "'," & " paymentduration = '" & y & "'  where sno = '" & id & "'"

                Dim cmdx As New MySqlCommand(sql, Myconnection)


                cmdx.ExecuteNonQuery()

                Myconnection.Close()

                MsgBox("Transaction Successfull ", vbInformation)
                ' MsgBox(d2)
                log1()
                txtsearch.Text = ""
                txtextend.Text = ""
                txtm.SelectedIndex = 0
            Else
                MsgBox("No Records Found", vbCritical)

            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub m2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            typex = "Emergency Loan"
            s = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type2 & "' and status = '" & s & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d, g, id, y As String




                Dim d1 As Date
                Dim d2 As Date

                d1 = reader.Item("enddate").ToString

                p = reader.Item("ippsno")
                a = reader.Item("amountpayble").ToString
                id = reader.Item("sno").ToString
                g = reader.Item("paymentduration").ToString
                'MsgBox(a)
                y = g + 1

                d = reader.Item("amountpaid").ToString
                c = d - a


                y = Val(txtextend.Text)
                d2 = d1.AddMonths(y)

                Myconnection.Close()

                Myconnection.Open()

                Dim sql, status As String
                status = "unpaid"

                'MsgBox(total)

                sql = "UPDATE loan set enddate = '" & d2 & "'," & "amountpaid = '" & c & "'," & " status = '" & status & "'," & " paymentduration = '" & y & "'  where sno = '" & id & "'"

                Dim cmdx As New MySqlCommand(sql, Myconnection)


                cmdx.ExecuteNonQuery()

                Myconnection.Close()

                MsgBox("Transaction Successfull ", vbInformation)
                ' MsgBox(d2)
                log1()
                txtsearch.Text = ""
                txtextend.Text = ""
                txtm.SelectedIndex = 0
            Else
                MsgBox("No Records Found", vbCritical)

            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub m3()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            typex = "Emergency Loan"
            s = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type3 & "' and status = '" & s & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d, g, id, y As String




                Dim d1 As Date
                Dim d2 As Date

                d1 = reader.Item("enddate").ToString

                p = reader.Item("ippsno")
                a = reader.Item("amountpayble").ToString
                id = reader.Item("sno").ToString
                g = reader.Item("paymentduration").ToString
                'MsgBox(a)
                y = g + 1

                d = reader.Item("amountpaid").ToString
                c = d - a


                y = Val(txtextend.Text)
                d2 = d1.AddMonths(y)

                Myconnection.Close()

                Myconnection.Open()

                Dim sql, status As String
                status = "unpaid"

                'MsgBox(total)

                sql = "UPDATE loan set enddate = '" & d2 & "'," & "amountpaid = '" & c & "'," & " status = '" & status & "'," & " paymentduration = '" & y & "'  where sno = '" & id & "'"

                Dim cmdx As New MySqlCommand(sql, Myconnection)


                cmdx.ExecuteNonQuery()

                Myconnection.Close()

                MsgBox("Transaction Successfull ", vbInformation)
                ' MsgBox(d2)
                log1()
                txtsearch.Text = ""
                txtextend.Text = ""
                txtm.SelectedIndex = 0
            Else
                MsgBox("No Records Found", vbCritical)

            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub m4()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            typex = "Emergency Loan"
            s = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type4 & "' and status = '" & s & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d, g, id, y As String




                Dim d1 As Date
                Dim d2 As Date

                d1 = reader.Item("enddate").ToString

                p = reader.Item("ippsno")
                a = reader.Item("amountpayble").ToString
                id = reader.Item("sno").ToString
                g = reader.Item("paymentduration").ToString
                'MsgBox(a)
                y = g + 1

                d = reader.Item("amountpaid").ToString
                c = d - a


                y = Val(txtextend.Text)
                d2 = d1.AddMonths(y)

                Myconnection.Close()

                Myconnection.Open()

                Dim sql, status As String
                status = "unpaid"

                'MsgBox(total)

                sql = "UPDATE loan set enddate = '" & d2 & "'," & "amountpaid = '" & c & "'," & " status = '" & status & "'," & " paymentduration = '" & y & "'  where sno = '" & id & "'"

                Dim cmdx As New MySqlCommand(sql, Myconnection)


                cmdx.ExecuteNonQuery()

                Myconnection.Close()

                MsgBox("Transaction Successfull ", vbInformation)
                ' MsgBox(d2)
                log1()
                txtsearch.Text = ""
                txtextend.Text = ""
                txtm.SelectedIndex = 0
            Else
                MsgBox("No Records Found", vbCritical)

            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
    Sub m5()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3, type4, type5, typex As String


            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "Food Items"
            type5 = "Non Food Items"
            typex = "Emergency Loan"
            s = "unpaid"
            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type5 & "' and status = '" & s & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a, c, p, d, g, id, y As String




                Dim d1 As Date
                Dim d2 As Date

                d1 = reader.Item("enddate").ToString

                p = reader.Item("ippsno")
                a = reader.Item("amountpayble").ToString
                id = reader.Item("sno").ToString
                g = reader.Item("paymentduration").ToString
                'MsgBox(a)
                y = g + 1

                d = reader.Item("amountpaid").ToString
                c = d - a


                y = Val(txtextend.Text)
                d2 = d1.AddMonths(y)

                Myconnection.Close()

                Myconnection.Open()

                Dim sql, status As String
                status = "unpaid"

                'MsgBox(total)

                sql = "UPDATE loan set enddate = '" & d2 & "'," & "amountpaid = '" & c & "'," & " status = '" & status & "'," & " paymentduration = '" & y & "'  where sno = '" & id & "'"

                Dim cmdx As New MySqlCommand(sql, Myconnection)


                cmdx.ExecuteNonQuery()

                Myconnection.Close()

                MsgBox("Transaction Successfull ", vbInformation)
                ' MsgBox(d2)
                log1()
                txtsearch.Text = ""
                txtextend.Text = ""
                txtm.SelectedIndex = 0
            Else
                MsgBox("No Records Found", vbCritical)

            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select a search option", vbInformation)
        ElseIf txtsearch.Text = "" Then
            MsgBox("Please enter IPPS no to search", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then
            searchloan1()
        End If
    End Sub

    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_21.Click

        If txtsearch.Text = "" Then
            MsgBox("Please Search with IPPs No ", vbInformation)
        ElseIf txtextend.Text = "" Then
            MsgBox("Please Enter a value not exceeding 1", vbInformation)
        ElseIf Val(txtextend.Text) > 1 Then
            MsgBox("Please reduce the number you can only extend by 1 month", vbInformation)
        ElseIf txtm.SelectedIndex = 0 Then
            MsgBox("Please Select a Loan Type ", vbInformation)
        ElseIf txtm.SelectedIndex = 6 Then
            emergency()
        ElseIf txtm.SelectedIndex = 1 Then
            m1()
        ElseIf txtm.SelectedIndex = 2 Then
            m2()
        ElseIf txtm.SelectedIndex = 3 Then
            m3()
        ElseIf txtm.SelectedIndex = 4 Then
            m4()
        ElseIf txtm.SelectedIndex = 5 Then
            m5()
        End If

    End Sub

    Private Sub ITalk_Button_22_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_22.Click
        'update saving
        If txtsearch.Text = "" Then
            MsgBox("Please Search with IPPs No ", vbInformation)
        ElseIf txtsavings.Text = "" Then
            MsgBox("Please Enter Savings Amount ", vbInformation)
        Else
            savings()

        End If
    End Sub

    Sub log1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Extended Loan Duration for " & txtsearch.Text


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Sub log2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Changed Savings amount for " & txtsearch.Text


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub log3()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Changed Shares amount for " & txtsearch.Text


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub savings()
        Myconnection.Close()
        Myconnection.Open()

        Dim sql, status As String
        status = "unpaid"

        'MsgBox(total)

        sql = "UPDATE members set savings = '" & txtsavings.Text & "' where ippsno = '" & txtsearch.Text & "'"

        Dim cmdx As New MySqlCommand(sql, Myconnection)


        cmdx.ExecuteNonQuery()

        Myconnection.Close()

        'MsgBox("Transaction Successfull ", vbInformation)
        Myconnection.Close()
        Myconnection.Open()


        status = "unpaid"

        'MsgBox(total)

        sql = "UPDATE schedule set SAVINGS = '" & txtsavings.Text & "' where IPPS_NO = '" & txtsearch.Text & "'"

        Dim cmdxx As New MySqlCommand(sql, Myconnection)


        cmdxx.ExecuteNonQuery()

        Myconnection.Close()

        MsgBox("Transaction Successfull ", vbInformation)


        log2()

        ' MsgBox(d2)
        txtsearch.Text = ""
        txtsavings.Text = ""
    End Sub


    Sub shares()
        Myconnection.Close()
        Myconnection.Open()

        Dim sql, status As String
        status = "unpaid"

        'MsgBox(total)

        sql = "UPDATE members set shares = '" & txtshares.Text & "' where ippsno = '" & txtsearch.Text & "'"

        Dim cmdx As New MySqlCommand(sql, Myconnection)


        cmdx.ExecuteNonQuery()

        Myconnection.Close()

        'MsgBox("Transaction Successfull ", vbInformation)
        Myconnection.Close()
        Myconnection.Open()


        status = "unpaid"

        'MsgBox(total)

        sql = "UPDATE schedule set SHARE = '" & txtshares.Text & "' where IPPS_NO = '" & txtsearch.Text & "'"

        Dim cmdxx As New MySqlCommand(sql, Myconnection)


        cmdxx.ExecuteNonQuery()

        Myconnection.Close()

        MsgBox("Transaction Successfull ", vbInformation)


        log3()

        ' MsgBox(d2)
        txtsearch.Text = ""
        txtshares.Text = ""
    End Sub



    Private Sub ITalk_Button_24_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_24.Click
        If txtsearch.Text = "" Then
            MsgBox("Please Search with IPPs No ", vbInformation)
        ElseIf txtshares.Text = "" Then
            MsgBox("Please Enter Shares Amount ", vbInformation)
        Else
            shares()

        End If
    End Sub
End Class