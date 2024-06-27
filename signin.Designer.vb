<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signin
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
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signin))
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        progressind = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        lblincorrect = New Label()
        createacclabel = New LinkLabel()
        sinpasstoggle = New Guna.UI2.WinForms.Guna2Button()
        continuebtn = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblsignin = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        passwordtxt = New Guna.UI2.WinForms.Guna2TextBox()
        usernametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderColor = Color.Transparent
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.BorderThickness = 1
        Guna2Panel2.Controls.Add(progressind)
        Guna2Panel2.Controls.Add(lblincorrect)
        Guna2Panel2.Controls.Add(createacclabel)
        Guna2Panel2.Controls.Add(sinpasstoggle)
        Guna2Panel2.Controls.Add(continuebtn)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel5)
        Guna2Panel2.Controls.Add(lblsignin)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel3)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel2.Controls.Add(passwordtxt)
        Guna2Panel2.Controls.Add(usernametxt)
        Guna2Panel2.CustomizableEdges = CustomizableEdges10
        Guna2Transition1.SetDecoration(Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Panel2.Dock = DockStyle.Fill
        Guna2Panel2.FillColor = Color.White
        Guna2Panel2.Location = New Point(0, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        Guna2Panel2.Size = New Size(365, 458)
        Guna2Panel2.TabIndex = 1
        ' 
        ' progressind
        ' 
        progressind.AnimationSpeed = 63
        progressind.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(progressind, Guna.UI2.AnimatorNS.DecorationType.None)
        progressind.Location = New Point(166, 53)
        progressind.Name = "progressind"
        progressind.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        progressind.Size = New Size(50, 50)
        progressind.TabIndex = 17
        progressind.Visible = False
        ' 
        ' lblincorrect
        ' 
        lblincorrect.Anchor = AnchorStyles.None
        lblincorrect.AutoSize = True
        lblincorrect.BackColor = Color.White
        Guna2Transition1.SetDecoration(lblincorrect, Guna.UI2.AnimatorNS.DecorationType.None)
        lblincorrect.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblincorrect.Location = New Point(72, 327)
        lblincorrect.Name = "lblincorrect"
        lblincorrect.Size = New Size(220, 20)
        lblincorrect.TabIndex = 16
        lblincorrect.Text = "Incorrect username or password"
        lblincorrect.Visible = False
        ' 
        ' createacclabel
        ' 
        createacclabel.ActiveLinkColor = SystemColors.Highlight
        createacclabel.AutoSize = True
        createacclabel.BackColor = Color.White
        Guna2Transition1.SetDecoration(createacclabel, Guna.UI2.AnimatorNS.DecorationType.None)
        createacclabel.DisabledLinkColor = SystemColors.Highlight
        createacclabel.Font = New Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        createacclabel.LinkBehavior = LinkBehavior.NeverUnderline
        createacclabel.LinkColor = SystemColors.Highlight
        createacclabel.Location = New Point(94, 110)
        createacclabel.Name = "createacclabel"
        createacclabel.Size = New Size(111, 20)
        createacclabel.TabIndex = 15
        createacclabel.TabStop = True
        createacclabel.Text = "Create account"
        createacclabel.VisitedLinkColor = SystemColors.Highlight
        ' 
        ' sinpasstoggle
        ' 
        sinpasstoggle.BackColor = Color.Transparent
        sinpasstoggle.BorderColor = Color.White
        sinpasstoggle.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        sinpasstoggle.CausesValidation = False
        sinpasstoggle.Checked = True
        sinpasstoggle.CheckedState.BorderColor = Color.White
        sinpasstoggle.CheckedState.CustomBorderColor = Color.White
        sinpasstoggle.CheckedState.FillColor = Color.White
        sinpasstoggle.CheckedState.ForeColor = Color.White
        sinpasstoggle.CustomImages.CheckedImage = CType(resources.GetObject("resource.CheckedImage"), Image)
        sinpasstoggle.CustomImages.ImageAlign = HorizontalAlignment.Center
        sinpasstoggle.CustomImages.ImageSize = New Size(23, 23)
        sinpasstoggle.CustomizableEdges = CustomizableEdges2
        Guna2Transition1.SetDecoration(sinpasstoggle, Guna.UI2.AnimatorNS.DecorationType.None)
        sinpasstoggle.DisabledState.BorderColor = Color.DarkGray
        sinpasstoggle.DisabledState.CustomBorderColor = Color.DarkGray
        sinpasstoggle.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        sinpasstoggle.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        sinpasstoggle.FillColor = Color.White
        sinpasstoggle.Font = New Font("Segoe UI", 9F)
        sinpasstoggle.ForeColor = Color.White
        sinpasstoggle.HoverState.BorderColor = Color.White
        sinpasstoggle.HoverState.CustomBorderColor = Color.White
        sinpasstoggle.HoverState.FillColor = Color.White
        sinpasstoggle.HoverState.ForeColor = Color.White
        sinpasstoggle.Image = CType(resources.GetObject("sinpasstoggle.Image"), Image)
        sinpasstoggle.ImageSize = New Size(23, 23)
        sinpasstoggle.Location = New Point(300, 275)
        sinpasstoggle.Name = "sinpasstoggle"
        sinpasstoggle.PressedColor = Color.White
        sinpasstoggle.PressedDepth = 0
        sinpasstoggle.ShadowDecoration.BorderRadius = 0
        sinpasstoggle.ShadowDecoration.Color = Color.Transparent
        CustomizableEdges3.BottomLeft = False
        CustomizableEdges3.BottomRight = False
        CustomizableEdges3.TopLeft = False
        CustomizableEdges3.TopRight = False
        sinpasstoggle.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        sinpasstoggle.ShadowDecoration.Depth = 0
        sinpasstoggle.ShadowDecoration.Shadow = New Padding(0)
        sinpasstoggle.Size = New Size(30, 30)
        sinpasstoggle.TabIndex = 10
        sinpasstoggle.UseTransparentBackground = True
        ' 
        ' continuebtn
        ' 
        continuebtn.BackColor = SystemColors.Window
        continuebtn.BorderColor = Color.Transparent
        continuebtn.BorderRadius = 20
        continuebtn.BorderThickness = 1
        continuebtn.CustomizableEdges = CustomizableEdges4
        Guna2Transition1.SetDecoration(continuebtn, Guna.UI2.AnimatorNS.DecorationType.None)
        continuebtn.DisabledState.BorderColor = Color.DarkGray
        continuebtn.DisabledState.CustomBorderColor = Color.DarkGray
        continuebtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        continuebtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        continuebtn.Font = New Font("Segoe UI", 9F)
        continuebtn.ForeColor = Color.White
        continuebtn.Location = New Point(111, 366)
        continuebtn.Name = "continuebtn"
        continuebtn.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        continuebtn.Size = New Size(142, 47)
        continuebtn.TabIndex = 9
        continuebtn.Text = "Continue"
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(Guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2HtmlLabel5.Font = New Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold)
        Guna2HtmlLabel5.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel5.Location = New Point(22, 109)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(74, 22)
        Guna2HtmlLabel5.TabIndex = 6
        Guna2HtmlLabel5.Text = "New user? "
        ' 
        ' lblsignin
        ' 
        lblsignin.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(lblsignin, Guna.UI2.AnimatorNS.DecorationType.None)
        lblsignin.Font = New Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsignin.ForeColor = SystemColors.ActiveCaptionText
        lblsignin.Location = New Point(22, 61)
        lblsignin.Name = "lblsignin"
        lblsignin.Size = New Size(99, 42)
        lblsignin.TabIndex = 5
        lblsignin.Text = "Sign in"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2HtmlLabel3.Font = New Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.ForeColor = SystemColors.ActiveCaptionText
        Guna2HtmlLabel3.Location = New Point(22, 16)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(70, 39)
        Guna2HtmlLabel3.TabIndex = 4
        Guna2HtmlLabel3.Text = "IMG"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2HtmlLabel2.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = SystemColors.ButtonShadow
        Guna2HtmlLabel2.Location = New Point(22, 242)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(61, 19)
        Guna2HtmlLabel2.TabIndex = 3
        Guna2HtmlLabel2.Text = "Password"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2Transition1.SetDecoration(Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.ButtonShadow
        Guna2HtmlLabel1.Location = New Point(22, 163)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(64, 19)
        Guna2HtmlLabel1.TabIndex = 2
        Guna2HtmlLabel1.Text = "Username"
        ' 
        ' passwordtxt
        ' 
        passwordtxt.BackColor = SystemColors.Control
        passwordtxt.BorderColor = Color.Gray
        passwordtxt.BorderRadius = 3
        passwordtxt.CustomizableEdges = CustomizableEdges6
        Guna2Transition1.SetDecoration(passwordtxt, Guna.UI2.AnimatorNS.DecorationType.None)
        passwordtxt.DefaultText = ""
        passwordtxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        passwordtxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        passwordtxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passwordtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passwordtxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passwordtxt.Font = New Font("Segoe UI", 9F)
        passwordtxt.ForeColor = Color.Black
        passwordtxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passwordtxt.IconLeft = My.Resources.Resources.icons8_password_30
        passwordtxt.IconLeftSize = New Size(30, 30)
        passwordtxt.Location = New Point(22, 268)
        passwordtxt.Margin = New Padding(3, 4, 3, 4)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.PasswordChar = "*"c
        passwordtxt.PlaceholderText = ""
        passwordtxt.SelectedText = ""
        passwordtxt.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        passwordtxt.Size = New Size(321, 46)
        passwordtxt.TabIndex = 1
        ' 
        ' usernametxt
        ' 
        usernametxt.BackColor = Color.Transparent
        usernametxt.BorderColor = Color.Gray
        usernametxt.BorderRadius = 3
        usernametxt.CustomizableEdges = CustomizableEdges8
        Guna2Transition1.SetDecoration(usernametxt, Guna.UI2.AnimatorNS.DecorationType.None)
        usernametxt.DefaultText = ""
        usernametxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        usernametxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        usernametxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernametxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernametxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernametxt.Font = New Font("Segoe UI", 9F)
        usernametxt.ForeColor = Color.Black
        usernametxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernametxt.IconLeft = CType(resources.GetObject("usernametxt.IconLeft"), Image)
        usernametxt.IconLeftSize = New Size(30, 30)
        usernametxt.Location = New Point(22, 189)
        usernametxt.Margin = New Padding(3, 4, 3, 4)
        usernametxt.Name = "usernametxt"
        usernametxt.PasswordChar = ChrW(0)
        usernametxt.PlaceholderText = ""
        usernametxt.SelectedText = ""
        usernametxt.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        usernametxt.Size = New Size(321, 46)
        usernametxt.TabIndex = 0
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
        ' signin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2Panel2)
        Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Name = "signin"
        Size = New Size(365, 458)
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblincorrect As Label
    Friend WithEvents createacclabel As LinkLabel
    Friend WithEvents sinpasstoggle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents continuebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblsignin As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passwordtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents progressind As Guna.UI2.WinForms.Guna2ProgressIndicator
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition

End Class
