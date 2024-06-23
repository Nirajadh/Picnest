Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports Guna.UI2.WinForms
Imports System.Security.Cryptography.Pkcs

Imports System.Threading.Tasks
Public Class Gallery1
    Inherits UserControl
    Dim cuid As Integer
    Private likeContextMenu As ContextMenuStrip

    Private db As New sqlcontrol()

    Public Sub New()
        InitializeComponent()

        If homecheck = True Then
            searchpanel.Visible = True
            FlowLayoutPanel1.Focus()
        Else
            searchpanel.Visible = False
        End If
        LoadUserImages()
    End Sub

    Private Sub LoadUserImages()
        Try
            If homecheck = True Then
                If searchuserid = 0 Then
                    If Followers = True Then
                        db.AddParam("@UserID", userid)
                        db.ExecQuery("SELECT UploadID, ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = UserUploads.UserID)  AS Username FROM UserUploads where UserID <> @UserID AND UserID IN (SELECT User2ID FROM Followed WHERE User1ID = @UserID) ORDER BY UploadID DESC")
                        Followers = False
                    Else

                        db.AddParam("@UserID", userid)
                        db.ExecQuery("SELECT UploadID, ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = UserUploads.UserID)  AS Username FROM UserUploads where UserID <> @UserID ORDER BY UploadID DESC")
                    End If
                Else
                    db.AddParam("@UserID", searchuserid)

                    db.ExecQuery("SELECT UploadID, ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = @UserID) AS Username FROM UserUploads WHERE UserID = @UserID")
                End If

            Else
                db.AddParam("@UserID", userid)
                db.ExecQuery("SELECT UploadID, ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = @UserID) AS Username FROM UserUploads WHERE UserID = @UserID")

            End If
            If db.HasException(True) Then Exit Sub

            For Each row As DataRow In db.DBDT.Rows
                Dim uploadID As Integer = CType(row("UploadID"), Integer)
                Dim imageData As Byte() = CType(row("ImageData"), Byte())
                Dim image As Bitmap = ByteArrayToImage(imageData)
                Dim caption As String = row("Caption").ToString()
                Dim uploadDate As DateTime = CType(row("UploadDate"), DateTime)
                Dim username As String = row("Username").ToString()

                db.AddParam("@UploadID", uploadID)
                db.AddParam("@UserID", userid)
                db.ExecQuery("SELECT COUNT(*) FROM Liked WHERE UserID = @UserID AND UploadID = @UploadID")
                Dim alreadyLiked As Boolean = (CInt(db.DBDT.Rows(0).Item(0)) > 0)

                AddImageToGallery(uploadID, image, caption, uploadDate, username, alreadyLiked)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading i images: " & ex.Message)

        End Try

    End Sub

    Private Function ByteArrayToImage(byteArray As Byte()) As Bitmap
        Using ms As New MemoryStream(byteArray)
            Return New Bitmap(ms)
        End Using
    End Function

    Private Sub AddImageToGallery(uploadID As Integer, image As Bitmap, caption As String, uploadDate As DateTime, username As String, alreadyLiked As Boolean)
        If homecheck = True Then
            If searchuserid = 0 Then
                usernamepanel.Visible = False
            Else
                db.AddParam("@User1ID", userid)
                db.AddParam("@User2ID", searchuserid)
                db.ExecQuery("SELECT COUNT(*) FROM Followed WHERE User1ID = @User1ID AND User2ID = @User2ID")
                If (CInt(db.DBDT.Rows(0).Item(0)) > 0) Then
                    followBtn.Checked = True
                End If
                usernamepanel.Visible = True
                lblusername.Text = username
            End If


        Else
            usernamepanel.Visible = True
            lblusername.Text = username
            followBtn.Visible = False
        End If

        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.None
        panel.Size = New Size(461, 515)
        panel.Margin = New Padding(0, 5, 0, 0)
        panel.Dock = DockStyle.Top
        panel.Tag = uploadID ' Store the UploadID in the panel's Tag property

        Dim lbluname As New Label()
        lbluname.Text = username
        lbluname.TextAlign = ContentAlignment.MiddleLeft
        lbluname.Dock = DockStyle.Top
        lbluname.ForeColor = Color.Black
        lbluname.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Dim lblDate As New Label()
        lblDate.Text = uploadDate.ToString("MMM dd, yyyy") ' Format the date as "Jun 16, 2020"
        lblDate.AutoSize = True
        lblDate.TextAlign = ContentAlignment.MiddleLeft
        lblDate.Dock = DockStyle.Top
        lblDate.ForeColor = Color.Black

        Dim pictureBox As New PictureBox()
        AddHandler pictureBox.MouseClick, AddressOf PictureBox1_click
        pictureBox.Image = image
        pictureBox.Dock = DockStyle.Top
        pictureBox.Width = 461 ' Adjust width to fit within the panel with some margin
        pictureBox.Height = CInt((image.Height / image.Width) * pictureBox.Width) ' Adjust height based on image aspect ratio
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox.Dock = DockStyle.Top

        Dim lblCaption As New Label()
        lblCaption.Text = caption
        lblCaption.AutoSize = True
        lblCaption.TextAlign = ContentAlignment.MiddleLeft
        lblCaption.Dock = DockStyle.Top
        lblCaption.ForeColor = Color.Black

        Dim likepanel As New Panel()
        likepanel.BorderStyle = BorderStyle.None
        likepanel.Size = New Size(40, 45)
        likepanel.Dock = DockStyle.Top
        likepanel.Padding = New Padding(5, 5, 0, 0)

        Dim likebtn As New Guna2Button()
        AddHandler likebtn.Click, AddressOf likebtn_click
        AddHandler likebtn.MouseHover, AddressOf likebtn_MouseHover
        AddHandler likebtn.MouseLeave, AddressOf likebtn_MouseLeave
        likebtn.BackColor = Color.Transparent
        likebtn.FillColor = Color.Transparent
        likebtn.PressedColor = Color.Transparent
        likebtn.PressedDepth = 0
        likebtn.Tag = uploadID
        likebtn.CustomImages.Image = My.Resources.likee
        likebtn.CustomImages.ImageAlign = HorizontalAlignment.Center
        likebtn.CustomImages.ImageSize = New Size(35, 35)
        likebtn.ImageSize = New Size(40, 40)
        likebtn.UseTransparentBackground = True
        likebtn.ImageAlign = HorizontalAlignment.Center
        likebtn.HoverState.Image = My.Resources.liked
        likebtn.HoverState.FillColor = Color.Transparent
        likebtn.CustomImages.CheckedImage = My.Resources.liked
        likebtn.ButtonMode = Enums.ButtonMode.ToogleButton

        likebtn.CheckedState.FillColor = Color.Transparent

        If alreadyLiked Then
            likebtn.Checked = True
        End If
        likebtn.Dock = DockStyle.Left
        likebtn.Size = New Size(40, 40)

        Dim commentbtn As New Guna2Button()
        AddHandler commentbtn.Click, AddressOf commentbtn_click
        commentbtn.BackColor = Color.Transparent
        commentbtn.FillColor = Color.Transparent
        commentbtn.PressedColor = Color.Transparent
        commentbtn.PressedDepth = 0
        commentbtn.Tag = uploadID
        commentbtn.CustomImages.Image = My.Resources.commentclicked
        commentbtn.CustomImages.ImageAlign = HorizontalAlignment.Center
        commentbtn.CustomImages.ImageSize = New Size(28, 28)
        commentbtn.CustomImages.ImageOffset = New Size(0, -5)
        commentbtn.UseTransparentBackground = True

        commentbtn.HoverState.FillColor = Color.Transparent


        commentbtn.CheckedState.FillColor = Color.Transparent
        commentbtn.Dock = DockStyle.Left
        commentbtn.Size = New Size(35, 35)



        panel.Controls.Add(lblCaption)
        panel.Controls.Add(likepanel)
        likepanel.Controls.Add(commentbtn)
        likepanel.Controls.Add(likebtn)

        panel.Controls.Add(pictureBox)
        panel.Controls.Add(lblDate)
        If homecheck = True And searchuserid = 0 Then
            panel.Controls.Add(lbluname)
        End If

        panel.Height = pictureBox.Height + lblDate.Height + lbluname.Height + lblCaption.Height + likebtn.Height + panel.Padding.Top + panel.Padding.Bottom + 5

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

    Private Sub PictureBox1_click(sender As Object, e As EventArgs)
        Panel1.Visible = False
        FlowLayoutPanel1.Visible = False
        FlowLayoutPanel1.Location = New Size(281, 7)
        FlowLayoutPanel1.Visible = True
    End Sub

    Private Sub ContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        ' Optionally add logic here if needed before the context menu opens
    End Sub

    Private Sub likebtn_click(sender As Object, e As EventArgs)
        Dim likebtn As Guna2Button = CType(sender, Guna2Button)
        Dim uploadID As Integer = CType(likebtn.Tag, Integer)

        Try
            db.AddParam("@UploadID", uploadID)


            If likebtn.Checked = True Then
                db.ExecQuery("UPDATE UserUploads SET Likes = Likes + 1 WHERE UploadId = @UploadID")
                db.AddParam("@UploadID", uploadID)
                db.AddParam("@UserID", userid)
                db.ExecQuery("INSERT INTO Liked (UserID, UploadID) VALUES (@UserID, @UploadID)")
            ElseIf likebtn.Checked = False Then





                db.ExecQuery("UPDATE UserUploads SET Likes = Likes - 1 WHERE UploadId = @UploadID")
                db.AddParam("@UploadID", uploadID)
                db.AddParam("@UserID", userid)
                db.ExecQuery("DELETE FROM Liked WHERE UserID = @UserID AND UploadID = @UploadID")
            End If

            If db.HasException(True) Then Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error updating likes: " & ex.Message)
        End Try
    End Sub
    Private Sub commentbtn_click(sender As Object, e As EventArgs)

        If Panel1.Visible = True Then
            Panel1.Visible = False

            FlowLayoutPanel1.Location = New Size(281, 7)


        Else

            FlowLayoutPanel1.Location = New Size(100, 7)


            Panel1.Visible = True
            commentpanel.Controls.Clear()
        End If
        Dim commentbtn As Guna2Button = CType(sender, Guna2Button)
        cuid = CType(commentbtn.Tag, Integer)

        Try
            db.AddParam("@UploadID", cuid)

            db.ExecQuery("SELECT CommentText, CommentDate, (SELECT Username FROM Users WHERE UserID = Comments.UserID)  AS Username FROM Comments where UploadID=@UploadID ")

            If db.HasException(True) Then Exit Sub

            For Each row As DataRow In db.DBDT.Rows


                Dim comment As String = row("CommentText").ToString()
                Dim CommentDate As DateTime = CType(row("CommentDate"), DateTime)
                Dim username As String = row("Username").ToString()


                AddComment(comment, CommentDate, username)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading i images: " & ex.Message)

        End Try


    End Sub
    Private Sub AddComment(comment As String, CommentDate As DateTime, username As String)



        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.None
        panel.Size = New Size(370, 100)
        panel.Margin = New Padding(0, 5, 0, 0)
        panel.Dock = DockStyle.Top

        Dim lbluname As New Label()
        lbluname.Text = username
        lbluname.TextAlign = ContentAlignment.MiddleLeft
        lbluname.Dock = DockStyle.Top
        lbluname.ForeColor = Color.Black
        lbluname.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        Dim lblComment As New Label()
        lblComment.Text = comment
        lblComment.AutoSize = True
        lblComment.TextAlign = ContentAlignment.MiddleLeft
        lblComment.Dock = DockStyle.Top
        lblComment.ForeColor = Color.Black

        Dim lblDate As New Label()
        lblDate.Text = CommentDate.ToString("MMM dd, yyyy") ' Format the date as "Jun 16, 2020"
        lblDate.AutoSize = True
        lblDate.TextAlign = ContentAlignment.MiddleLeft
        lblDate.Dock = DockStyle.Top
        lblDate.ForeColor = Color.Black


        panel.Controls.Add(lblComment)
        panel.Controls.Add(lblDate)
        panel.Controls.Add(lbluname)
        commentpanel.Controls.Add(panel)
        panel.Height = lblDate.Height + lbluname.Height + lblComment.Height + panel.Padding.Top + panel.Padding.Bottom + 5

    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim contextMenu As ContextMenuStrip = CType(menuItem.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(contextMenu.SourceControl, Panel)
        Dim uploadID As Integer = CType(panel.Tag, Integer)

        db.AddParam("@UploadID", uploadID)
        db.ExecQuery("SELECT ImageData FROM UserUploads WHERE UploadID = @UploadID")

        If db.HasException(True) Then Exit Sub

        For Each row As DataRow In db.DBDT.Rows
            Dim imageData As Byte() = CType(row("ImageData"), Byte())
            Imageedit = ByteArrayToImage(imageData)
        Next

        updatecheck = True
        useruploadid = uploadID

        Dim ed As New edit1()
        Me.Controls.Clear()
        Me.Controls.Add(ed)
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

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown
        Guna2TextBox1.PlaceholderText = "Username"
        Guna2TextBox1.PlaceholderForeColor = Color.Gray
        If e.KeyCode = Keys.Enter Then
            Dim username = Guna2TextBox1.Text
            If String.IsNullOrWhiteSpace(username) Then
                MessageBox.Show("Please enter a username.")
                Return
            End If
            LoadUserDetails(username)
        End If
    End Sub

    Private Sub LoadUserDetails(username As String)
        Try
            db.AddParam("@Username", username)
            db.ExecQuery("SELECT UserID FROM Users WHERE Username = @Username")

            If db.HasException(True) OrElse db.DBDT.Rows.Count = 0 Then
                Guna2TextBox1.Text = " "
                Guna2TextBox1.PlaceholderForeColor = Color.Red
                Guna2TextBox1.PlaceholderText = "User not found"



                Return
            End If

            searchuserid = Convert.ToInt32(db.DBDT.Rows(0)("UserID"))
            If searchuserid = userid Then
                searchuserid = 0
            End If
            Dim gallery As New gallery1()
            Me.Controls.Clear()
            Me.Controls.Add(gallery)
            gallery.Dock = DockStyle.Fill
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message)
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseClick
        Panel1.Visible = False
        FlowLayoutPanel1.Location = New Size(281, 7)
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyValue = Keys.Enter Then

            db.AddParam("@UserID", userid)
            db.AddParam("@UploadID", cuid)
            db.AddParam("@CommentDate", DateTime.Now)
            db.AddParam("@CommentText", Guna2TextBox2.Text)
            db.ExecQuery("INSERT INTO Comments (UserID, UploadID,CommentText,CommentDate) VALUES (@UserID, @UploadID,@CommentText,@CommentDate)")

            AddComment(Guna2TextBox2.Text, DateTime.Now, uname)
            Guna2TextBox2.Clear()
            commentpanel.Focus()
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles followBtn.Click
        Try
            db.AddParam("@User1ID", userid)
            db.AddParam("@User2ID", searchuserid)

            If followBtn.Checked = True Then



                db.ExecQuery("INSERT INTO Followed (User1ID, User2ID) VALUES (@User1ID, @User2ID)")
            Else


                'db.AddParam("@User1ID", userid)
                'db.AddParam("@User2ID", searchuserid)

                db.ExecQuery("DELETE FROM Followed WHERE User1ID = @User1ID AND User2ID = @User2ID")
            End If

            If db.HasException(True) Then Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error updating Follow: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Followers = True
        Form3.btnhome.PerformClick()

    End Sub
    Private Sub likebtn_MouseHover(sender As Object, e As EventArgs)
        Dim likebtn As Guna2Button = CType(sender, Guna2Button)
        Dim uploadID As Integer = CType(likebtn.Tag, Integer)

        Try
            db.AddParam("@UploadID", uploadID)
            db.ExecQuery("SELECT Likes FROM UserUploads WHERE UploadID = @UploadID")

            If db.HasException(True) Then Exit Sub

            If db.DBDT.Rows.Count > 0 Then
                Dim likeCount As Integer = CType(db.DBDT.Rows(0)("Likes"), Integer)

                ' Create a context menu
                likeContextMenu = New ContextMenuStrip()

                ' Create a ToolStripMenuItem to display the like count
                Dim likeCountMenuItem As New ToolStripMenuItem("Likes: " & likeCount.ToString())
                likeContextMenu.Items.Add(likeCountMenuItem)

                ' Show the context menu
                likeContextMenu.Show(likebtn, New Point(0, likebtn.Height))
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving like count: " & ex.Message)
        End Try
    End Sub
    Private Sub likebtn_MouseLeave(sender As Object, e As EventArgs)
        If likeContextMenu IsNot Nothing Then
            likeContextMenu.Hide()
        End If
    End Sub

End Class
