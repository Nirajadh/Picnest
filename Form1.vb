Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim sin As New signin()
        Guna2Panel2.Controls.Add(sin)
        sin.Dock = DockStyle.Fill
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sin As New signin()
        Guna2Panel2.Controls.Add(sin)
        sin.Dock = DockStyle.Fill
    End Sub
End Class
