<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cboDestRouter = New System.Windows.Forms.ComboBox()
        Me.lstPath = New System.Windows.Forms.ListBox()
        Me.lstDataTables = New System.Windows.Forms.ListBox()
        Me.btnCalculateMaxBW = New System.Windows.Forms.Button()
        Me.cboOrigRouter = New System.Windows.Forms.ComboBox()
        Me.btnTabletoEdit = New System.Windows.Forms.Button()
        Me.lblRoutes = New System.Windows.Forms.Label()
        Me.lblMaxBWPossible = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboDestRouter
        '
        Me.cboDestRouter.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestRouter.FormattingEnabled = True
        Me.cboDestRouter.Location = New System.Drawing.Point(40, 99)
        Me.cboDestRouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDestRouter.Name = "cboDestRouter"
        Me.cboDestRouter.Size = New System.Drawing.Size(282, 35)
        Me.cboDestRouter.TabIndex = 24
        Me.cboDestRouter.Text = "Choose Dest Router"
        '
        'lstPath
        '
        Me.lstPath.FormattingEnabled = True
        Me.lstPath.ItemHeight = 20
        Me.lstPath.Location = New System.Drawing.Point(40, 481)
        Me.lstPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstPath.Name = "lstPath"
        Me.lstPath.Size = New System.Drawing.Size(378, 144)
        Me.lstPath.TabIndex = 26
        '
        'lstDataTables
        '
        Me.lstDataTables.FormattingEnabled = True
        Me.lstDataTables.ItemHeight = 20
        Me.lstDataTables.Location = New System.Drawing.Point(569, 178)
        Me.lstDataTables.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstDataTables.Name = "lstDataTables"
        Me.lstDataTables.Size = New System.Drawing.Size(188, 104)
        Me.lstDataTables.TabIndex = 27
        '
        'btnCalculateMaxBW
        '
        Me.btnCalculateMaxBW.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateMaxBW.Location = New System.Drawing.Point(27, 178)
        Me.btnCalculateMaxBW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculateMaxBW.Name = "btnCalculateMaxBW"
        Me.btnCalculateMaxBW.Size = New System.Drawing.Size(362, 121)
        Me.btnCalculateMaxBW.TabIndex = 30
        Me.btnCalculateMaxBW.Text = "Calculate the Max Bandwidth"
        Me.btnCalculateMaxBW.UseVisualStyleBackColor = True
        '
        'cboOrigRouter
        '
        Me.cboOrigRouter.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigRouter.FormattingEnabled = True
        Me.cboOrigRouter.Location = New System.Drawing.Point(40, 34)
        Me.cboOrigRouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboOrigRouter.Name = "cboOrigRouter"
        Me.cboOrigRouter.Size = New System.Drawing.Size(282, 35)
        Me.cboOrigRouter.TabIndex = 33
        Me.cboOrigRouter.Text = "Choose Orig Router"
        '
        'btnTabletoEdit
        '
        Me.btnTabletoEdit.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabletoEdit.Location = New System.Drawing.Point(447, 34)
        Me.btnTabletoEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTabletoEdit.Name = "btnTabletoEdit"
        Me.btnTabletoEdit.Size = New System.Drawing.Size(310, 117)
        Me.btnTabletoEdit.TabIndex = 34
        Me.btnTabletoEdit.Text = "Choose a Table to Edit:"
        Me.btnTabletoEdit.UseVisualStyleBackColor = True
        '
        'lblRoutes
        '
        Me.lblRoutes.AutoSize = True
        Me.lblRoutes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblRoutes.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoutes.Location = New System.Drawing.Point(40, 338)
        Me.lblRoutes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoutes.Name = "lblRoutes"
        Me.lblRoutes.Size = New System.Drawing.Size(92, 27)
        Me.lblRoutes.TabIndex = 35
        Me.lblRoutes.Text = "Label1"
        '
        'lblMaxBWPossible
        '
        Me.lblMaxBWPossible.AutoSize = True
        Me.lblMaxBWPossible.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblMaxBWPossible.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBWPossible.Location = New System.Drawing.Point(42, 401)
        Me.lblMaxBWPossible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxBWPossible.Name = "lblMaxBWPossible"
        Me.lblMaxBWPossible.Size = New System.Drawing.Size(466, 27)
        Me.lblMaxBWPossible.TabIndex = 36
        Me.lblMaxBWPossible.Text = "The maximum bandwidth possible is:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblResult.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(519, 401)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(92, 27)
        Me.lblResult.TabIndex = 37
        Me.lblResult.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1915, 858)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblMaxBWPossible)
        Me.Controls.Add(Me.lblRoutes)
        Me.Controls.Add(Me.btnTabletoEdit)
        Me.Controls.Add(Me.cboOrigRouter)
        Me.Controls.Add(Me.btnCalculateMaxBW)
        Me.Controls.Add(Me.lstDataTables)
        Me.Controls.Add(Me.lstPath)
        Me.Controls.Add(Me.cboDestRouter)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "PR2-Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDestRouter As ComboBox
    Friend WithEvents lstPath As ListBox
    Friend WithEvents lstDataTables As ListBox
    Friend WithEvents btnCalculateMaxBW As Button
    Friend WithEvents cboOrigRouter As ComboBox
    Friend WithEvents btnTabletoEdit As Button
    Friend WithEvents lblRoutes As Label
    Friend WithEvents lblMaxBWPossible As Label
    Friend WithEvents lblResult As Label
End Class
