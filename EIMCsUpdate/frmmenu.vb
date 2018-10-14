Public Class frmmenu

    Private Sub BunifuTileButton1_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        members.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton4.Click
        Me.Hide()
        viewmembers.Show()

    End Sub

    
    Private Sub btnloan_Click(sender As System.Object, e As System.EventArgs) Handles btnloan.Click
        Me.Hide()
        Loan.Show()

    End Sub

    Private Sub BunifuTileButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton2.Click
        Me.Hide()
        frmclearloan.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As System.Object, e As System.EventArgs) Handles BunifuTileButton3.Click
        Me.Hide()


        frmviewloans.Show()


    End Sub
End Class