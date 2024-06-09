Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1


    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                ControlStyles.UserPaint Or
                ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
    Private db As New sqlcontrol()


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles sinpasstoggle.Click
        If sinpasstoggle.Checked = True Then
            passwordtxt.PasswordChar = "*"
        Else
            passwordtxt.PasswordChar = ""
        End If



    End Sub

    Private Sub createacclabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles createacclabel.LinkClicked
        usernametxt.Clear()
        passwordtxt.Clear()
        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub continuebtn_Click(sender As Object, e As EventArgs) Handles continuebtn.Click
        Dim username As String = usernametxt.Text
        Dim password As String = passwordtxt.Text

        ' Define the query to check the username and password
        Dim query As String = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password"

        ' Add parameters to the query
        db.AddParam("@Username", username)
        db.AddParam("@Password", password)

        ' Execute the query
        db.ExecQuery(query)

        ' Check for exceptions
        If db.HasException(True) Then Exit Sub

        ' Check if the user exists
        If db.DBDT.Rows.Count > 0 Then
            GlobalVariables.userid = Convert.ToInt32(db.DBDT.Rows(0)("UserID"))
            MessageBox.Show("Sign in successful")



            ' Proceed to the next step or open the main form of your application
        Else
            lblincorrect.Visible = True
            usernametxt.Clear()
            passwordtxt.Clear()
            usernametxt.Focus()

        End If



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub usernametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles usernametxt.KeyDown
        If e.KeyCode = Keys.Enter Then

            passwordtxt.Focus()
        End If


        lblincorrect.Visible = False

    End Sub

    Private Sub passwordtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordtxt.KeyDown
        If e.KeyCode = Keys.Enter Then

            continuebtn.PerformClick()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
