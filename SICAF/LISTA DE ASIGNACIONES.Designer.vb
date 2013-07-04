<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTA_DE_ASIGNACIONES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LISTA_DE_ASIGNACIONES))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActivofDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodasingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodafDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesafDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuptipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FchassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportesasignacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Reportes_asignacionesTableAdapter = New SICAF.sicafDataSetTableAdapters.reportes_asignacionesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ActivofDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesasignacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(648, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Mostrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda Activo Fijo"
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(498, 33)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "codigosub"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(60, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Subtipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo:"
        '
        'ActivofDataGridView
        '
        Me.ActivofDataGridView.AllowUserToAddRows = False
        Me.ActivofDataGridView.AllowUserToDeleteRows = False
        Me.ActivofDataGridView.AllowUserToOrderColumns = True
        Me.ActivofDataGridView.AutoGenerateColumns = False
        Me.ActivofDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ActivofDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActivofDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodasingDataGridViewTextBoxColumn, Me.CodafDataGridViewTextBoxColumn, Me.DesafDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.CondactDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.SuptipoDataGridViewTextBoxColumn, Me.CiDataGridViewTextBoxColumn, Me.PatDataGridViewTextBoxColumn, Me.MatDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ObsDataGridViewTextBoxColumn, Me.FchassDataGridViewTextBoxColumn})
        Me.ActivofDataGridView.DataSource = Me.ReportesasignacionesBindingSource
        Me.ActivofDataGridView.Location = New System.Drawing.Point(12, 180)
        Me.ActivofDataGridView.MultiSelect = False
        Me.ActivofDataGridView.Name = "ActivofDataGridView"
        Me.ActivofDataGridView.ReadOnly = True
        Me.ActivofDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ActivofDataGridView.Size = New System.Drawing.Size(837, 220)
        Me.ActivofDataGridView.TabIndex = 5
        '
        'CodasingDataGridViewTextBoxColumn
        '
        Me.CodasingDataGridViewTextBoxColumn.DataPropertyName = "cod_asing"
        Me.CodasingDataGridViewTextBoxColumn.HeaderText = "cod_asing"
        Me.CodasingDataGridViewTextBoxColumn.Name = "CodasingDataGridViewTextBoxColumn"
        Me.CodasingDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodasingDataGridViewTextBoxColumn.Width = 81
        '
        'CodafDataGridViewTextBoxColumn
        '
        Me.CodafDataGridViewTextBoxColumn.DataPropertyName = "codaf"
        Me.CodafDataGridViewTextBoxColumn.HeaderText = "codaf"
        Me.CodafDataGridViewTextBoxColumn.Name = "CodafDataGridViewTextBoxColumn"
        Me.CodafDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodafDataGridViewTextBoxColumn.Width = 59
        '
        'DesafDataGridViewTextBoxColumn
        '
        Me.DesafDataGridViewTextBoxColumn.DataPropertyName = "desaf"
        Me.DesafDataGridViewTextBoxColumn.HeaderText = "desaf"
        Me.DesafDataGridViewTextBoxColumn.Name = "DesafDataGridViewTextBoxColumn"
        Me.DesafDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesafDataGridViewTextBoxColumn.Width = 58
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadDataGridViewTextBoxColumn.Width = 64
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Width = 61
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 61
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'CondactDataGridViewTextBoxColumn
        '
        Me.CondactDataGridViewTextBoxColumn.DataPropertyName = "cond_act"
        Me.CondactDataGridViewTextBoxColumn.HeaderText = "cond_act"
        Me.CondactDataGridViewTextBoxColumn.Name = "CondactDataGridViewTextBoxColumn"
        Me.CondactDataGridViewTextBoxColumn.ReadOnly = True
        Me.CondactDataGridViewTextBoxColumn.Width = 77
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 67
        '
        'SuptipoDataGridViewTextBoxColumn
        '
        Me.SuptipoDataGridViewTextBoxColumn.DataPropertyName = "sup_tipo"
        Me.SuptipoDataGridViewTextBoxColumn.HeaderText = "sup_tipo"
        Me.SuptipoDataGridViewTextBoxColumn.Name = "SuptipoDataGridViewTextBoxColumn"
        Me.SuptipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuptipoDataGridViewTextBoxColumn.Width = 72
        '
        'CiDataGridViewTextBoxColumn
        '
        Me.CiDataGridViewTextBoxColumn.DataPropertyName = "ci"
        Me.CiDataGridViewTextBoxColumn.HeaderText = "ci"
        Me.CiDataGridViewTextBoxColumn.Name = "CiDataGridViewTextBoxColumn"
        Me.CiDataGridViewTextBoxColumn.ReadOnly = True
        Me.CiDataGridViewTextBoxColumn.Width = 40
        '
        'PatDataGridViewTextBoxColumn
        '
        Me.PatDataGridViewTextBoxColumn.DataPropertyName = "pat"
        Me.PatDataGridViewTextBoxColumn.HeaderText = "pat"
        Me.PatDataGridViewTextBoxColumn.Name = "PatDataGridViewTextBoxColumn"
        Me.PatDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatDataGridViewTextBoxColumn.Width = 47
        '
        'MatDataGridViewTextBoxColumn
        '
        Me.MatDataGridViewTextBoxColumn.DataPropertyName = "mat"
        Me.MatDataGridViewTextBoxColumn.HeaderText = "mat"
        Me.MatDataGridViewTextBoxColumn.Name = "MatDataGridViewTextBoxColumn"
        Me.MatDataGridViewTextBoxColumn.ReadOnly = True
        Me.MatDataGridViewTextBoxColumn.Width = 49
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Width = 72
        '
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "cargo"
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        Me.CargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CargoDataGridViewTextBoxColumn.Width = 59
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 86
        '
        'ObsDataGridViewTextBoxColumn
        '
        Me.ObsDataGridViewTextBoxColumn.DataPropertyName = "obs"
        Me.ObsDataGridViewTextBoxColumn.HeaderText = "obs"
        Me.ObsDataGridViewTextBoxColumn.Name = "ObsDataGridViewTextBoxColumn"
        Me.ObsDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsDataGridViewTextBoxColumn.Width = 49
        '
        'FchassDataGridViewTextBoxColumn
        '
        Me.FchassDataGridViewTextBoxColumn.DataPropertyName = "fch_ass"
        Me.FchassDataGridViewTextBoxColumn.HeaderText = "fch_ass"
        Me.FchassDataGridViewTextBoxColumn.Name = "FchassDataGridViewTextBoxColumn"
        Me.FchassDataGridViewTextBoxColumn.ReadOnly = True
        Me.FchassDataGridViewTextBoxColumn.Width = 69
        '
        'ReportesasignacionesBindingSource
        '
        Me.ReportesasignacionesBindingSource.DataMember = "reportes_asignaciones"
        Me.ReportesasignacionesBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.delete
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Reportes_asignacionesTableAdapter
        '
        Me.Reportes_asignacionesTableAdapter.ClearBeforeFill = True
        '
        'LISTA_DE_ASIGNACIONES
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(861, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ActivofDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "LISTA_DE_ASIGNACIONES"
        Me.Text = "LISTA_DE_ASIGNACIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ActivofDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesasignacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ActivofDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents ReportesasignacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reportes_asignacionesTableAdapter As SICAF.sicafDataSetTableAdapters.reportes_asignacionesTableAdapter
    Friend WithEvents CodasingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodafDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesafDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CondactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuptipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FchassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
