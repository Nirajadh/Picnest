Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles sinpasstoggle.Click
        If sinpasstoggle.Checked = True Then
            passwordtxt.PasswordChar = "*"
        Else
            passwordtxt.PasswordChar = ""
        End If



    End Sub

    Private Sub createacclabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles createacclabel.LinkClicked
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Form2.Close()

    End Sub
End Class
