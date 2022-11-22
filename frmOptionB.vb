Public Class frmOptionB
    Private Sub BtnOptionB_Click(sender As Object, e As EventArgs) Handles btnOptionB.Click
        Me.Visible = False
        frmMenu.Visible = True
    End Sub

    Private Sub FrmOptionB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdStore1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles cmdStore1.Click

        Me.txtDisplay1.Text += txtTyper.Text
    End Sub

    Private Sub cmdStore2_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles cmdStore2.Click

        Me.txtDisplay2.Text += txtTyper.Text
    End Sub

    Private Sub cmdStore3_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles cmdStore3.Click

        Me.txtDisplay3.Text += txtTyper.Text
    End Sub

    Private Sub cmdStore4_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles cmdStore4.Click

        Me.txtDisplay4.Text += txtTyper.Text
    End Sub

    Private Sub cmdStore5_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles cmdStore5.Click

        Me.txtDisplay5.Text += txtTyper.Text
    End Sub

    Private Sub BtnPicture1_Click(sender As Object, e As EventArgs) Handles btnPicture1.Click
        PictureBox1.Visible = True
        PictureBox1.Image = Image.FromFile("C:\Pictures\ImageName.jpg")
    End Sub

    Private Sub BtnPicture2_Click(sender As Object, e As EventArgs) Handles btnPicture2.Click
        PictureBox2.Visible = True
        PictureBox2.Image = Image.FromFile("C:\Pictures\ImageName.jpg")
    End Sub

    Private Sub BtnPicture3_Click(sender As Object, e As EventArgs) Handles btnPicture3.Click
        PictureBox3.Visible = True
        PictureBox3.Image = Image.FromFile("C:\Pictures\ImageName.jpg")
    End Sub
End Class
