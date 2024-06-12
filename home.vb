Imports System.Transactions

Public Class Home
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Private db As New sqlcontrol

    Private Sub LoadUserDetails(username As String)
        Try
            db.AddParam("@Username", username)
            db.ExecQuery("SELECT UserID FROM Users WHERE Username = @Username")

            If db.HasException(True) OrElse db.DBDT.Rows.Count = 0 Then
                lblusernotfound.Visible = True
                Return
            End If

            Dim userIds As Integer = Convert.ToInt32(db.DBDT.Rows(0)("UserID"))
            MsgBox(userIds)
            Dim gallery As New gallery1(userIds)
            Me.Controls.Clear()
            Me.Controls.Add(gallery)
            gallery.Dock = DockStyle.Fill
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message)
        End Try
    End Sub



    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown
        lblusernotfound.Visible = False
        If e.KeyCode = Keys.Enter Then


            Dim username = Guna2TextBox1.Text
            If String.IsNullOrWhiteSpace(username) Then
                MessageBox.Show("Please enter a username.")

                Return
            End If
            LoadUserDetails(username)
        End If
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class
