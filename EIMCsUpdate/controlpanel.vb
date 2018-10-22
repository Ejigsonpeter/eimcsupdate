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
                'Me.loansign.Image = img1
                ''studPic.Image = image.FromFile("image.jpg")
                'loansign.SizeMode = PictureBoxSizeMode.StretchImage
                'loansign.Refresh()

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


                Dim pay1 As String
                pay = reader.Item("amountneeded").ToString
                pay1 = reader.Item("interestrate").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString


                c = (pay * (pay1 / 100)) + pay
                p = d - c

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

                Dim pay1 As String
                pay = reader.Item("amountneeded").ToString
                pay1 = reader.Item("interestrate").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString


                c = (pay * (pay1 / 100)) + pay
                p = d - c

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

                Dim pay1 As String
                pay = reader.Item("amountneeded").ToString
                pay1 = reader.Item("interestrate").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString


                c = (pay * (pay1 / 100)) + pay
                p = d - c

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

                Dim pay1 As String
                pay = reader.Item("amountneeded").ToString
                pay1 = reader.Item("interestrate").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString


                c = (pay * (pay1 / 100)) + pay
                p = d - c
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


                Dim pay1 As String
                pay = reader.Item("amountneeded").ToString
                pay1 = reader.Item("interestrate").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString


                c = (pay * (pay1 / 100)) + pay
                p = d - c

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

                Dim pay1 As String
                pay = reader.Item("amountneeded").ToString
                pay1 = reader.Item("interestrate").ToString
                a = reader.Item("amountpayble").ToString
                d = reader.Item("amountpaid").ToString


                c = (pay * (pay1 / 100)) + pay
                p = d - c
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

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select a search option", vbInformation)
        ElseIf txtsearch.Text = "" Then
            MsgBox("Please enter IPPS no to search", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then
            searchloan1()

        End If
    End Sub
End Class