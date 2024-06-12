Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Public Class Gallery1
    Inherits UserControl
    Dim userid As Integer
    Private db As New sqlcontrol("Server=NIRAJ;Database=imgdatabase;Integrated Security=True")

    Public Sub New(uid As Integer)
        InitializeComponent()
        userid = uid

        LoadUserImages()
    End Sub

    Private Sub LoadUserImages()
        Try
            db.AddParam("@UserID", userid)
            db.ExecQuery("SELECT ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = @UserID) AS Username FROM UserUploads WHERE UserID = @UserID")

            If db.HasException(True) Then Exit Sub

            For Each row As DataRow In db.DBDT.Rows
                Dim imageData As Byte() = CType(row("ImageData"), Byte())
                Dim image As Bitmap = ByteArrayToImage(imageData)
                Dim caption As String = row("Caption").ToString()
                Dim uploadDate As DateTime = CType(row("UploadDate"), DateTime)
                Dim username As String = row("Username").ToString()
                AddImageToGallery(image, caption, uploadDate, username)
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

    Private Sub AddImageToGallery(image As Bitmap, caption As String, uploadDate As DateTime, username As String)
        lblusername.Text = username
        Dim panel As New Panel()



        panel.BorderStyle = BorderStyle.None


        panel.Size = New Size(461, 515)

        panel.Margin = New Padding(0, 5, 0, 0)
        panel.Dock = DockStyle.Top

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
        FlowLayoutPanel1.Controls.Add(panel)
    End Sub


End Class
