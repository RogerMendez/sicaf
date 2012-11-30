<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado_seleccionar
    Inherits plantillaform

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoduniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelffunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.EmpleadoTableAdapter = New SICAF.sicafDataSetTableAdapters.empleadoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(996, 42)
        Me.Label1.Text = "Seleccionar Funcionario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CI/Paterno/Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(318, 26)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CiDataGridViewTextBoxColumn, Me.PatDataGridViewTextBoxColumn, Me.MatDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.CoduniDataGridViewTextBoxColumn, Me.TelffunDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(883, 230)
        Me.DataGridView1.TabIndex = 3
        '
        'CiDataGridViewTextBoxColumn
        '
        Me.CiDataGridViewTextBoxColumn.DataPropertyName = "ci"
        Me.CiDataGridViewTextBoxColumn.HeaderText = "Carnet"
        Me.CiDataGridViewTextBoxColumn.Name = "CiDataGridViewTextBoxColumn"
        Me.CiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatDataGridViewTextBoxColumn
        '
        Me.PatDataGridViewTextBoxColumn.DataPropertyName = "pat"
        Me.PatDataGridViewTextBoxColumn.HeaderText = "Ape. Paterno"
        Me.PatDataGridViewTextBoxColumn.Name = "PatDataGridViewTextBoxColumn"
        Me.PatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatDataGridViewTextBoxColumn
        '
        Me.MatDataGridViewTextBoxColumn.DataPropertyName = "mat"
        Me.MatDataGridViewTextBoxColumn.HeaderText = "Ape. Materno"
        Me.MatDataGridViewTextBoxColumn.Name = "MatDataGridViewTextBoxColumn"
        Me.MatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoduniDataGridViewTextBoxColumn
        '
        Me.CoduniDataGridViewTextBoxColumn.DataPropertyName = "cod_uni"
        Me.CoduniDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.CoduniDataGridViewTextBoxColumn.Name = "CoduniDataGridViewTextBoxColumn"
        Me.CoduniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelffunDataGridViewTextBoxColumn
        '
        Me.TelffunDataGridViewTextBoxColumn.DataPropertyName = "telf_fun"
        Me.TelffunDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelffunDataGridViewTextBoxColumn.Name = "TelffunDataGridViewTextBoxColumn"
        Me.TelffunDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        Me.CargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'empleado_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 451)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "empleado_seleccionar"
        Me.Text = "empleado_seleccionar"
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As SICAF.sicafDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents CiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoduniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelffunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
