Public Class Form3
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim ed As New edit1()

        ed.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent.Controls.Add(ed)
        ed.BringToFront()
    End Sub

    Private Sub pnlcontent_Paint(sender As Object, e As PaintEventArgs) Handles pnlcontent.Paint
        ' No action needed here unless you have custom painting logic
    End Sub
End Class
