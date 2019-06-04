<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_factor
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
        Me.dgv_factor = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LFBPLLonFactorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._LFB_ITEM_DataSet = New PL_Center._LFB_ITEM_DataSet()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.LFB_PL_Lon_FactorTableAdapter = New PL_Center._LFB_ITEM_DataSetTableAdapters.LFB_PL_Lon_FactorTableAdapter()
        CType(Me.dgv_factor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LFBPLLonFactorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._LFB_ITEM_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_factor
        '
        Me.dgv_factor.AutoGenerateColumns = False
        Me.dgv_factor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_factor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LonDataGridViewTextBoxColumn, Me.CDataGridViewTextBoxColumn, Me.DDataGridViewTextBoxColumn, Me.EDataGridViewTextBoxColumn, Me.FDataGridViewTextBoxColumn, Me.GDataGridViewTextBoxColumn})
        Me.dgv_factor.DataSource = Me.LFBPLLonFactorBindingSource
        Me.dgv_factor.Location = New System.Drawing.Point(0, 0)
        Me.dgv_factor.Name = "dgv_factor"
        Me.dgv_factor.Size = New System.Drawing.Size(744, 326)
        Me.dgv_factor.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LonDataGridViewTextBoxColumn
        '
        Me.LonDataGridViewTextBoxColumn.DataPropertyName = "Lon"
        Me.LonDataGridViewTextBoxColumn.HeaderText = "Lon"
        Me.LonDataGridViewTextBoxColumn.Name = "LonDataGridViewTextBoxColumn"
        '
        'CDataGridViewTextBoxColumn
        '
        Me.CDataGridViewTextBoxColumn.DataPropertyName = "C"
        Me.CDataGridViewTextBoxColumn.HeaderText = "C"
        Me.CDataGridViewTextBoxColumn.Name = "CDataGridViewTextBoxColumn"
        '
        'DDataGridViewTextBoxColumn
        '
        Me.DDataGridViewTextBoxColumn.DataPropertyName = "D"
        Me.DDataGridViewTextBoxColumn.HeaderText = "D"
        Me.DDataGridViewTextBoxColumn.Name = "DDataGridViewTextBoxColumn"
        '
        'EDataGridViewTextBoxColumn
        '
        Me.EDataGridViewTextBoxColumn.DataPropertyName = "E"
        Me.EDataGridViewTextBoxColumn.HeaderText = "E"
        Me.EDataGridViewTextBoxColumn.Name = "EDataGridViewTextBoxColumn"
        '
        'FDataGridViewTextBoxColumn
        '
        Me.FDataGridViewTextBoxColumn.DataPropertyName = "F"
        Me.FDataGridViewTextBoxColumn.HeaderText = "F"
        Me.FDataGridViewTextBoxColumn.Name = "FDataGridViewTextBoxColumn"
        '
        'GDataGridViewTextBoxColumn
        '
        Me.GDataGridViewTextBoxColumn.DataPropertyName = "G"
        Me.GDataGridViewTextBoxColumn.HeaderText = "G"
        Me.GDataGridViewTextBoxColumn.Name = "GDataGridViewTextBoxColumn"
        '
        'LFBPLLonFactorBindingSource
        '
        Me.LFBPLLonFactorBindingSource.DataMember = "LFB_PL$Lon Factor"
        Me.LFBPLLonFactorBindingSource.DataSource = Me._LFB_ITEM_DataSet
        '
        '_LFB_ITEM_DataSet
        '
        Me._LFB_ITEM_DataSet.DataSetName = "_LFB_ITEM_DataSet"
        Me._LFB_ITEM_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(648, 332)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(96, 26)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(550, 332)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 26)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(3, 332)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(96, 26)
        Me.btn_refresh.TabIndex = 3
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'LFB_PL_Lon_FactorTableAdapter
        '
        Me.LFB_PL_Lon_FactorTableAdapter.ClearBeforeFill = True
        '
        'frm_factor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 400)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.dgv_factor)
        Me.MaximizeBox = False
        Me.Name = "frm_factor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup :: Factor"
        CType(Me.dgv_factor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LFBPLLonFactorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._LFB_ITEM_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_factor As DataGridView
    Friend WithEvents _LFB_ITEM_DataSet As _LFB_ITEM_DataSet
    Friend WithEvents LFBPLLonFactorBindingSource As BindingSource
    Friend WithEvents LFB_PL_Lon_FactorTableAdapter As _LFB_ITEM_DataSetTableAdapters.LFB_PL_Lon_FactorTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_refresh As Button
End Class
