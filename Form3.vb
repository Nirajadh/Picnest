Imports System.IO
Imports Guna.UI2.WinForms

Public Class Form3
    Private db As New sqlcontrol()
    Dim profileimage As Bitmap

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim ed As New edit1()
        acc.Hide()

        updatecheck = False
        ed.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent1.Controls.Add(ed)
        ed.BringToFront()
    End Sub


    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btngallery.Click
        acc.Hide()
        homecheck = False
        Dim g As New gallery1(userid)

        g.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent1.Controls.Add(g)
        g.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        acc.Hide()
        homecheck = True
        Dim h As New Home()

        h.Dock = DockStyle.Fill  ' Optional: if you want it to fill the panel
        pnlcontent1.Controls.Add(h)
        h.BringToFront()
    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True

        db.AddParam("@UserID", userid)
        db.ExecQuery("SELECT ProfilePic FROM Users WHERE UserID=@UserID")
        If db.HasException(True) Then Exit Sub
        If db.RecordCount > 0 Then
            Dim row As DataRow = db.DBDT.Rows(0)





            If Not IsDBNull(row("ProfilePic")) Then
                Dim imagedata As Byte() = CType(row("ProfilePic"), Byte())
                profileimage = ByteArrayToImage(imagedata)
                accountbutton.Image = profileimage
                profilePIC = profileimage.Clone()

            Else
                ' Handle the case where ProfilePic is NULL (no image)
                ' Optionally, you can set a default image or leave it blank
                accountbutton.Image = Nothing ' Set to blank or default image
            End If
        End If
    End Sub
    Private Function ByteArrayToImage(byteArray As Byte()) As Bitmap
        Using ms As New MemoryStream(byteArray)
            Return New Bitmap(ms)
        End Using
    End Function
    Private Sub Form3_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            btnhome.PerformClick()
        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles accountbutton.Click

        If accountbutton.Checked = False Then
            accountbutton.Checked = True

        Else
            accountbutton.Checked = False
        End If

        If accountbutton.Checked = True Then
            acc.Show()
        Else
            acc.Hide()
        End If


    End Sub


    Private Sub pnlcontent1_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlcontent1.MouseClick
        accountbutton.PerformClick()

    End Sub

    Private Sub Guna2Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2Panel2.MouseClick
        accountbutton.PerformClick()

    End Sub

    Private Sub panelcontent_MouseClick(sender As Object, e As MouseEventArgs) Handles panelcontent.MouseClick
        accountbutton.PerformClick()
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs)
        accountbutton.PerformClick()
    End Sub
End Class
