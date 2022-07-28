<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitial
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
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRoutersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditLinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowNetworkMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'spcMain
        '
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 36)
        Me.spcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.spcMain.Name = "spcMain"
        '
        'spcMain.Panel1
        '
        Me.spcMain.Size = New System.Drawing.Size(1710, 970)
        Me.spcMain.SplitterDistance = 832
        Me.spcMain.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.NetworkMapToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1710, 36)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitApplicationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 32)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditRoutersToolStripMenuItem, Me.EditLinksToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(102, 32)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'EditRoutersToolStripMenuItem
        '
        Me.EditRoutersToolStripMenuItem.Name = "EditRoutersToolStripMenuItem"
        Me.EditRoutersToolStripMenuItem.Size = New System.Drawing.Size(209, 34)
        Me.EditRoutersToolStripMenuItem.Text = "Edit Routers"
        '
        'EditLinksToolStripMenuItem
        '
        Me.EditLinksToolStripMenuItem.Name = "EditLinksToolStripMenuItem"
        Me.EditLinksToolStripMenuItem.Size = New System.Drawing.Size(209, 34)
        Me.EditLinksToolStripMenuItem.Text = "Edit Links"
        '
        'NetworkMapToolStripMenuItem
        '
        Me.NetworkMapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowNetworkMapToolStripMenuItem})
        Me.NetworkMapToolStripMenuItem.Name = "NetworkMapToolStripMenuItem"
        Me.NetworkMapToolStripMenuItem.Size = New System.Drawing.Size(136, 32)
        Me.NetworkMapToolStripMenuItem.Text = "Network Map"
        '
        'ShowNetworkMapToolStripMenuItem
        '
        Me.ShowNetworkMapToolStripMenuItem.Name = "ShowNetworkMapToolStripMenuItem"
        Me.ShowNetworkMapToolStripMenuItem.Size = New System.Drawing.Size(271, 34)
        Me.ShowNetworkMapToolStripMenuItem.Text = "Show Network Map"
        '
        'frmInitial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1710, 1006)
        Me.Controls.Add(Me.spcMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmInitial"
        Me.Text = "frmInitial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spcMain As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetworkMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditRoutersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditLinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowNetworkMapToolStripMenuItem As ToolStripMenuItem
End Class
