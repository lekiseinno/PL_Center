<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_paper_cost
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
        Me.components = New System.ComponentModel.Container()
        Me.dgv_paperCost = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LFBCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFPLKGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFPLSQMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFDSSQMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQMFigthingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LFBPLPAPERBaseCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._LFB_ITEM_DataSet = New PL_Center._LFB_ITEM_DataSet()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.LFB_PL_PAPER_Base_CostTableAdapter = New PL_Center._LFB_ITEM_DataSetTableAdapters.LFB_PL_PAPER_Base_CostTableAdapter()
        CType(Me.dgv_paperCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LFBPLPAPERBaseCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._LFB_ITEM_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_paperCost
        '
        Me.dgv_paperCost.AutoGenerateColumns = False
        Me.dgv_paperCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_paperCost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.LFBCodeDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.GSMDataGridViewTextBoxColumn, Me.EFFPLKGDataGridViewTextBoxColumn, Me.EFFPLSQMDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn, Me.EFFDSSQMDataGridViewTextBoxColumn, Me.MINDataGridViewTextBoxColumn, Me.FightDataGridViewTextBoxColumn, Me.SQMFigthingDataGridViewTextBoxColumn, Me.SUPCODEDataGridViewTextBoxColumn, Me.CODEDataGridViewTextBoxColumn})
        Me.dgv_paperCost.DataSource = Me.LFBPLPAPERBaseCostBindingSource
        Me.dgv_paperCost.Location = New System.Drawing.Point(0, 0)
        Me.dgv_paperCost.Name = "dgv_paperCost"
        Me.dgv_paperCost.Size = New System.Drawing.Size(1450, 517)
        Me.dgv_paperCost.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'LFBCodeDataGridViewTextBoxColumn
        '
        Me.LFBCodeDataGridViewTextBoxColumn.DataPropertyName = "LFB_Code"
        Me.LFBCodeDataGridViewTextBoxColumn.HeaderText = "LFB_Code"
        Me.LFBCodeDataGridViewTextBoxColumn.Name = "LFBCodeDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'GSMDataGridViewTextBoxColumn
        '
        Me.GSMDataGridViewTextBoxColumn.DataPropertyName = "GSM"
        Me.GSMDataGridViewTextBoxColumn.HeaderText = "GSM"
        Me.GSMDataGridViewTextBoxColumn.Name = "GSMDataGridViewTextBoxColumn"
        '
        'EFFPLKGDataGridViewTextBoxColumn
        '
        Me.EFFPLKGDataGridViewTextBoxColumn.DataPropertyName = "EFF_PL$KG"
        Me.EFFPLKGDataGridViewTextBoxColumn.HeaderText = "EFF_PL$KG"
        Me.EFFPLKGDataGridViewTextBoxColumn.Name = "EFFPLKGDataGridViewTextBoxColumn"
        '
        'EFFPLSQMDataGridViewTextBoxColumn
        '
        Me.EFFPLSQMDataGridViewTextBoxColumn.DataPropertyName = "EFF_PL$SQM"
        Me.EFFPLSQMDataGridViewTextBoxColumn.HeaderText = "EFF_PL$SQM"
        Me.EFFPLSQMDataGridViewTextBoxColumn.Name = "EFFPLSQMDataGridViewTextBoxColumn"
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        '
        'EFFDSSQMDataGridViewTextBoxColumn
        '
        Me.EFFDSSQMDataGridViewTextBoxColumn.DataPropertyName = "EFF_DS$SQM"
        Me.EFFDSSQMDataGridViewTextBoxColumn.HeaderText = "EFF_DS$SQM"
        Me.EFFDSSQMDataGridViewTextBoxColumn.Name = "EFFDSSQMDataGridViewTextBoxColumn"
        '
        'MINDataGridViewTextBoxColumn
        '
        Me.MINDataGridViewTextBoxColumn.DataPropertyName = "MIN"
        Me.MINDataGridViewTextBoxColumn.HeaderText = "MIN"
        Me.MINDataGridViewTextBoxColumn.Name = "MINDataGridViewTextBoxColumn"
        '
        'FightDataGridViewTextBoxColumn
        '
        Me.FightDataGridViewTextBoxColumn.DataPropertyName = "Fight"
        Me.FightDataGridViewTextBoxColumn.HeaderText = "Fight"
        Me.FightDataGridViewTextBoxColumn.Name = "FightDataGridViewTextBoxColumn"
        '
        'SQMFigthingDataGridViewTextBoxColumn
        '
        Me.SQMFigthingDataGridViewTextBoxColumn.DataPropertyName = "SQM_Figthing"
        Me.SQMFigthingDataGridViewTextBoxColumn.HeaderText = "SQM_Figthing"
        Me.SQMFigthingDataGridViewTextBoxColumn.Name = "SQMFigthingDataGridViewTextBoxColumn"
        '
        'SUPCODEDataGridViewTextBoxColumn
        '
        Me.SUPCODEDataGridViewTextBoxColumn.DataPropertyName = "SUP_CODE"
        Me.SUPCODEDataGridViewTextBoxColumn.HeaderText = "SUP_CODE"
        Me.SUPCODEDataGridViewTextBoxColumn.Name = "SUPCODEDataGridViewTextBoxColumn"
        '
        'CODEDataGridViewTextBoxColumn
        '
        Me.CODEDataGridViewTextBoxColumn.DataPropertyName = "CODE"
        Me.CODEDataGridViewTextBoxColumn.HeaderText = "CODE"
        Me.CODEDataGridViewTextBoxColumn.Name = "CODEDataGridViewTextBoxColumn"
        '
        'LFBPLPAPERBaseCostBindingSource
        '
        Me.LFBPLPAPERBaseCostBindingSource.DataMember = "LFB_PL$PAPER Base Cost"
        Me.LFBPLPAPERBaseCostBindingSource.DataSource = Me._LFB_ITEM_DataSet
        '
        '_LFB_ITEM_DataSet
        '
        Me._LFB_ITEM_DataSet.DataSetName = "_LFB_ITEM_DataSet"
        Me._LFB_ITEM_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(1291, 534)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1372, 534)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(4, 534)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 3
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'LFB_PL_PAPER_Base_CostTableAdapter
        '
        Me.LFB_PL_PAPER_Base_CostTableAdapter.ClearBeforeFill = True
        '
        'frm_paper_cost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 591)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dgv_paperCost)
        Me.MaximizeBox = False
        Me.Name = "frm_paper_cost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_paper_cost"
        CType(Me.dgv_paperCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LFBPLPAPERBaseCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._LFB_ITEM_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_paperCost As DataGridView
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents _LFB_ITEM_DataSet As _LFB_ITEM_DataSet
    Friend WithEvents LFBPLPAPERBaseCostBindingSource As BindingSource
    Friend WithEvents LFB_PL_PAPER_Base_CostTableAdapter As _LFB_ITEM_DataSetTableAdapters.LFB_PL_PAPER_Base_CostTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LFBCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GSMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EFFPLKGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EFFPLSQMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EFFDSSQMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SQMFigthingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUPCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
