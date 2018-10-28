
Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel 'Before you add this reference to your project,
' you need to install Microsoft Office and find last version of this file.
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmscheduling
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




    Sub grid()
        Try
            Myconnection.Close()
            Myconnection.Open()
            
            Dim selectQuery As String = "select * from schedule"
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

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmscheduling_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        grid()

    End Sub

    Private Sub ITalk_Button_23_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_23.Click
        Me.Hide()
        frmschedule.Show()

    End Sub

    Private Sub dgw_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub ITalk_Button_22_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_22.Click
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
        Dim strFileName As String = "c:\db\schedule.csv"
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
        logs()
    End Sub


    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_21.Click
        PrintDGV.Print_DataGridView(dgw)
        logged()
    End Sub

    Sub logs()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim at, task As String
            at = Now
            task = "Exported Loan Schedule to excel"


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
            task = "Printed Loan Schedule"


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