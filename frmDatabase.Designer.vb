<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Me.components = New System.ComponentModel.Container()
        Me.btnUpdateDatabase = New System.Windows.Forms.Button()
        Me.btnBacktoMain = New System.Windows.Forms.Button()
        Me.NetworkDataDataSet = New MBW_PR2.NetworkDataDataSet()
        Me.ArcsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArcsTableAdapter = New MBW_PR2.NetworkDataDataSetTableAdapters.ArcsTableAdapter()
        Me.NetworkDataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvData = New System.Windows.Forms.DataGridView()
        CType(Me.NetworkDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetworkDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateDatabase
        '
        Me.btnUpdateDatabase.Location = New System.Drawing.Point(135, 383)
        Me.btnUpdateDatabase.Name = "btnUpdateDatabase"
        Me.btnUpdateDatabase.Size = New System.Drawing.Size(206, 66)
        Me.btnUpdateDatabase.TabIndex = 0
        Me.btnUpdateDatabase.Text = "Update Database"
        Me.btnUpdateDatabase.UseVisualStyleBackColor = True
        '
        'btnBacktoMain
        '
        Me.btnBacktoMain.Location = New System.Drawing.Point(512, 383)
        Me.btnBacktoMain.Name = "btnBacktoMain"
        Me.btnBacktoMain.Size = New System.Drawing.Size(206, 66)
        Me.btnBacktoMain.TabIndex = 1
        Me.btnBacktoMain.Text = "Back to Main Form"
        Me.btnBacktoMain.UseVisualStyleBackColor = True
        '
        'NetworkDataDataSet
        '
        Me.NetworkDataDataSet.DataSetName = "NetworkDataDataSet"
        Me.NetworkDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArcsBindingSource
        '
        Me.ArcsBindingSource.DataMember = "Arcs"
        Me.ArcsBindingSource.DataSource = Me.NetworkDataDataSet
        '
        'ArcsTableAdapter
        '
        Me.ArcsTableAdapter.ClearBeforeFill = True
        '
        'NetworkDataDataSetBindingSource
        '
        Me.NetworkDataDataSetBindingSource.DataSource = Me.NetworkDataDataSet
        Me.NetworkDataDataSetBindingSource.Position = 0
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(135, 55)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(527, 280)
        Me.dgvData.TabIndex = 2
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnBacktoMain)
        Me.Controls.Add(Me.btnUpdateDatabase)
        Me.Name = "frmDatabase"
        Me.Text = "frmDatabase"
        CType(Me.NetworkDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetworkDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateDatabase As Button
    Friend WithEvents btnBacktoMain As Button
    Friend WithEvents NetworkDataDataSet As NetworkDataDataSet
    Friend WithEvents ArcsBindingSource As BindingSource
    Friend WithEvents ArcsTableAdapter As NetworkDataDataSetTableAdapters.ArcsTableAdapter
    Friend WithEvents NetworkDataDataSetBindingSource As BindingSource
    Friend WithEvents dgvData As DataGridView
End Class
