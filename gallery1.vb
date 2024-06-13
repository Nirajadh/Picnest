Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Public Class Gallery1
    Inherits UserControl
    Dim userid As Integer
    Private db As New sqlcontrol()

    Public Sub New(uid As Integer)
        InitializeComponent()
        userid = uid

        LoadUserImages()
    End Sub

    Private Sub LoadUserImages()
        Try
            db.AddParam("@UserID", userid)
            db.ExecQuery("SELECT UploadID, ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = @UserID) AS Username FROM UserUploads WHERE UserID = @UserID")

            If db.HasException(True) Then Exit Sub

            For Each row As DataRow In db.DBDT.Rows
                Dim uploadID As Integer = CType(row("UploadID"), Integer)
                Dim imageData As Byte() = CType(row("ImageData"), Byte())
                Dim image As Bitmap = ByteArrayToImage(imageData)
                Dim caption As String = row("Caption").ToString()
                Dim uploadDate As DateTime = CType(row("UploadDate"), DateTime)
                Dim username As String = row("Username").ToString()
                AddImageToGallery(uploadID, image, caption, uploadDate, username)
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading images: " & ex.Message)
        End Try
    End Sub

    Private Function ByteArrayToImage(byteArray As Byte()) As Bitmap
        Using ms As New MemoryStream(byteArray)
            Return New Bitmap(ms)
        End Using
    End Function

    Private Sub AddImageToGallery(uploadID As Integer, image As Bitmap, caption As String, uploadDate As DateTime, username As String)
        lblusername.Text = username
        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.None
        panel.Size = New Size(461, 515)
        panel.Margin = New Padding(0, 5, 0, 0)
        panel.Dock = DockStyle.Top
        panel.Tag = uploadID ' Store the UploadID in the panel's Tag property

        Dim lblDate As New Label()
        lblDate.Text = uploadDate.ToString("MMM dd, yyyy") ' Format the date as "Jun 16, 2020"
        lblDate.AutoSize = True
        lblDate.TextAlign = ContentAlignment.MiddleLeft
        lblDate.Dock = DockStyle.Top
        lblDate.ForeColor = Color.Black

        Dim pictureBox As New PictureBox()
        pictureBox.Image = image
        pictureBox.Dock = DockStyle.Top
        pictureBox.Width = 461 'adjust width to fit within the panel with some margin
        pictureBox.Height = CInt((image.Height / image.Width) * pictureBox.Width) ' Adjust height based on image aspect ratio
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox.Dock = DockStyle.Top

        Dim lblCaption As New Label()
        lblCaption.Text = caption
        lblCaption.AutoSize = True
        lblCaption.TextAlign = ContentAlignment.MiddleLeft
        lblCaption.Dock = DockStyle.Top
        lblCaption.ForeColor = Color.Black

        panel.Controls.Add(lblCaption)
        panel.Controls.Add(pictureBox)
        panel.Controls.Add(lblDate)
        panel.Height = pictureBox.Height + lblDate.Height + lblCaption.Height + panel.Padding.Top + panel.Padding.Bottom

        ' Add the context menu

        Dim contextMenu As New ContextMenuStrip()
            AddHandler contextMenu.Opening, AddressOf ContextMenu_Opening

            Dim editMenuItem As New ToolStripMenuItem("Edit")
            AddHandler editMenuItem.Click, AddressOf EditMenuItem_Click
            contextMenu.Items.Add(editMenuItem)

            Dim deleteMenuItem As New ToolStripMenuItem("Delete")
            AddHandler deleteMenuItem.Click, AddressOf DeleteMenuItem_Click
            contextMenu.Items.Add(deleteMenuItem)

        If homecheck = False Then

            panel.ContextMenuStrip = contextMenu
        End If
        FlowLayoutPanel1.Controls.Add(panel)
    End Sub

    Private Sub ContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        ' Optionally add logic here if needed before the context menu opens
    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim contextMenu As ContextMenuStrip = CType(menuItem.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(contextMenu.SourceControl, Panel)
        Dim uploadID As Integer = CType(panel.Tag, Integer)
        db.AddParam("@UploadID", uploadID)
        db.ExecQuery("SELECT ImageData FROM UserUploads WHERE UploadID = @UploadID")

        For Each row As DataRow In db.DBDT.Rows
            Dim imageData As Byte() = CType(row("ImageData"), Byte())
            Imageedit = ByteArrayToImage(imageData)
        Next
        Form3.btnedit.PerformClick()


    End Sub

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs)
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim contextMenu As ContextMenuStrip = CType(menuItem.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(contextMenu.SourceControl, Panel)
        Dim uploadID As Integer = CType(panel.Tag, Integer)

        Try
            db.AddParam("@UploadID", uploadID)
            db.ExecQuery("DELETE FROM UserUploads WHERE UploadID = @UploadID")

            If db.HasException(True) Then Exit Sub

            FlowLayoutPanel1.Controls.Remove(panel)
            panel.Dispose()
            MessageBox.Show("Image deleted.")
        Catch ex As Exception
            MessageBox.Show("Error deleting image: " & ex.Message)
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
