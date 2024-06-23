Imports System.Drawing.Imaging
Imports System.IO

Public Class acc

    Dim profileimage As Bitmap
    Dim Fname As String
    Dim Username As String
    Dim useruploads As Integer
    Dim pass As String
    Dim db As New sqlcontrol
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Guna2PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles Guna2PictureBox1.DoubleClick
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            profileimage = CType(Image.FromFile(OpenFileDialog1.FileName), Bitmap)
            Guna2PictureBox1.Image = profileimage.Clone()
            Form3.accountbtn.Image = profileimage.Clone()
            ' Convert image to byte array
            Dim imageData As Byte() = ImageToByteArray(profileimage)

            ' Add parameters to the query
            db.AddParam("@ProfilePic", imageData)
            db.AddParam("@UserID", userid)

            ' Execute the query
            db.ExecQuery("UPDATE Users SET ProfilePic=@ProfilePic WHERE UserID=@UserID")

            ' Check for exceptions
            If db.HasException(True) Then Exit Sub
        End If
    End Sub

    Private Sub account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.AddParam("@UserID", userid)
        db.ExecQuery("SELECT Name, Username, Password, ProfilePic FROM Users WHERE UserID=@UserID")

        If db.RecordCount > 0 Then
            Dim row As DataRow = db.DBDT.Rows(0)
            Fname = row("Name").ToString()
            pass = row("Password").ToString()
            Username = row("Username").ToString()

            ' Check if ProfilePic field is NULL
            If Not IsDBNull(row("ProfilePic")) Then
                Dim imagedata As Byte() = CType(row("ProfilePic"), Byte())
                profileimage = ByteArrayToImage(imagedata)
                Guna2PictureBox1.Image = profileimage.Clone()

            Else
                ' Handle the case where ProfilePic is NULL (no image)
                ' Optionally, you can set a default image or leave it blank
                Guna2PictureBox1.Image = My.Resources.defaultProfile ' Set to blank or default image
            End If
        Else
            ' Handle the case where no record is found for the UserID
            MessageBox.Show("User not found.")
        End If

        lblName.Text = Fname
        lblusername.Text = Username
    End Sub


    Private Function ByteArrayToImage(byteArray As Byte()) As Bitmap
        Using ms As New MemoryStream(byteArray)
            Return New Bitmap(ms)
        End Using
    End Function

    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Define the query to delete the user

        db.AddParam("@Username", Username)
        Dim query As String = "DELETE FROM Users WHERE Username=@Username"

        ' Add parameters to the query


        ' Execute the query
        db.ExecQuery(query)

        ' Check for exceptions
        If db.HasException(True) Then Exit Sub

        ' Provide feedback to the user
        MsgBox("User Deleted")
        Me.Hide()
        Form3.Hide()
        Form1.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form3.Dispose()
        Form3.Hide()
        Me.Dispose()
        Me.Hide()
        Form1.Show()
    End Sub






    Private Sub btneditname_Click(sender As Object, e As EventArgs) Handles btneditname.Click
        lblName.Hide()
        txtnewname.Visible = True
        txtnewname.BringToFront()
        txtnewname.Focus()
    End Sub

    Private Sub txtnewname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnewname.KeyDown
        If e.KeyCode = Keys.Enter Then
            db.AddParam("@UserID", userid)
            db.AddParam("@Name", txtnewname.Text)
            db.ExecQuery("UPDATE Users SET Name=@Name WHERE UserID=@UserID")

            ' Check for exceptions
            If db.HasException(True) Then Exit Sub

            lblName.Text = txtnewname.Text
            txtnewname.Visible = False

            lblName.Visible = True
        End If
    End Sub



    Private Sub acc_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        txtnewname.Visible = False

        lblName.Visible = True
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs)
        Form3.accountbtn.Tag = False


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        db.AddParam("@UserID", userid)

        ' Execute the query
        db.ExecQuery("UPDATE Users SET ProfilePic=NULL WHERE UserID=@UserID")
        Guna2PictureBox1.Image = My.Resources.defaultProfile
        Form3.accountbtn.Image = My.Resources.defaultProfile
        ' Check for exceptions
        If db.HasException(True) Then Exit Sub
    End Sub
End Class
