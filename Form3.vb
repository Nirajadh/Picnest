Imports Guna.UI2.WinForms

Public Class Form3
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim ed As New edit1()

        updatecheck = False
        ed.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent1.Controls.Add(ed)
        ed.BringToFront()
    End Sub


    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btngallery.Click
        homecheck = False
        Dim g As New gallery1(userid)

        g.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent1.Controls.Add(g)
        g.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        homecheck = True
        Dim h As New Home()

        h.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent1.Controls.Add(h)
        h.BringToFront()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        pnlcontent1.Controls.Clear()
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True

    End Sub

    Private Sub Form3_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            btnhome.PerformClick()
        End If
    End Sub


End Class
