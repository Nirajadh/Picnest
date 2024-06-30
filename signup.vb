
Public Class signup
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
        btncreate.Text = "Create"
    End Sub
    Private db As New sqlcontrol()
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles supPasstoggle.Click
        If supPasstoggle.Checked = True Then
            txtpassword.PasswordChar = "*"
        Else
            txtpassword.PasswordChar = ""
        End If

    End Sub



    Private Sub signinlabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signinlabel.LinkClicked
        Dim sin As New signin()
        Me.Controls.Clear()
        Me.Controls.Add(sin)
        sin.Dock = DockStyle.Fill

    End Sub



    Private Async Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btncreate.Click




        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim name As String = txtname.Text

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Or String.IsNullOrWhiteSpace(name) Then
            If String.IsNullOrWhiteSpace(username) Then
                txtusername.PlaceholderText = "Enter Username"

            End If
            If String.IsNullOrWhiteSpace(password) Then
                txtpassword.PlaceholderText = "Enter Password"

            End If
            If String.IsNullOrWhiteSpace(name) Then
                txtname.PlaceholderText = "Enter Name"

            End If
            Return
        End If


        Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
        db.AddParam("@Username", username)
        db.ExecQuery(checkQuery)


        If db.HasException(True) Then Return


        If db.DBDT.Rows.Count > 0 AndAlso Convert.ToInt32(db.DBDT.Rows(0)(0)) > 0 Then
            txtusername.Clear()
            txtusername.PlaceholderText = "Username already taken"
            Return
        End If


        Dim insertQuery As String = "INSERT INTO Users (Name,Username, Password) VALUES (@Name,@Username, @Password)"
        db.AddParam("@Name", name)
        db.AddParam("@Username", username)
        db.AddParam("@Password", password)


        db.ExecQuery(insertQuery)


        If db.HasException(True) Then Return



        btncreate.Text = " "
        btncreate.Text = "Created"
        Await Task.Delay(2000)
        Dim sin As New signin()
        Me.Controls.Clear()
        Me.Controls.Add(sin)
        sin.Dock = DockStyle.Fill





        txtusername.Clear()
        txtpassword.Clear()
    End Sub
    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtusername.Focus()
        End If
    End Sub
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            btncreate.PerformClick()
        End If
    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class
