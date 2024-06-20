<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gallery1
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gallery1))
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Panel1 = New Panel()
        commentpanel = New FlowLayoutPanel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        searchpanel = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        usernamepanel = New Panel()
        followBtn = New Guna.UI2.WinForms.Guna2Button()
        lblusername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Guna2CustomGradientPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        commentpanel.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        searchpanel.SuspendLayout()
        usernamepanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.White
        Guna2CustomGradientPanel1.BorderRadius = 10
        Guna2CustomGradientPanel1.Controls.Add(Panel1)
        Guna2CustomGradientPanel1.Controls.Add(FlowLayoutPanel1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges9
        Guna2Transition1.SetDecoration(Guna2CustomGradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2CustomGradientPanel1.Dock = DockStyle.Fill
        Guna2CustomGradientPanel1.FillColor = SystemColors.ControlLightLight
        Guna2CustomGradientPanel1.FillColor2 = SystemColors.ButtonHighlight
        Guna2CustomGradientPanel1.FillColor3 = SystemColors.Highlight
        Guna2CustomGradientPanel1.FillColor4 = SystemColors.ButtonHighlight
        Guna2CustomGradientPanel1.ForeColor = Color.Transparent
        Guna2CustomGradientPanel1.Location = New Point(0, 0)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2CustomGradientPanel1.Size = New Size(1045, 654)
        Guna2CustomGradientPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(commentpanel)
        Panel1.Controls.Add(Guna2TextBox2)
        Guna2Transition1.SetDecoration(Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Panel1.Location = New Point(600, 93)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(382, 485)
        Panel1.TabIndex = 1
        Panel1.Visible = False
        ' 
        ' commentpanel
        ' 
        commentpanel.AutoScroll = True
        commentpanel.BackColor = Color.White
        commentpanel.Controls.Add(Guna2HtmlLabel1)
        Guna2Transition1.SetDecoration(commentpanel, Guna.UI2.AnimatorNS.DecorationType.None)
        commentpanel.Dock = DockStyle.Fill
        commentpanel.ForeColor = Color.Black
        commentpanel.Location = New Point(0, 0)
        commentpanel.Name = "commentpanel"
        commentpanel.Size = New Size(382, 437)
        commentpanel.TabIndex = 0
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2HtmlLabel1.Dock = DockStyle.Top
        Guna2HtmlLabel1.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(3, 3)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(3, 2)
        Guna2HtmlLabel1.TabIndex = 10
        Guna2HtmlLabel1.Text = Nothing
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.CustomizableEdges = CustomizableEdges1
        Guna2Transition1.SetDecoration(Guna2TextBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.Dock = DockStyle.Bottom
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(0, 437)
        Guna2TextBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TextBox2.PlaceholderText = "Enter Comment"
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox2.Size = New Size(382, 48)
        Guna2TextBox2.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Controls.Add(searchpanel)
        FlowLayoutPanel1.Controls.Add(usernamepanel)
        Guna2Transition1.SetDecoration(FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        FlowLayoutPanel1.ForeColor = Color.White
        FlowLayoutPanel1.Location = New Point(281, 7)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 0, 0, 50)
        FlowLayoutPanel1.Size = New Size(482, 647)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' searchpanel
        ' 
        searchpanel.Controls.Add(Guna2Button1)
        searchpanel.Controls.Add(Guna2TextBox1)
        Guna2Transition1.SetDecoration(searchpanel, Guna.UI2.AnimatorNS.DecorationType.None)
        searchpanel.Dock = DockStyle.Top
        searchpanel.Location = New Point(3, 3)
        searchpanel.Name = "searchpanel"
        searchpanel.Size = New Size(454, 99)
        searchpanel.TabIndex = 2
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 25
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CheckedState.FillColor = Color.White
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Transition1.SetDecoration(Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.HoverState.FillColor = Color.Silver
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageOffset = New Point(0, -3)
        Guna2Button1.ImageSize = New Size(40, 40)
        Guna2Button1.Location = New Point(378, 24)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.PressedColor = Color.Silver
        Guna2Button1.PressedDepth = 50
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(50, 50)
        Guna2Button1.TabIndex = 12
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2TextBox1.BorderColor = SystemColors.InactiveCaption
        Guna2TextBox1.BorderRadius = 25
        Guna2TextBox1.CustomizableEdges = CustomizableEdges5
        Guna2Transition1.SetDecoration(Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Guna2TextBox1.Location = New Point(22, 22)
        Guna2TextBox1.Margin = New Padding(4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.Black
        Guna2TextBox1.PlaceholderText = "Username"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox1.Size = New Size(336, 55)
        Guna2TextBox1.TabIndex = 1
        ' 
        ' usernamepanel
        ' 
        usernamepanel.BackColor = Color.Transparent
        usernamepanel.Controls.Add(followBtn)
        usernamepanel.Controls.Add(lblusername)
        Guna2Transition1.SetDecoration(usernamepanel, Guna.UI2.AnimatorNS.DecorationType.None)
        usernamepanel.Dock = DockStyle.Top
        usernamepanel.Location = New Point(0, 105)
        usernamepanel.Margin = New Padding(0)
        usernamepanel.Name = "usernamepanel"
        usernamepanel.Size = New Size(270, 22)
        usernamepanel.TabIndex = 11
        usernamepanel.Visible = False
        ' 
        ' followBtn
        ' 
        followBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        followBtn.CheckedState.FillColor = Color.White
        followBtn.CheckedState.Image = CType(resources.GetObject("resource.Image"), Image)
        followBtn.CustomizableEdges = CustomizableEdges7
        Guna2Transition1.SetDecoration(followBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        followBtn.DisabledState.BorderColor = Color.DarkGray
        followBtn.DisabledState.CustomBorderColor = Color.DarkGray
        followBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        followBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        followBtn.Dock = DockStyle.Left
        followBtn.FillColor = Color.Transparent
        followBtn.Font = New Font("Segoe UI", 9F)
        followBtn.ForeColor = Color.Black
        followBtn.HoverState.FillColor = Color.White
        followBtn.Image = CType(resources.GetObject("followBtn.Image"), Image)
        followBtn.ImageOffset = New Point(0, -1)
        followBtn.Location = New Point(3, 0)
        followBtn.Name = "followBtn"
        followBtn.PressedDepth = 0
        followBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        followBtn.Size = New Size(30, 22)
        followBtn.TabIndex = 11
        ' 
        ' lblusername
        ' 
        lblusername.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(lblusername, Guna.UI2.AnimatorNS.DecorationType.None)
        lblusername.Dock = DockStyle.Left
        lblusername.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblusername.ForeColor = Color.Black
        lblusername.Location = New Point(0, 0)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(3, 2)
        lblusername.TabIndex = 10
        lblusername.Text = Nothing
        lblusername.TextAlignment = ContentAlignment.MiddleLeft
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 30
        Guna2Elipse1.TargetControl = FlowLayoutPanel1
        ' 
        ' Guna2Transition1
        ' 
        Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), PointF)
        Animation1.LeafCoeff = 0F
        Animation1.MaxTime = 1F
        Animation1.MinTime = 0F
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New Padding(0)
        Animation1.RotateCoeff = 0F
        Animation1.RotateLimit = 0F
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), PointF)
        Animation1.TimeCoeff = 0F
        Animation1.TransparencyCoeff = 0F
        Guna2Transition1.DefaultAnimation = Animation1
        ' 
        ' gallery1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLight
        Controls.Add(Guna2CustomGradientPanel1)
        Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Name = "gallery1"
        Size = New Size(1045, 654)
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        commentpanel.ResumeLayout(False)
        commentpanel.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        searchpanel.ResumeLayout(False)
        usernamepanel.ResumeLayout(False)
        usernamepanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblusername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchpanel As Panel
    Friend WithEvents commentpanel As FlowLayoutPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents usernamepanel As Panel
    Friend WithEvents followBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button

End Class
