Public NotInheritable Class S

  


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If pg1.Value < 100 Then
            pg1.Value = pg1.Value + 1
        Else
            pg1.Enabled = False
            Me.Hide()
            Signin.Show()
        End If
    End Sub
End Class
