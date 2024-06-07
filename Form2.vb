Public Class Form2




    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles supPasstoggle.Click
        If supPasstoggle.Checked = True Then
            supPass.PasswordChar = "*"
        Else
            supPass.PasswordChar = ""
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub signinlabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signinlabel.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Form1.Close()

    End Sub
End Class