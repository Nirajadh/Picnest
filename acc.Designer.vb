<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acc))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btndelete = New Guna.UI2.WinForms.Guna2Button()
        lblusername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        txtnewname = New Guna.UI2.WinForms.Guna2TextBox()
        btneditname = New Guna.UI2.WinForms.Guna2Button()
        lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Panel1.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btndelete
        ' 
        btndelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btndelete.AnimatedGIF = True
        btndelete.BackColor = Color.Transparent
        btndelete.BorderColor = Color.White
        btndelete.BorderRadius = 20
        btndelete.BorderThickness = 1
        btndelete.CustomImages.Image = CType(resources.GetObject("resource.Image"), Image)
        btndelete.CustomImages.ImageAlign = HorizontalAlignment.Center
        btndelete.CustomImages.ImageOffset = New Point(0, -8)
        btndelete.CustomImages.ImageSize = New Size(40, 40)
        btndelete.CustomizableEdges = CustomizableEdges1
        btndelete.DisabledState.BorderColor = Color.DarkGray
        btndelete.DisabledState.CustomBorderColor = Color.DarkGray
        btndelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btndelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btndelete.FillColor = Color.Transparent
        btndelete.Font = New Font("Segoe UI", 9F)
        btndelete.ForeColor = Color.White
        btndelete.HoverState.BorderColor = Color.Black
        btndelete.HoverState.FillColor = Color.White
        btndelete.Location = New Point(324, 143)
        btndelete.Name = "btndelete"
        btndelete.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btndelete.Size = New Size(39, 40)
        btndelete.TabIndex = 17
        ' 
        ' lblusername
        ' 
        lblusername.BackColor = Color.Black
        lblusername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblusername.ForeColor = Color.White
        lblusername.Location = New Point(117, 64)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(140, 25)
        lblusername.TabIndex = 14
        lblusername.Text = "Guna2HtmlLabel2"
        lblusername.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.Controls.Add(txtnewname)
        Guna2Panel1.Controls.Add(btneditname)
        Guna2Panel1.Controls.Add(lblName)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Location = New Point(117, 12)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(249, 49)
        Guna2Panel1.TabIndex = 15
        ' 
        ' txtnewname
        ' 
        txtnewname.CustomizableEdges = CustomizableEdges3
        txtnewname.DefaultText = ""
        txtnewname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtnewname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtnewname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtnewname.ForeColor = Color.Black
        txtnewname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewname.Location = New Point(0, 10)
        txtnewname.Margin = New Padding(4, 5, 4, 5)
        txtnewname.Name = "txtnewname"
        txtnewname.PasswordChar = ChrW(0)
        txtnewname.PlaceholderText = ""
        txtnewname.SelectedText = ""
        txtnewname.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtnewname.Size = New Size(208, 39)
        txtnewname.TabIndex = 18
        txtnewname.Visible = False
        ' 
        ' btneditname
        ' 
        btneditname.AnimatedGIF = True
        btneditname.BackColor = Color.Transparent
        btneditname.BorderColor = SystemColors.ActiveCaptionText
        btneditname.BorderThickness = 1
        btneditname.CustomImages.Image = CType(resources.GetObject("resource.Image1"), Image)
        btneditname.CustomImages.ImageAlign = HorizontalAlignment.Center
        btneditname.CustomImages.ImageOffset = New Point(0, -2)
        btneditname.CustomImages.ImageSize = New Size(26, 26)
        btneditname.CustomizableEdges = CustomizableEdges5
        btneditname.DisabledState.BorderColor = Color.DarkGray
        btneditname.DisabledState.CustomBorderColor = Color.DarkGray
        btneditname.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btneditname.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btneditname.FillColor = Color.Transparent
        btneditname.Font = New Font("Segoe UI", 9F)
        btneditname.ForeColor = Color.Transparent
        btneditname.HoverState.BorderColor = Color.Black
        btneditname.HoverState.FillColor = Color.White
        btneditname.IndicateFocus = True
        btneditname.Location = New Point(210, 13)
        btneditname.Name = "btneditname"
        btneditname.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btneditname.Size = New Size(36, 36)
        btneditname.TabIndex = 0
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Black
        lblName.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.White
        lblName.Location = New Point(0, 13)
        lblName.Name = "lblName"
        lblName.Size = New Size(191, 33)
        lblName.TabIndex = 1
        lblName.Text = "Guna2HtmlLabel1"
        lblName.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' btnlogout
        ' 
        btnlogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnlogout.AnimatedGIF = True
        btnlogout.BackColor = Color.Transparent
        btnlogout.BorderColor = Color.White
        btnlogout.BorderRadius = 20
        btnlogout.BorderThickness = 1
        btnlogout.CustomImages.HoveredImage = CType(resources.GetObject("resource.HoveredImage"), Image)
        btnlogout.CustomImages.Image = CType(resources.GetObject("resource.Image2"), Image)
        btnlogout.CustomImages.ImageAlign = HorizontalAlignment.Center
        btnlogout.CustomImages.ImageOffset = New Point(0, -2)
        btnlogout.CustomImages.ImageSize = New Size(26, 26)
        btnlogout.CustomizableEdges = CustomizableEdges9
        btnlogout.DisabledState.BorderColor = Color.DarkGray
        btnlogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogout.FillColor = Color.Transparent
        btnlogout.Font = New Font("Segoe UI", 9F)
        btnlogout.ForeColor = Color.White
        btnlogout.HoverState.BorderColor = Color.Black
        btnlogout.HoverState.FillColor = Color.White
        btnlogout.Location = New Point(24, 143)
        btnlogout.Name = "btnlogout"
        btnlogout.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnlogout.Size = New Size(40, 40)
        btnlogout.TabIndex = 16
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.AutoRoundedCorners = True
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.BorderRadius = 49
        Guna2PictureBox1.ContextMenuStrip = Guna2ContextMenuStrip1
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.InitialImage = CType(resources.GetObject("Guna2PictureBox1.InitialImage"), Image)
        Guna2PictureBox1.Location = New Point(11, 10)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2PictureBox1.Size = New Size(100, 100)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 13
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2ContextMenuStrip1
        ' 
        Guna2ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        Guna2ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Guna2ContextMenuStrip1.RenderStyle.ArrowColor = SystemColors.Highlight
        Guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = SystemColors.Highlight
        Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        Guna2ContextMenuStrip1.Size = New Size(211, 54)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Padding = New Padding(0)
        ToolStripMenuItem1.Size = New Size(210, 22)
        ToolStripMenuItem1.Text = "Remove"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        ' 
        ' acc
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(382, 195)
        Controls.Add(btndelete)
        Controls.Add(lblusername)
        Controls.Add(Guna2Panel1)
        Controls.Add(btnlogout)
        Controls.Add(Guna2PictureBox1)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(480, 650)
        Name = "acc"
        StartPosition = FormStartPosition.Manual
        Text = "acc"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblusername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btneditname As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtnewname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
