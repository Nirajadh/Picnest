Imports System.Transactions
Imports Guna.UI2.WinForms

Public Class Home
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub










    Private Async Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await Task.Delay(5000)
        Form1.Guna2ControlBox1.Show()
        Form1.Guna2ControlBox2.Show()
        Dim sin As New signin()

        Me.Controls.Clear()
        Me.Controls.Add(sin)




        sin.Dock = DockStyle.Fill
    End Sub


End Class
