Public Class frmOptionA
    Private Sub BtnOptionA_Click(sender As Object, e As EventArgs) Handles btnOptionA.Click
        Me.Visible = False
        frmMenu.Visible = True
    End Sub

    Private Sub LblEnterName_Click(sender As Object, e As EventArgs) Handles lblEnterFName.Click

    End Sub

    Private Sub BtnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        lblGreeting.Text = "Hello" & Chr(32) & txtFNameEntry.Text & Chr(32) & txtLNameEntry.Text & Chr(32) & "welcome!"
    End Sub
End Class
