﻿Imports System.IO


Public Class Form3
    Private db As New sqlcontrol()
    Dim profileimage As Bitmap

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        pnlcontent1.Controls.Clear()
        Dim ed As New edit1()
        acc.Hide()
        searchuserid = 0
        updatecheck = False
        ed.Dock = DockStyle.Fill
        pnlcontent1.Controls.Add(ed)
        ed.BringToFront()
    End Sub


    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btngallery.Click
        pnlcontent1.Controls.Clear()
        Imageedit = Nothing
        acc.Hide()
        homecheck = False
        Dim g As New gallery1()
        searchuserid = 0
        g.Dock = DockStyle.Fill
        pnlcontent1.Controls.Add(g)
        g.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        pnlcontent1.Controls.Clear()
        Imageedit = Nothing
        searchuserid = 0
        acc.Hide()
        homecheck = True
        Dim g As New gallery1()

        g.Dock = DockStyle.Fill
        pnlcontent1.Controls.Add(g)
        g.BringToFront()
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
                accountbtn.Image = profileimage
                profilePIC = profileimage.Clone()

            Else

                accountbtn.Image = My.Resources.defaultProfile
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




    Private Sub pnlcontent1_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlcontent1.MouseClick
        acc.Hide()
        acc.Close()
        acc.Dispose()
        accountbtn.Tag = False
    End Sub

    Private Sub Guna2Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2Panel2.MouseClick
        acc.Hide()
        acc.Close()
        acc.Dispose()
        accountbtn.Tag = False
    End Sub

    Private Sub panelcontent_MouseClick(sender As Object, e As MouseEventArgs) Handles panelcontent.MouseClick
        acc.Hide()
        acc.Close()
        acc.Dispose()
        accountbtn.Tag = False
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs)
        acc.Hide()
        acc.Close()
        acc.Dispose()
        accountbtn.Tag = False
    End Sub





    Private Sub accountbtn_Click(sender As Object, e As EventArgs) Handles accountbtn.Click
        If accountbtn.Tag = False Then
            accountbtn.Tag = True

        Else
            accountbtn.Tag = False
        End If

        If accountbtn.Tag = True Then
            acc.Show()
        Else
            acc.Hide()
            acc.Close()
            acc.Dispose()
        End If
    End Sub


End Class
