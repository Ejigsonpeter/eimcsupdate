Public NotInheritable Class S

  


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If pg1.Value < 100 Then
            pg1.Value = pg1.Value + 1
        ElseIf pg1.Value = 100 Then
            pg1.Enabled = False
            Signin.Show()
            Me.Hide()


        End If
    End Sub
End Class
