<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activos_asignados_unidad
    Inherits plantillaform

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.CodafDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoduniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSubtipoADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FAsignacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UDecripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignacionunidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Asignacion_unidadTableAdapter = New SICAF.sicafDataSetTableAdapters.asignacion_unidadTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignacionunidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(562, 42)
        Me.Label1.Text = "Activos Asignados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodafDataGridViewTextBoxColumn, Me.CoduniDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.TipoSubtipoADataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FAsignacionDataGridViewTextBoxColumn, Me.UDecripcionDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AsignacionunidadBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(562, 339)
        Me.DataGridView1.TabIndex = 1
        '
        'Cancelar
        '
        Me.Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancelar.Location = New System.Drawing.Point(349, 404)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(109, 37)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'CodafDataGridViewTextBoxColumn
        '
        Me.CodafDataGridViewTextBoxColumn.DataPropertyName = "codaf"
        Me.CodafDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.CodafDataGridViewTextBoxColumn.Name = "CodafDataGridViewTextBoxColumn"
        Me.CodafDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodafDataGridViewTextBoxColumn.Width = 77
        '
        'CoduniDataGridViewTextBoxColumn
        '
        Me.CoduniDataGridViewTextBoxColumn.DataPropertyName = "cod_uni"
        Me.CoduniDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.CoduniDataGridViewTextBoxColumn.Name = "CoduniDataGridViewTextBoxColumn"
        Me.CoduniDataGridViewTextBoxColumn.ReadOnly = True
        Me.CoduniDataGridViewTextBoxColumn.Width = 85
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 117
        '
        'TipoSubtipoADataGridViewTextBoxColumn
        '
        Me.TipoSubtipoADataGridViewTextBoxColumn.DataPropertyName = "Tipo - Subtipo A_"
        Me.TipoSubtipoADataGridViewTextBoxColumn.HeaderText = "Tipo - Subtipo A_"
        Me.TipoSubtipoADataGridViewTextBoxColumn.Name = "TipoSubtipoADataGridViewTextBoxColumn"
        Me.TipoSubtipoADataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoSubtipoADataGridViewTextBoxColumn.Width = 124
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CedulaDataGridViewTextBoxColumn.Width = 84
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 90
        '
        'FAsignacionDataGridViewTextBoxColumn
        '
        Me.FAsignacionDataGridViewTextBoxColumn.DataPropertyName = "F_ Asignacion"
        Me.FAsignacionDataGridViewTextBoxColumn.HeaderText = "F_ Asignacion"
        Me.FAsignacionDataGridViewTextBoxColumn.Name = "FAsignacionDataGridViewTextBoxColumn"
        Me.FAsignacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FAsignacionDataGridViewTextBoxColumn.Width = 123
        '
        'UDecripcionDataGridViewTextBoxColumn
        '
        Me.UDecripcionDataGridViewTextBoxColumn.DataPropertyName = "U_ Decripcion"
        Me.UDecripcionDataGridViewTextBoxColumn.HeaderText = "U_ Decripcion"
        Me.UDecripcionDataGridViewTextBoxColumn.Name = "UDecripcionDataGridViewTextBoxColumn"
        Me.UDecripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UDecripcionDataGridViewTextBoxColumn.Width = 123
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionDataGridViewTextBoxColumn.Width = 122
        '
        'AsignacionunidadBindingSource
        '
        Me.AsignacionunidadBindingSource.DataMember = "asignacion_unidad"
        Me.AsignacionunidadBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Asignacion_unidadTableAdapter
        '
        Me.Asignacion_unidadTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(464, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'activos_asignados_unidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 451)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "activos_asignados_unidad"
        Me.Text = "activos_asignados_unidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Cancelar, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignacionunidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents AsignacionunidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Asignacion_unidadTableAdapter As SICAF.sicafDataSetTableAdapters.asignacion_unidadTableAdapter
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents CodafDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoduniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoSubtipoADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAsignacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UDecripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
