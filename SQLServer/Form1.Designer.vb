<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TESTDataSet = New SQLServer.TESTDataSet()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New SQLServer.TESTDataSetTableAdapters.personTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.InfoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(705, 325)
        Me.DataGridView1.TabIndex = 0
        '
        'TESTDataSet
        '
        Me.TESTDataSet.DataSetName = "TESTDataSet"
        Me.TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "person"
        Me.PersonBindingSource.DataSource = Me.TESTDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "birthday"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        '
        'InfoDataGridViewTextBoxColumn
        '
        Me.InfoDataGridViewTextBoxColumn.DataPropertyName = "info"
        Me.InfoDataGridViewTextBoxColumn.HeaderText = "info"
        Me.InfoDataGridViewTextBoxColumn.Name = "InfoDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TESTDataSet As TESTDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As TESTDataSetTableAdapters.personTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
