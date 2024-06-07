<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(components)
        Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Guna2ResizeForm1 = New Guna.UI2.WinForms.Guna2ResizeForm(components)
        Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        TabPage3 = New TabPage()
        Guna2TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2TaskBarProgress1
        ' 
        Guna2TaskBarProgress1.TargetForm = Nothing
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
        Animation1.Padding = New Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0F
        Animation1.RotateLimit = 0F
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), PointF)
        Animation1.TimeCoeff = 0F
        Animation1.TransparencyCoeff = 0F
        Guna2Transition1.DefaultAnimation = Animation1
        ' 
        ' Guna2TabControl1
        ' 
        Guna2TabControl1.Alignment = TabAlignment.Left
        Guna2TabControl1.Controls.Add(TabPage1)
        Guna2TabControl1.Controls.Add(TabPage2)
        Guna2TabControl1.Controls.Add(TabPage3)
        Guna2Transition1.SetDecoration(Guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2TabControl1.Dock = DockStyle.Fill
        Guna2TabControl1.ItemSize = New Size(180, 40)
        Guna2TabControl1.Location = New Point(0, 0)
        Guna2TabControl1.Name = "Guna2TabControl1"
        Guna2TabControl1.SelectedIndex = 0
        Guna2TabControl1.Size = New Size(1007, 608)
        Guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        Guna2TabControl1.TabButtonHoverState.Font = New Font("Segoe UI Semibold", 10F)
        Guna2TabControl1.TabButtonHoverState.ForeColor = Color.White
        Guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        Guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabButtonIdleState.Font = New Font("Segoe UI Semibold", 10F)
        Guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(CByte(156), CByte(160), CByte(167))
        Guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(CByte(29), CByte(37), CByte(49))
        Guna2TabControl1.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F)
        Guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White
        Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(CByte(76), CByte(132), CByte(255))
        Guna2TabControl1.TabButtonSize = New Size(180, 40)
        Guna2TabControl1.TabIndex = 0
        Guna2TabControl1.TabMenuBackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        ' 
        ' TabPage1
        ' 
        Guna2Transition1.SetDecoration(TabPage1, Guna.UI2.AnimatorNS.DecorationType.None)
        TabPage1.Location = New Point(184, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(819, 600)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Guna2Button1)
        Guna2Transition1.SetDecoration(TabPage2, Guna.UI2.AnimatorNS.DecorationType.None)
        TabPage2.Location = New Point(184, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(819, 600)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Transition1.SetDecoration(Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(433, 101)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Guna2Button1"
        ' 
        ' TabPage3
        ' 
        Guna2Transition1.SetDecoration(TabPage3, Guna.UI2.AnimatorNS.DecorationType.None)
        TabPage3.Location = New Point(184, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(819, 600)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1007, 608)
        Controls.Add(Guna2TabControl1)
        Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        FormBorderStyle = FormBorderStyle.None
        Name = "home"
        Text = "home"
        Guna2TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2ResizeForm1 As Guna.UI2.WinForms.Guna2ResizeForm
End Class
