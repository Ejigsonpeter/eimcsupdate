﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmaddadminvb
    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim fn As String
    Dim use As String
    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub ITalk_Button_21_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_21.Click
        If txtid.Text = "" Then
            MsgBox("Enter user ID", vbCritical)
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter user pass ", vbCritical)
        ElseIf txtnpassword.Text Then
            MsgBox("Enter new Password", vbCritical)
        Else
            Try
                Myconnection.Open()
                Dim query As String
                Dim reader As MySqlDataReader

                query = "Select * from users where userid = '" & txtid.Text & "' and password = '" & txtpass.Text & "'"
                cmd = New MySqlCommand(query, Myconnection)
                reader = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then

                    Myconnection.Close()
                    Myconnection.Open()

                    
                    Dim sql As String



                    sql = "UPDATE users set password = '" & txtpass.Text & "' where userid = " & txtid.Text

                    Dim cmdx As New MySqlCommand(sql, Myconnection)

                    MsgBox("Password Reset Successfull ", vbInformation)
                    cmdx.ExecuteNonQuery()

                    Myconnection.Close()
                   


                Else
                    MsgBox("Incorrect Information", vbCritical)
                   
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ITalk_Button_22_Click(sender As System.Object, e As System.EventArgs) Handles ITalk_Button_22.Click
        If txtusername.Text = "" Then
            MsgBox("Enter user ID", vbCritical)
        ElseIf txtpassword.Text = "" Then
            MsgBox("Enter password ", vbCritical)
        ElseIf txtcpassword.Text = "" Then
            MsgBox("Enter new password ", vbCritical)
        ElseIf txtpassword.Text <> txtcpassword.Text Then
             MsgBox("Password Mismatch", vbCritical)
        Else
            Try
                Myconnection.Close()
                Myconnection.Open()
                

                Dim sql As String



                sql = "insert into users (userid,password)" _
                        & "VALUES(@username,@pass)"

                Dim cmdx As New MySqlCommand(sql, Myconnection)
                cmdx.Parameters.AddWithValue("@username", txtusername.Text)
                cmdx.Parameters.AddWithValue("@pass", txtpassword)


                cmdx.ExecuteNonQuery()
                MsgBox("User Added Successfully ", vbInformation)



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
    End Sub
End Class