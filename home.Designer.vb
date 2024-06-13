<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        lblusernotfound = New Label()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.White
        Guna2CustomGradientPanel1.BorderRadius = 10
        Guna2CustomGradientPanel1.Controls.Add(lblusernotfound)
        Guna2CustomGradientPanel1.Controls.Add(Guna2TextBox1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel1.Dock = DockStyle.Fill
        Guna2CustomGradientPanel1.FillColor = SystemColors.GradientInactiveCaption
        Guna2CustomGradientPanel1.FillColor2 = SystemColors.Highlight
        Guna2CustomGradientPanel1.FillColor4 = SystemColors.GradientActiveCaption
        Guna2CustomGradientPanel1.ForeColor = Color.Transparent
        Guna2CustomGradientPanel1.Location = New Point(0, 0)
        Guna2CustomGradientPanel1.Margin = New Padding(30, 3, 3, 3)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel1.Size = New Size(1045, 654)
        Guna2CustomGradientPanel1.TabIndex = 2
        ' 
        ' lblusernotfound
        ' 
        lblusernotfound.Anchor = AnchorStyles.None
        lblusernotfound.AutoSize = True
        lblusernotfound.BackColor = Color.Transparent
        lblusernotfound.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblusernotfound.ForeColor = Color.White
        lblusernotfound.Location = New Point(451, 367)
        lblusernotfound.Name = "lblusernotfound"
        lblusernotfound.Size = New Size(143, 28)
        lblusernotfound.TabIndex = 17
        lblusernotfound.Text = "User not found"
        lblusernotfound.Visible = False
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2TextBox1.BorderColor = SystemColors.InactiveCaption
        Guna2TextBox1.BorderRadius = 25
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.IconLeft = My.Resources.Resources.icons8_search_50
        Guna2TextBox1.IconLeftOffset = New Point(10, 0)
        Guna2TextBox1.IconLeftSize = New Size(30, 30)
        Guna2TextBox1.Location = New Point(301, 291)
        Guna2TextBox1.Margin = New Padding(4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.Black
        Guna2TextBox1.PlaceholderText = "Username"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(442, 72)
        Guna2TextBox1.TabIndex = 0
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2CustomGradientPanel1)
        Name = "Home"
        Size = New Size(1045, 654)
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblusernotfound As Label

End Class
