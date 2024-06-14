<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class account
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(account))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblusername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btneditname = New Guna.UI2.WinForms.Guna2Button()
        txtnewname = New Guna.UI2.WinForms.Guna2TextBox()
        btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        btndelete = New Guna.UI2.WinForms.Guna2Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BorderRadius = 50
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.FillColor = Color.BlanchedAlmond
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(127, 17)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(100, 100)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(66, 7)
        lblName.Name = "lblName"
        lblName.Size = New Size(191, 33)
        lblName.TabIndex = 1
        lblName.Text = "Guna2HtmlLabel1"
        ' 
        ' lblusername
        ' 
        lblusername.BackColor = Color.DimGray
        lblusername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblusername.Location = New Point(106, 175)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(140, 25)
        lblusername.TabIndex = 2
        lblusername.Text = "Guna2HtmlLabel2"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = SystemColors.ActiveCaption
        Guna2Panel1.Controls.Add(btneditname)
        Guna2Panel1.Controls.Add(lblName)
        Guna2Panel1.Controls.Add(txtnewname)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Location = New Point(16, 123)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(322, 46)
        Guna2Panel1.TabIndex = 3
        ' 
        ' btneditname
        ' 
        btneditname.AnimatedGIF = True
        btneditname.BackColor = Color.Transparent
        btneditname.BorderColor = Color.White
        btneditname.BorderRadius = 23
        btneditname.BorderThickness = 1
        btneditname.CustomImages.HoveredImage = CType(resources.GetObject("resource.HoveredImage"), Image)
        btneditname.CustomImages.Image = CType(resources.GetObject("resource.Image"), Image)
        btneditname.CustomImages.ImageAlign = HorizontalAlignment.Center
        btneditname.CustomImages.ImageOffset = New Point(0, -2)
        btneditname.CustomImages.ImageSize = New Size(26, 26)
        btneditname.CustomizableEdges = CustomizableEdges3
        btneditname.DisabledState.BorderColor = Color.DarkGray
        btneditname.DisabledState.CustomBorderColor = Color.DarkGray
        btneditname.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btneditname.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btneditname.Dock = DockStyle.Right
        btneditname.FillColor = Color.Black
        btneditname.Font = New Font("Segoe UI", 9F)
        btneditname.ForeColor = Color.White
        btneditname.HoverState.BorderColor = Color.Black
        btneditname.HoverState.FillColor = Color.White
        btneditname.Location = New Point(276, 0)
        btneditname.Name = "btneditname"
        btneditname.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btneditname.Size = New Size(46, 46)
        btneditname.TabIndex = 13
        btneditname.Visible = False
        ' 
        ' txtnewname
        ' 
        txtnewname.BackColor = Color.Transparent
        txtnewname.BorderColor = Color.Transparent
        txtnewname.CustomizableEdges = CustomizableEdges5
        txtnewname.DefaultText = ""
        txtnewname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtnewname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtnewname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewname.FillColor = Color.Transparent
        txtnewname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewname.Font = New Font("Segoe UI", 9F)
        txtnewname.ForeColor = Color.White
        txtnewname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewname.Location = New Point(0, 0)
        txtnewname.Margin = New Padding(3, 4, 3, 4)
        txtnewname.Name = "txtnewname"
        txtnewname.PasswordChar = ChrW(0)
        txtnewname.PlaceholderForeColor = Color.Transparent
        txtnewname.PlaceholderText = ""
        txtnewname.SelectedText = ""
        txtnewname.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtnewname.Size = New Size(270, 46)
        txtnewname.TabIndex = 14
        txtnewname.Visible = False
        ' 
        ' btnlogout
        ' 
        btnlogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnlogout.AnimatedGIF = True
        btnlogout.BackColor = Color.Transparent
        btnlogout.BorderColor = Color.White
        btnlogout.BorderRadius = 20
        btnlogout.BorderThickness = 1
        btnlogout.CustomImages.HoveredImage = CType(resources.GetObject("resource.HoveredImage1"), Image)
        btnlogout.CustomImages.Image = CType(resources.GetObject("resource.Image1"), Image)
        btnlogout.CustomImages.ImageAlign = HorizontalAlignment.Center
        btnlogout.CustomImages.ImageOffset = New Point(0, -2)
        btnlogout.CustomImages.ImageSize = New Size(26, 26)
        btnlogout.CustomizableEdges = CustomizableEdges9
        btnlogout.DisabledState.BorderColor = Color.DarkGray
        btnlogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogout.FillColor = Color.Black
        btnlogout.Font = New Font("Segoe UI", 9F)
        btnlogout.ForeColor = Color.White
        btnlogout.HoverState.BorderColor = Color.Black
        btnlogout.HoverState.FillColor = Color.White
        btnlogout.Location = New Point(16, 353)
        btnlogout.Name = "btnlogout"
        btnlogout.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnlogout.Size = New Size(40, 40)
        btnlogout.TabIndex = 10
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        ' 
        ' btndelete
        ' 
        btndelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btndelete.AnimatedGIF = True
        btndelete.BackColor = Color.Transparent
        btndelete.BorderColor = Color.White
        btndelete.BorderRadius = 20
        btndelete.BorderThickness = 1
        btndelete.CustomImages.HoveredImage = CType(resources.GetObject("resource.HoveredImage2"), Image)
        btndelete.CustomImages.Image = CType(resources.GetObject("resource.Image2"), Image)
        btndelete.CustomImages.ImageAlign = HorizontalAlignment.Center
        btndelete.CustomImages.ImageOffset = New Point(0, -2)
        btndelete.CustomImages.ImageSize = New Size(26, 26)
        btndelete.CustomizableEdges = CustomizableEdges11
        btndelete.DisabledState.BorderColor = Color.DarkGray
        btndelete.DisabledState.CustomBorderColor = Color.DarkGray
        btndelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btndelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btndelete.FillColor = Color.Black
        btndelete.Font = New Font("Segoe UI", 9F)
        btndelete.ForeColor = Color.White
        btndelete.HoverState.BorderColor = Color.Black
        btndelete.HoverState.FillColor = Color.White
        btndelete.Location = New Point(301, 353)
        btndelete.Name = "btndelete"
        btndelete.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btndelete.Size = New Size(40, 40)
        btndelete.TabIndex = 12
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' account
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(btndelete)
        Controls.Add(lblusername)
        Controls.Add(Guna2Panel1)
        Controls.Add(btnlogout)
        Controls.Add(Guna2PictureBox1)
        Name = "account"
        Size = New Size(354, 407)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblusername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btneditname As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtnewname As Guna.UI2.WinForms.Guna2TextBox

End Class
