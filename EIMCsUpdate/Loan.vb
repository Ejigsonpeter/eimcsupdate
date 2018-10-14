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
                Dim reader As MySqlDataReader
                Dim command As MySqlCommand = New MySqlCommand
                command.Connection = Myconnection
                Dim s, type1, type2, type3 As String
                s = "unpaid"

                type1 = "Long Term Cash Loan LTCL"
                type2 = "Short Term Cash Loan STCL"
                type3 = "Long Term Material Sales LMTS"
                '----retrieve student's particulars
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "' and loantype = '" & txtm.SelectedValue & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then

                    MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)


                Else
                    If ((txtamountneeded.Text) <= (txtsavgs.Text * 2)) Then
                        MsgBox("You are eligible for this loan", vbInformation)
                        insertloan()
                    Else
                        MsgBox("You are not eligible for this loan. your twice your savings is less than the amount needed", vbInformation)
                    End If


                End If
                '---reset the timer to another five seconds---
                'Timer1.Enabled = False
                'Timer1.Enabled = True
                Myconnection.Close()


            ElseIf txtm.SelectedIndex = 1 Then 'STCL
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
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "'  and loantype = '" & txtm.SelectedValue & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then

                    MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)


                Else
                    insertloan()

                End If
                '---reset the timer to another five seconds---
                'Timer1.Enabled = False
                'Timer1.Enabled = True
                Myconnection.Close()


            ElseIf txtm.SelectedIndex = 2 Then 'LMTS
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
                command.CommandText = "SELECT * FROM loan WHERE ippsno  = '" & txtipps.Text & "'  and loantype = '" & txtm.SelectedValue & "'"
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then

                    MsgBox(count & " Matching Record found in Database , Hence you are not eligible for this loan . Please you cannot service LTCL,STCL or LTMS at thesame time", vbInformation)


                Else
                    If (((txtamountneeded.Text) <= (txtsavgs.Text * 3)) And ((txtamountneeded.Text) <= (txtshare.Text * 3))) Then
                        MsgBox("You are eligible for this loan", vbInformation)
                        insertloan()
                    Else
                        MsgBox("You are not eligible for this loan. your twice your savings is less than the amount needed", vbInformation)
                    End If


                End If
                '---reset the timer to another five seconds---
                'Timer1.Enabled = False
                'Timer1.Enabled = True
                Myconnection.Close()

            End If



        Catch ex As Exception

        End Try

    End Sub

    Sub insertloan()
        Try
            Myconnection.Close()
            Myconnection.Open()


            Dim sql As String
            sql = "insert into loan (fullname,ippsno,loantype,paymentduration,amountpayble,amountneeded,interestrate,startdate,enddate,status,treasurername)" _
                & "VALUES(@fullname,@ippsno,@loantype,@paymentduration,@amountpayable,@amountneeded,@interestrate,@startdate,@enddate,@status,@tresname)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", txtfname.Text)
            cmdx.Parameters.AddWithValue("@ippsno", txtipps.Text)
            cmdx.Parameters.AddWithValue("@loantype", txtm.Text)
            cmdx.Parameters.AddWithValue("@paymentduration", txtmonth.Text)
            cmdx.Parameters.AddWithValue("@amountpayable", txtamountpayable.Text)
            cmdx.Parameters.AddWithValue("@amountneeded", paid)
            cmdx.Parameters.AddWithValue("@interestrate", txtinterestRate.Text)
            cmdx.Parameters.AddWithValue("@startdate", DateTimePicker3.Text)
            cmdx.Parameters.AddWithValue("@enddate", DateTimePicker4.Text)
            cmdx.Parameters.AddWithValue("@status", "upaid")
            cmdx.Parameters.AddWithValue("@tresname", TextBox1.Text)



            cmdx.ExecuteNonQuery()
            MsgBox("Information Saved Successfully ", vbInformation)
            Myconnection.Close()
            logs()

            clearloan()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
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
            task = TextBox1.Text & "Granted a " & txtm.SelectedValue & "to" & txtfname.Text


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

    


    Private Sub txtm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtm.SelectedIndexChanged
        If txtm.SelectedIndex = 0 Then 'LTCL
            txtmonth.Text = "24"
            txtinterestRate.Text = "0"

        ElseIf txtm.SelectedIndex = 1 Then 'STCL
            txtmonth.Text = "6"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 2 Then 'LMTS
            txtmonth.Text = "36"
            txtinterestRate.Text = "10"
        ElseIf txtm.SelectedIndex = 3 Then 'STML i
            txtmonth.Text = "4"
            txtinterestRate.Text = "5"
        ElseIf txtm.SelectedIndex = 4 Then 'STML ii
            txtmonth.Text = "12"
            txtinterestRate.Text = "10"
        ElseIf txtm.SelectedIndex = 5 Then ' emergencyloan
            txtmonth.Text = "4"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 6 Then ' saving
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 7 Then 'emergency savings
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"


        End If
    End Sub

    Private Sub txtamountneeded_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamountneeded.Leave

    End Sub



    Private Sub txtamountneeded_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamountneeded.Validated

        Dim profit, jo, z As Double
        z = Val(txtinterestRate.Text) / 100
        profit = (txtamountneeded.Text * z) + txtamountneeded.Text
        jo = profit / txtmonth.Text

        If txtm.SelectedIndex = 0 Then  'LTCL
            If Val(txtamountneeded.Text) > 2000000 Then
                MsgBox("Maximum Amount for this Loan is 2,000,000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                txtamountpayable.Text = jo
            End If
        ElseIf txtm.SelectedIndex = 1 Then 'STCL
            If Val(txtamountneeded.Text) > 100000 Then
                MsgBox("Maximum Amount for this Loan is 100,000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                txtamountpayable.Text = jo
            End If
        ElseIf txtm.SelectedIndex = 2 Then 'LMTS

            txtamountpayable.Text = jo

        ElseIf txtm.SelectedIndex = 3 Then 'STML i
            'paid = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text))
            txtamountpayable.Text = jo

        ElseIf txtm.SelectedIndex = 4 Then 'STML ii
            'paid = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text))
            txtamountpayable.Text = jo
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
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 7 Then 'emergency savings
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
        End If


    End Sub

    Private Sub txtamountneeded_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            Typex = "Emergency Loan"

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & typex & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                Dim a As String
                Dim pay As String
                Dim x As String

                pay = reader.Item("paymentduration").ToString

                x = "month(s) remaining"
                txtemer.Text = "Yes  :" & pay & "  x"

                Myconnection.Close()

            Else
                txtemer.Text = "No"
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
                Dim a As String
                Dim pay As String
                Dim x As String

                pay = reader.Item("paymentduration").ToString

                x = "month(s) remaining"
                txtstcl.Text = "Yes  :" & pay & "  x"

                Myconnection.Close()

            Else
                txtstcl.Text = "No"
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
                Dim a As String

                Dim pay As String
                Dim x As String

                pay = reader.Item("paymentduration").ToString

                x = "month(s) remaining"
                txtltcl.Text = "Yes  :" & pay & " " & x

                Myconnection.Close()

            Else
                txtltcl.Text = "No"
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
                Dim a As String

                Dim pay As String
                Dim x As String

                pay = reader.Item("paymentduration").ToString

                x = "month(s) remaining"
                txtltms.Text = "Yes  :" & pay & " " & x

                Myconnection.Close()

            Else
                txtltms.Text = "No"
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
                Dim a As String

                Dim pay As String
                Dim x As String

                pay = reader.Item("paymentduration").ToString

                x = "month(s) remaining"
                txtstms.Text = "Yes  :" & pay & " " & x

                Myconnection.Close()

            Else
                txtstms.Text = "No"
            End If
            '---reset the timer to another five seconds---


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
                Dim a As String

                Dim pay As String
                Dim x As String

                pay = reader.Item("paymentduration").ToString

                x = "month(s) remaining"
                stms1.Text = "Yes  :" & pay & " " & x

                Myconnection.Close()

            Else
                stms1.Text = "No"
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
            command.CommandText = "SELECT * FROM members WHERE fileno = '" & txtsearch.Text & "'"

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





            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

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



            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
    Sub searchloan2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection

            '----retrieve student's particularseimcs
            command.CommandText = "SELECT * FROM members WHERE eimcsno = '" & txtsearch.Text & "'"

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


            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
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

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        Dim a As Integer
        a = Val(txtmonth.Text)
        DateTimePicker4.Value = DateTimePicker3.Value.AddMonths(a)
    End Sub

   
    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_21.Click
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub txtamountneeded_OnValueChanged_1(sender As System.Object, e As System.EventArgs) Handles txtamountneeded.OnValueChanged

    End Sub
End Class