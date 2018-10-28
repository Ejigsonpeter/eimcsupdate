Public Class printreport
    Dim t As Date
    Private Sub printreport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        t = Now
        ibldate.Text = t
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
        frmmenu.Show()


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
        txteno.Text = ""
        txtfno.Text = ""
        txtemer.Text = ""
        loanpassport.Image = BackgroundImage
        loansign.Image = BackgroundImage


    End Sub

    Private Sub btnupdatemedicalrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnupdatemedicalrecord.Click
        PrintForm1.Print()
    End Sub
End Class