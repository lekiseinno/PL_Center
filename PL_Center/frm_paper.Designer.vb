<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_paper
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LFBPLPAPERGradeCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._LFB_ITEM_DataSet = New PL_Center._LFB_ITEM_DataSet()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.LFB_PL_PAPER_Grade___CostTableAdapter = New PL_Center._LFB_ITEM_DataSetTableAdapters.LFB_PL_PAPER_Grade___CostTableAdapter()
        Me.dgv_paper = New System.Windows.Forms.DataGridView()
        Me.CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastupdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LFBPLPAPERGradeCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._LFB_ITEM_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LFBPLPAPERGradeCostBindingSource
        '
        Me.LFBPLPAPERGradeCostBindingSource.DataMember = "LFB_PL$PAPER Grade & Cost"
        Me.LFBPLPAPERGradeCostBindingSource.DataSource = Me._LFB_ITEM_DataSet
        '
        '_LFB_ITEM_DataSet
        '
        Me._LFB_ITEM_DataSet.DataSetName = "_LFB_ITEM_DataSet"
        Me._LFB_ITEM_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(137, 376)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(96, 26)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(23, 376)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 26)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(253, 376)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(96, 26)
        Me.btn_exit.TabIndex = 4
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'LFB_PL_PAPER_Grade___CostTableAdapter
        '
        Me.LFB_PL_PAPER_Grade___CostTableAdapter.ClearBeforeFill = True
        '
        'dgv_paper
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_paper.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_paper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_paper.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODE, Me.ETc, Me.PUR, Me.GRADE, Me.lastupdate})
        Me.dgv_paper.Location = New System.Drawing.Point(23, 27)
        Me.dgv_paper.Name = "dgv_paper"
        Me.dgv_paper.Size = New System.Drawing.Size(604, 329)
        Me.dgv_paper.TabIndex = 21
        '
        'CODE
        '
        Me.CODE.HeaderText = "CODE"
        Me.CODE.Name = "CODE"
        '
        'ETc
        '
        Me.ETc.HeaderText = "ETc"
        Me.ETc.Name = "ETc"
        '
        'PUR
        '
        Me.PUR.HeaderText = "PUR"
        Me.PUR.Name = "PUR"
        '
        'GRADE
        '
        Me.GRADE.HeaderText = "GRADE"
        Me.GRADE.Name = "GRADE"
        '
        'lastupdate
        '
        Me.lastupdate.HeaderText = "lastupdate"
        Me.lastupdate.Name = "lastupdate"
        Me.lastupdate.Width = 150
        '
        'frm_paper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 564)
        Me.Controls.Add(Me.dgv_paper)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.MaximizeBox = False
        Me.Name = "frm_paper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup :: Paper"
        CType(Me.LFBPLPAPERGradeCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._LFB_ITEM_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents _LFB_ITEM_DataSet As _LFB_ITEM_DataSet
    Friend WithEvents LFBPLPAPERGradeCostBindingSource As BindingSource
    Friend WithEvents LFB_PL_PAPER_Grade___CostTableAdapter As _LFB_ITEM_DataSetTableAdapters.LFB_PL_PAPER_Grade___CostTableAdapter
    Friend WithEvents dgv_paper As DataGridView
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents ETc As DataGridViewTextBoxColumn
    Friend WithEvents PUR As DataGridViewTextBoxColumn
    Friend WithEvents GRADE As DataGridViewTextBoxColumn
    Friend WithEvents lastupdate As DataGridViewTextBoxColumn
End Class
