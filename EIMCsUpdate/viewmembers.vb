Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel 'Before you add this reference to your project,
' you need to install Microsoft Office and find last version of this file.
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel

Public Class viewmembers
    Private ComDset As New DataSet
    Private ComDset1 As New DataSet



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


    Private Sub viewmembers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grid()

    End Sub

    Sub grid()

        Try
            Myconnection.Close()
            Myconnection.Open()

            Dim selectQuery As String = "select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,applicantdate from members"
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
        da = New MySqlDataAdapter("select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,applicantdate from members", Myconnection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgw.DataSource = view1
        dgw.Refresh()
        source1.Filter = "applicantdate >= '" & firstdate & "' and  applicantdate <= '" & seconddate & "'"
        dgw.Refresh()
        Myconnection.Close()



    End Sub

    Sub vouncher1()
        Dim x As String
        x = txtsearch.Text
        Myconnection.Close()
        Myconnection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,applicantdate from members", Myconnection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgw.DataSource = view1
        dgw.Refresh()
        source1.Filter = "ippsno = '" & x & "'"
        dgw.Refresh()
        Myconnection.Close()
    End Sub

    'Sub vouncher1()
    '    Dim x As String
    '    x = txtsearch.Text
    '    Myconnection.Open()
    '    Dim ds As DataSet = New DataSet
    '    Dim da As MySqlDataAdapter
    '    Dim tables As DataTableCollection = ds.Tables
    '    Dim source1 As New BindingSource()
    '    da = New MySqlDataAdapter("select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,applicantdate from members", Myconnection)
    '    da.Fill(ds, "Items")
    '    Dim view1 As New DataView(tables(0))
    '    source1.DataSource = view1
    '    dgw.DataSource = view1
    '    dgw.Refresh()
    '    source1.Filter = "fileno = '" & x & "'"
    '    dgw.Refresh()
    '    Myconnection.Close()



    'End Sub
    Sub vouncher2()
        Dim x As String
        x = txtsearch.Text
        Myconnection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,applicantdate from members", Myconnection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgw.DataSource = view1
        dgw.Refresh()
        source1.Filter = "ippsno = '" & x & "'"
        dgw.Refresh()
        Myconnection.Close()



    End Sub
    Sub vouncher3()
        Dim x As String
        x = txtsearch.Text
        Myconnection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,applicantdate from members", Myconnection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgw.DataSource = view1
        dgw.Refresh()
        source1.Filter = "eimcsno = '" & x & "'"
        dgw.Refresh()
        Myconnection.Close()



    End Sub







    Private Sub ITalk_Button_25_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_25.Click
        MessageBox.Show("Exporting Member Records!")
        'verfying the datagridview having data or not
        If ((dgw.Columns.Count = 0) Or (dgw.Rows.Count = 0)) Then
            Exit Sub
        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To dgw.ColumnCount - 1
            dset.Tables(0).Columns.Add(dgw.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i As Integer = 0 To dgw.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To dgw.Columns.Count - 1
                dr1(j) = dgw.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next
        Next

        wSheet.Columns.AutoFit()
        Dim strFileName As String = "c:\db\user.csv"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True
        MessageBox.Show("Export done successfully!")
        logss()


    End Sub



    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



    Private Sub btnsearch_Click_1(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click

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
        'If txtoption.selectedIndex = 0 Then
        '    MsgBox("Please Select An option ", vbInformation)
        'ElseIf txtsearch.Text = "" Then
        '    MsgBox("Space cannot be Empty", vbInformation)
        'ElseIf txtoption.selectedIndex = 1 Then

        '    If Len(txtsearch.Text) = 1 Then
        '        txtsearch.Text = "0000" & txtsearch.Text
        '        vouncher1()
        '    ElseIf Len(txtsearch.Text) = 2 Then
        '        txtsearch.Text = "000" & txtsearch.Text
        '        vouncher1()
        '    ElseIf Len(txtsearch.Text) = 3 Then
        '        txtsearch.Text = "00" & txtsearch.Text
        '        vouncher1()
        '    ElseIf Len(txtsearch.Text) = 4 Then
        '        txtsearch.Text = "0" & txtsearch.Text
        '        vouncher1()
        '    Else
        '        vouncher1()
        '    End If
        'ElseIf txtoption.selectedIndex = 2 Then

        '    If Len(txtsearch.Text) = 1 Then
        '        txtsearch.Text = "0000" & txtsearch.Text
        '        vouncher2()
        '    ElseIf Len(txtsearch.Text) = 2 Then
        '        txtsearch.Text = "000" & txtsearch.Text
        '        vouncher2()
        '    ElseIf Len(txtsearch.Text) = 3 Then
        '        txtsearch.Text = "00" & txtsearch.Text
        '        vouncher2()
        '    ElseIf Len(txtsearch.Text) = 4 Then
        '        txtsearch.Text = "0" & txtsearch.Text
        '        vouncher2()
        '    Else
        '        vouncher2()
        '    End If
        'ElseIf txtoption.selectedIndex = 3 Then

        '    If Len(txtsearch.Text) = 1 Then
        '        txtsearch.Text = "0000" & txtsearch.Text
        '        vouncher3()
        '    ElseIf Len(txtsearch.Text) = 2 Then
        '        txtsearch.Text = "000" & txtsearch.Text
        '        vouncher3()
        '    ElseIf Len(txtsearch.Text) = 3 Then
        '        txtsearch.Text = "00" & txtsearch.Text
        '        vouncher3()
        '    ElseIf Len(txtsearch.Text) = 4 Then
        '        txtsearch.Text = "0" & txtsearch.Text
        '        vouncher3()
        '    Else
        '        vouncher3()
        '    End If
        'End If
    End Sub
    Sub activate1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim sql As String

            Dim status As String
            status = "active"
            sql = "update  members set approvalstatus = '" & status & "' where fileno = " & txtsearch.Text

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@status", status)

            cmdx.ExecuteNonQuery()
            MsgBox("User activated Successfully ", vbInformation)

            Myconnection.Close()
            grid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub activate2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim sql As String

            Dim status As String
            status = "active"
            sql = "update  members set approvalstatus = '" & status & "' where ippsno = " & txtsearch.Text

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@status", status)

            cmdx.ExecuteNonQuery()
            MsgBox("User activated Successfully ", vbInformation)

            Myconnection.Close()
            grid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub activate3()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim sql As String

            Dim status As String
            status = "active"
            sql = "update  members set approvalstatus = '" & status & "' where eimcsno = " & txtsearch.Text

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@status", status)

            cmdx.ExecuteNonQuery()
            MsgBox("User activated Successfully ", vbInformation)

            Myconnection.Close()
            grid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub loga()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            Dim s, y As String
            s = txtoption.selectedValue
            y = txtsearch.Text
            task = "User Deactivated with " & s & " " & y


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", Label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()
            Myconnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub logs()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            Dim s, y As String
            s = txtoption.selectedValue
            y = txtsearch.Text
            task = "User activated with " & s & " " & y


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", Label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()
            Myconnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub btnactivate_Click(sender As System.Object, e As System.EventArgs) Handles btnactivate.Click
        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select An option ", vbInformation)
        ElseIf txtsearch.Text = "" Then
            MsgBox("Space cannot be Empty", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                activate1()
                logs()

            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                activate1()
                logs()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                activate1()
                logs()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                activate1()
                logs()
            Else
                activate1()
                logs()
            End If
        ElseIf txtoption.selectedIndex = 2 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                activate2()
                logs()
            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                activate2()
                logs()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                activate2()
                logs()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                activate2()
                logs()
            Else
                activate2()
                logs()
            End If
        ElseIf txtoption.selectedIndex = 3 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                activate3()
                logs()
            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                activate3()
                logs()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                activate3()
                logs()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                activate3()
                logs()
            Else
                activate3()
                logs()
            End If
        End If
    End Sub

    Private Sub btndeactivate_Click(sender As System.Object, e As System.EventArgs) Handles btndeactivate.Click

        If txtoption.selectedIndex = 0 Then
            MsgBox("Please Select An option ", vbInformation)
        ElseIf txtsearch.Text = "" Then
            MsgBox("Space cannot be Empty", vbInformation)
        ElseIf txtoption.selectedIndex = 1 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                deactivate1()
                loga()
            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                deactivate1()
                loga()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                deactivate1()
                loga()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                deactivate1()
                loga()
            Else
                deactivate1()
                loga()
            End If
        ElseIf txtoption.selectedIndex = 2 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                deactivate2()
                loga()
            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                deactivate2()
                loga()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                deactivate2()
                loga()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                deactivate2()
                loga()
            Else
                deactivate2()
                loga()
            End If
        ElseIf txtoption.selectedIndex = 3 Then

            If Len(txtsearch.Text) = 1 Then
                txtsearch.Text = "0000" & txtsearch.Text
                deactivate3()
                loga()
            ElseIf Len(txtsearch.Text) = 2 Then
                txtsearch.Text = "000" & txtsearch.Text
                deactivate3()
                loga()
            ElseIf Len(txtsearch.Text) = 3 Then
                txtsearch.Text = "00" & txtsearch.Text
                deactivate3()
                loga()
            ElseIf Len(txtsearch.Text) = 4 Then
                txtsearch.Text = "0" & txtsearch.Text
                deactivate3()
                loga()
            Else
                deactivate3()
                loga()
            End If
        End If
    End Sub

    Private Sub btnsearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles btnsearch.KeyPress
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

    Private Sub btnquery_Click(sender As System.Object, e As System.EventArgs) Handles btnquery.Click
        vouncher()

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        grid()
    End Sub

    Sub deactivate1()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim sql As String

            Dim status As String
            status = "not active"
            sql = "update  members set approvalstatus = '" & status & "' where fileno = " & txtsearch.Text

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@status", status)

            cmdx.ExecuteNonQuery()
            MsgBox("User Deactivated Successfully ", vbInformation)

            Myconnection.Close()
            grid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub deactivate2()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim sql As String

            Dim status As String
            status = "not active"
            sql = "update  members set approvalstatus = '" & status & "' where ippsno = " & txtsearch.Text

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@status", status)

            cmdx.ExecuteNonQuery()
            MsgBox("User Deactivated Successfully ", vbInformation)

            Myconnection.Close()
            grid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub deactivate3()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim sql As String

            Dim status As String
            status = "not active"
            sql = "update  members set approvalstatus = '" & status & "' where eimcsno = " & txtsearch.Text

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@status", status)

            cmdx.ExecuteNonQuery()
            MsgBox("User Deactivated Successfully ", vbInformation)

            Myconnection.Close()
            grid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_21.Click
        PrintDGV.Print_DataGridView(dgw)
        logged()
    End Sub

    Sub logss()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Exported Member Records to excel"


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", Label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub logged()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Printed Member Records"


            Dim sql As String



            sql = "insert into logs (fullname,Task,activity_time)" _
                    & "VALUES(@fullname,@task,@activitytime)"

            Dim cmdx As New MySqlCommand(sql, Myconnection)
            cmdx.Parameters.AddWithValue("@fullname", Label2.Text)
            cmdx.Parameters.AddWithValue("@task", task)
            cmdx.Parameters.AddWithValue("@activitytime", at)

            cmdx.ExecuteNonQuery()




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

End Class