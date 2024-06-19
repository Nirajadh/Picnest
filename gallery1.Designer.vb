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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        searchpanel = New Panel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        lblusername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2CustomGradientPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        searchpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.White
        Guna2CustomGradientPanel1.BorderRadius = 10
        Guna2CustomGradientPanel1.Controls.Add(FlowLayoutPanel1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel1.Dock = DockStyle.Fill
        Guna2CustomGradientPanel1.FillColor = SystemColors.ControlLightLight
        Guna2CustomGradientPanel1.FillColor2 = SystemColors.ButtonHighlight
        Guna2CustomGradientPanel1.FillColor3 = SystemColors.Highlight
        Guna2CustomGradientPanel1.FillColor4 = SystemColors.ButtonHighlight
        Guna2CustomGradientPanel1.ForeColor = Color.Transparent
        Guna2CustomGradientPanel1.Location = New Point(0, 0)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel1.Size = New Size(1045, 654)
        Guna2CustomGradientPanel1.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Controls.Add(searchpanel)
        FlowLayoutPanel1.Controls.Add(lblusername)
        FlowLayoutPanel1.ForeColor = Color.Transparent
        FlowLayoutPanel1.Location = New Point(281, 7)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 0, 0, 50)
        FlowLayoutPanel1.Size = New Size(482, 647)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' searchpanel
        ' 
        searchpanel.Controls.Add(Guna2TextBox1)
        searchpanel.Dock = DockStyle.Top
        searchpanel.Location = New Point(3, 3)
        searchpanel.Name = "searchpanel"
        searchpanel.Size = New Size(454, 99)
        searchpanel.TabIndex = 2
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
        Guna2TextBox1.Location = New Point(59, 16)
        Guna2TextBox1.Margin = New Padding(4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.Black
        Guna2TextBox1.PlaceholderText = "Username"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(336, 55)
        Guna2TextBox1.TabIndex = 1
        ' 
        ' lblusername
        ' 
        lblusername.BackColor = Color.Transparent
        lblusername.Dock = DockStyle.Top
        lblusername.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblusername.ForeColor = Color.Black
        lblusername.Location = New Point(463, 3)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(3, 2)
        lblusername.TabIndex = 10
        lblusername.Text = Nothing
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 30
        Guna2Elipse1.TargetControl = FlowLayoutPanel1
        ' 
        ' gallery1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLight
        Controls.Add(Guna2CustomGradientPanel1)
        Name = "gallery1"
        Size = New Size(1045, 654)
        Guna2CustomGradientPanel1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        searchpanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblusername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchpanel As Panel

End Class
