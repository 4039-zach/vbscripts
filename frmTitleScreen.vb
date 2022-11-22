Public Class frmTitleScreen
    Private Sub BtnTitleScreen_Click(sender As Object, e As EventArgs) Handles btnTitleScreen.Click
        Me.Visible = False
        frmMenu.Visible = True
    End Sub

    Private Sub btnTitleScreen_MouseHover(sender As Object, e As EventArgs) Handles btnTitleScreen.MouseHover
        btnTitleScreen.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub btnTitleScreen_MouseLeave(sender As Object, e As EventArgs) Handles btnTitleScreen.MouseLeave
        btnTitleScreen.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub FrmTitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblProduct_Click(sender As Object, e As EventArgs) Handles lblMultiply.Click

    End Sub

    Private Sub BtnCalculations_Click(sender As Object, e As EventArgs) Handles btnCalculations.Click
        lblSum.Text = txtNum1.Text & “+” & txtNum2.Text & “=” & (Val(txtNum1.Text) + Val(txtNum2.Text))
        lblDivide.Text = txtNum1.Text & “/” & txtNum2.Text & “=” & (Val(txtNum1.Text) / Val(txtNum2.Text))
        lblMultiply.Text = txtNum1.Text & "*" & txtNum2.Text & "=" & (Val(txtNum1.Text) * Val(txtNum2.Text))
        lblSubtract.Text = txtNum1.Text & "-" & txtNum2.Text & "=" & (Val(txtNum1.Text) - Val(txtNum2.Text))
    End Sub
End Class
