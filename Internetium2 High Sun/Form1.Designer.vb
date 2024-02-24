<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.InternetiumToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutlookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscargotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(324, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Go"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(470, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(781, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabsToolStripMenuItem, Me.InternetiumToolbarToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(929, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabsToolStripMenuItem
        '
        Me.TabsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem, Me.CloseTabToolStripMenuItem})
        Me.TabsToolStripMenuItem.Name = "TabsToolStripMenuItem"
        Me.TabsToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.TabsToolStripMenuItem.Text = "Tabs"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewTabToolStripMenuItem.Text = "New tab"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 111)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(929, 340)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(929, 58)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(921, 32)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Tab"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'InternetiumToolbarToolStripMenuItem
        '
        Me.InternetiumToolbarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.EBayToolStripMenuItem, Me.YTToolStripMenuItem, Me.GmailToolStripMenuItem, Me.OutlookToolStripMenuItem, Me.AboutThisToolbarToolStripMenuItem, Me.BBCToolStripMenuItem, Me.AOLToolStripMenuItem, Me.EscargotToolStripMenuItem})
        Me.InternetiumToolbarToolStripMenuItem.Name = "InternetiumToolbarToolStripMenuItem"
        Me.InternetiumToolbarToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.InternetiumToolbarToolStripMenuItem.Text = "Internetium Toolbar"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'EBayToolStripMenuItem
        '
        Me.EBayToolStripMenuItem.Name = "EBayToolStripMenuItem"
        Me.EBayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EBayToolStripMenuItem.Text = "e-Bay"
        '
        'YTToolStripMenuItem
        '
        Me.YTToolStripMenuItem.Name = "YTToolStripMenuItem"
        Me.YTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.YTToolStripMenuItem.Text = "YT"
        '
        'GmailToolStripMenuItem
        '
        Me.GmailToolStripMenuItem.Name = "GmailToolStripMenuItem"
        Me.GmailToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GmailToolStripMenuItem.Text = "Gmail"
        '
        'OutlookToolStripMenuItem
        '
        Me.OutlookToolStripMenuItem.Name = "OutlookToolStripMenuItem"
        Me.OutlookToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OutlookToolStripMenuItem.Text = "Outlook"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutThisToolbarToolStripMenuItem
        '
        Me.AboutThisToolbarToolStripMenuItem.Name = "AboutThisToolbarToolStripMenuItem"
        Me.AboutThisToolbarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutThisToolbarToolStripMenuItem.Text = "About this toolbar"
        '
        'BBCToolStripMenuItem
        '
        Me.BBCToolStripMenuItem.Name = "BBCToolStripMenuItem"
        Me.BBCToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BBCToolStripMenuItem.Text = "BBC"
        '
        'AOLToolStripMenuItem
        '
        Me.AOLToolStripMenuItem.Name = "AOLToolStripMenuItem"
        Me.AOLToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AOLToolStripMenuItem.Text = "AOL"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EscargotToolStripMenuItem
        '
        Me.EscargotToolStripMenuItem.Name = "EscargotToolStripMenuItem"
        Me.EscargotToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EscargotToolStripMenuItem.Text = "Escargot"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 454)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Internetium v2.0 - TheRealRanvir Edition"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents InternetiumToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutlookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutThisToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BBCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EscargotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
