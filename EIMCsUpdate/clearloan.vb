Imports MySql.Data.MySqlClient
Imports System.IO


Public Class clearloan
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
    Dim status As String


    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    Dim use, x As String
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

    Sub loanstcl()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection
            Dim s, type1, type2, type3 As String
            status = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type2 & "' and status = '" & status & "'"

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
                txtstcl.Text = p & "(outstanding)" & pay & " " & x
            Else
                txtstcl.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub


    Sub loanltcl()
        Try
            status = "unpaid"
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
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type1 & "' and status = '" & status & "'"

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
                txtltcl.Text = p & "(outstanding)" & pay & " " & x


                Myconnection.Close()

            Else
                txtltcl.Text = "0"
            End If
            '---reset the timer to another five seconds---


        Catch ex As Exception

        End Try
    End Sub
   sub loanltms()
        Try
            status = "unpaid"
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
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type3 & "' and status = '" & status & "'"
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
                txtltms.Text = p & "(outstanding)" & pay & " " & x

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

            status = "unpaid"
            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"


            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type4 & "' and status = '" & status & "'"

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
                txtstms.Text = p & "(outstanding)" & pay & " " & x



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
            status = "unpaid"

            type1 = "Long Term Cash Loan LTCL"
            type2 = "Short Term Cash Loan STCL"
            type3 = "Long Term Material Sales LMTS"
            type4 = "4 months Short Term Material Sales STMS"
            type5 = "12 months Short Term Material Sales STMS"



            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM loan WHERE ippsno = '" & txtsearch.Text & "' and loantype = '" & type5 & "' and status = '" & status & "'"

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
                stms1.Text = p & "(outstanding)" & pay & " " & x


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




            Else
                MsgBox("No Matching record found in Database", vbCritical)
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnpay_Click(sender As System.Object, e As System.EventArgs) Handles btnpay.Click
        If txtm.SelectedIndex = 0 Then

        ElseIf txtm.SelectedIndex = 1 Then
        ElseIf txtm.SelectedIndex = 2 Then
        ElseIf txtm.SelectedIndex = 3 Then
        ElseIf txtm.SelectedIndex = 4 Then
        ElseIf txtm.SelectedIndex = 5 Then

        End If
    End Sub
End Class