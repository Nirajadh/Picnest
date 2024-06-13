<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Panel1 = New Panel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Panel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = SystemColors.ActiveCaptionText
        Guna2Panel2.BorderColor = SystemColors.WindowFrame
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.BorderThickness = 1
        Guna2Panel2.CustomizableEdges = CustomizableEdges1
        Guna2Transition1.SetDecoration(Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Panel2.FillColor = Color.Transparent
        Guna2Panel2.Location = New Point(222, 14)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel2.Size = New Size(365, 458)
        Guna2Panel2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Guna2Panel2)
        Guna2Transition1.SetDecoration(Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(20, 41)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 5, 20, 30)
        Panel1.Size = New Size(808, 498)
        Panel1.TabIndex = 5
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2Transition1.SetDecoration(Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2ControlBox1.FillColor = Color.Black
        Guna2ControlBox1.IconColor = Color.White
        Guna2ControlBox1.Location = New Point(755, 12)
        Guna2ControlBox1.Margin = New Padding(0)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.RightToLeft = RightToLeft.Yes
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(40, 25)
        Guna2ControlBox1.TabIndex = 1
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(Guna2ControlBox2)
        Guna2Panel1.Controls.Add(Guna2ControlBox1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Transition1.SetDecoration(Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(20, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(808, 41)
        Guna2Panel1.TabIndex = 9
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges5
        Guna2Transition1.SetDecoration(Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2ControlBox2.FillColor = Color.Black
        Guna2ControlBox2.IconColor = Color.White
        Guna2ControlBox2.Location = New Point(715, 12)
        Guna2ControlBox2.Margin = New Padding(0)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.RightToLeft = RightToLeft.Yes
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox2.Size = New Size(40, 25)
        Guna2ControlBox2.TabIndex = 2
        ' 
        ' Guna2Transition1
        ' 
        Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles
        Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), PointF)
        Animation1.LeafCoeff = 0F
        Animation1.MaxTime = 1F
        Animation1.MinTime = 0F
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0F
        Animation1.RotateLimit = 0F
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), PointF)
        Animation1.TimeCoeff = 2F
        Animation1.TransparencyCoeff = 0F
        Guna2Transition1.DefaultAnimation = Animation1
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Guna2BorderlessForm1.BorderRadius = 60
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.ResizeForm = False
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(828, 559)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Guna2Panel1)
        Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        DoubleBuffered = True
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Padding = New Padding(20, 0, 0, 20)
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm


End Class
