<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBWPR2
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
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.lstLinksIn = New System.Windows.Forms.ListBox()
        Me.lstLinksOut = New System.Windows.Forms.ListBox()
        Me.btnShowLinks = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboFrom
        '
        Me.cboFrom.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.Location = New System.Drawing.Point(532, 113)
        Me.cboFrom.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(374, 44)
        Me.cboFrom.TabIndex = 24
        Me.cboFrom.Text = "Choose Router"
        '
        'lstLinksIn
        '
        Me.lstLinksIn.FormattingEnabled = True
        Me.lstLinksIn.ItemHeight = 25
        Me.lstLinksIn.Location = New System.Drawing.Point(396, 402)
        Me.lstLinksIn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstLinksIn.Name = "lstLinksIn"
        Me.lstLinksIn.Size = New System.Drawing.Size(378, 379)
        Me.lstLinksIn.TabIndex = 26
        '
        'lstLinksOut
        '
        Me.lstLinksOut.FormattingEnabled = True
        Me.lstLinksOut.ItemHeight = 25
        Me.lstLinksOut.Location = New System.Drawing.Point(826, 402)
        Me.lstLinksOut.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstLinksOut.Name = "lstLinksOut"
        Me.lstLinksOut.Size = New System.Drawing.Size(378, 379)
        Me.lstLinksOut.TabIndex = 27
        '
        'btnShowLinks
        '
        Me.btnShowLinks.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowLinks.Location = New System.Drawing.Point(394, 208)
        Me.btnShowLinks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowLinks.Name = "btnShowLinks"
        Me.btnShowLinks.Size = New System.Drawing.Size(680, 152)
        Me.btnShowLinks.TabIndex = 30
        Me.btnShowLinks.Text = "Show the Links In and Links Out"
        Me.btnShowLinks.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1348, 727)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(230, 92)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1348, 596)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(230, 92)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MBW_PR2.My.Resources.Resources.NetBW
        Me.PictureBox1.Location = New System.Drawing.Point(54, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'frmMBWPR2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowLinks)
        Me.Controls.Add(Me.lstLinksOut)
        Me.Controls.Add(Me.lstLinksIn)
        Me.Controls.Add(Me.cboFrom)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmMBWPR2"
        Me.Text = "PR2-Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboFrom As ComboBox
    Friend WithEvents lstLinksIn As ListBox
    Friend WithEvents lstLinksOut As ListBox
    Friend WithEvents btnShowLinks As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
