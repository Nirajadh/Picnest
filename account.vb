Imports System.Drawing.Imaging
Imports System.IO

Public Class account
    Inherits UserControl
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

        For Each row As DataRow In db.DBDT.Rows
            Fname = row("Name").ToString()
            Dim imagedata As Byte() = CType(row("ProfilePic"), Byte())
            profileimage = ByteArrayToImage(imagedata)
            pass = row("Password").ToString()
            Username = row("Username").ToString()
        Next

        lblName.Text = Fname
        lblusername.Text = Username
        Guna2PictureBox1.Image = profileimage
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
        Dim query As String = "DELETE FROM Users WHERE UserID=@UserID"

        ' Add parameters to the query
        db.AddParam("@UserID", userid)

        ' Execute the query
        db.ExecQuery(query)

        ' Check for exceptions
        If db.HasException(True) Then Exit Sub

        ' Provide feedback to the user
        MsgBox("User Deleted")
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form3.Hide()
        Form1.Show()
    End Sub

    Private Sub Guna2Panel1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Panel1.MouseHover
        btneditname.Visible = True
    End Sub

    Private Sub btneditname_MouseLeave(sender As Object, e As EventArgs) Handles btneditname.MouseLeave
        btneditname.Visible = False
    End Sub

    Private Sub btneditname_Click(sender As Object, e As EventArgs) Handles btneditname.Click
        txtnewname.Visible = True
        lblName.Visible = False
        txtnewname.BringToFront()
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
End Class
