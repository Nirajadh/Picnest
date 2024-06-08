
Imports System.Data.SqlClient
Public Class Form2



    Private db As New sqlcontrol()
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles supPasstoggle.Click
        If supPasstoggle.Checked = True Then
            txtpassword.PasswordChar = "*"
        Else
            txtpassword.PasswordChar = ""
        End If

    End Sub



    Private Sub signinlabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signinlabel.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btncreate.Click



        ' Get the username and password from the text boxes
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim name As String = txtname.Text
        ' Validate input
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

        ' Check if the username already exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
        db.AddParam("@Username", username)
        db.ExecQuery(checkQuery)

        ' Check for exceptions
        If db.HasException(True) Then Return

        ' If the username already exists, display a message
        If db.DBDT.Rows.Count > 0 AndAlso Convert.ToInt32(db.DBDT.Rows(0)(0)) > 0 Then
            txtusername.Clear()
            txtusername.PlaceholderText = "Username already taken"
            Return
        End If

        ' Define the query to insert the new user
        Dim insertQuery As String = "INSERT INTO Users (Name,Username, Password) VALUES (@Name,@Username, @Password)"
        db.AddParam("@Name", name)
        db.AddParam("@Username", username)
        db.AddParam("@Password", password)

        ' Execute the query
        db.ExecQuery(insertQuery)

        ' Check for exceptions
        If db.HasException(True) Then Return

        ' If the insertion was successful, display a success message
        ' Note: For an INSERT query, RecordCount will not be set, so we should rely on exceptions or other logic
        MsgBox("Sign-up successful!")
        Form1.Show()
        Me.Hide()


        ' Optionally, clear the text boxes after successful sign-up
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
    End Sub


End Class