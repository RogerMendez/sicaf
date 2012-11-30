<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devolucion_registro
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
        Dim CiLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CiTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoAFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSubTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuncionarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MostrarasignacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Mostrar_asignacionesTableAdapter = New SICAF.sicafDataSetTableAdapters.mostrar_asignacionesTableAdapter()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        CiLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarasignacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(693, 42)
        Me.Label1.Text = "Registro Devolución"
        '
        'CiLabel
        '
        CiLabel.AutoSize = True
        CiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiLabel.Location = New System.Drawing.Point(24, 28)
        CiLabel.Name = "CiLabel"
        CiLabel.Size = New System.Drawing.Size(177, 20)
        CiLabel.TabIndex = 18
        CiLabel.Text = "Carnet De Identidad:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(CiLabel)
        Me.GroupBox2.Controls.Add(Me.CiTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 96)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Funcionario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(457, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(492, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CiTextBox
        '
        Me.CiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CiTextBox.Enabled = False
        Me.CiTextBox.Location = New System.Drawing.Point(246, 25)
        Me.CiTextBox.Name = "CiTextBox"
        Me.CiTextBox.Size = New System.Drawing.Size(240, 26)
        Me.CiTextBox.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoAFDataGridViewTextBoxColumn, Me.NombreTipoDataGridViewTextBoxColumn, Me.NombreSubTipoDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.FuncionarioDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn, Me.FechaAsignaciónDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MostrarasignacionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 161)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(693, 185)
        Me.DataGridView1.TabIndex = 6
        '
        'CodigoAFDataGridViewTextBoxColumn
        '
        Me.CodigoAFDataGridViewTextBoxColumn.DataPropertyName = "Codigo A_ F_"
        Me.CodigoAFDataGridViewTextBoxColumn.HeaderText = "Codigo A. F."
        Me.CodigoAFDataGridViewTextBoxColumn.Name = "CodigoAFDataGridViewTextBoxColumn"
        Me.CodigoAFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoAFDataGridViewTextBoxColumn.Width = 98
        '
        'NombreTipoDataGridViewTextBoxColumn
        '
        Me.NombreTipoDataGridViewTextBoxColumn.DataPropertyName = "Nombre Tipo"
        Me.NombreTipoDataGridViewTextBoxColumn.HeaderText = "Nombre Tipo"
        Me.NombreTipoDataGridViewTextBoxColumn.Name = "NombreTipoDataGridViewTextBoxColumn"
        Me.NombreTipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreTipoDataGridViewTextBoxColumn.Width = 114
        '
        'NombreSubTipoDataGridViewTextBoxColumn
        '
        Me.NombreSubTipoDataGridViewTextBoxColumn.DataPropertyName = "Nombre SubTipo"
        Me.NombreSubTipoDataGridViewTextBoxColumn.HeaderText = "Nombre SubTipo"
        Me.NombreSubTipoDataGridViewTextBoxColumn.Name = "NombreSubTipoDataGridViewTextBoxColumn"
        Me.NombreSubTipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreSubTipoDataGridViewTextBoxColumn.Width = 140
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadDataGridViewTextBoxColumn.Width = 85
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Width = 78
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CedulaDataGridViewTextBoxColumn.Width = 84
        '
        'FuncionarioDataGridViewTextBoxColumn
        '
        Me.FuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Funcionario"
        Me.FuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario"
        Me.FuncionarioDataGridViewTextBoxColumn.Name = "FuncionarioDataGridViewTextBoxColumn"
        Me.FuncionarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FuncionarioDataGridViewTextBoxColumn.Width = 117
        '
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "Cargo F."
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        Me.CargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CargoDataGridViewTextBoxColumn.Width = 88
        '
        'FechaAsignaciónDataGridViewTextBoxColumn
        '
        Me.FechaAsignaciónDataGridViewTextBoxColumn.DataPropertyName = "Fecha Asignación"
        Me.FechaAsignaciónDataGridViewTextBoxColumn.HeaderText = "Fecha Asignación"
        Me.FechaAsignaciónDataGridViewTextBoxColumn.Name = "FechaAsignaciónDataGridViewTextBoxColumn"
        Me.FechaAsignaciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAsignaciónDataGridViewTextBoxColumn.Width = 147
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionDataGridViewTextBoxColumn.Width = 122
        '
        'MostrarasignacionesBindingSource
        '
        Me.MostrarasignacionesBindingSource.DataMember = "mostrar_asignaciones"
        Me.MostrarasignacionesBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mostrar_asignacionesTableAdapter
        '
        Me.Mostrar_asignacionesTableAdapter.ClearBeforeFill = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(181, 352)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(201, 96)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Observaciones:"
        '
        'Button4
        '
        Me.Button4.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(388, 407)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 30)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Devolucion"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(394, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'devolucion_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 451)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "devolucion_registro"
        Me.Text = "devolucion_registro"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.RichTextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarasignacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents MostrarasignacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_asignacionesTableAdapter As SICAF.sicafDataSetTableAdapters.mostrar_asignacionesTableAdapter
    Friend WithEvents CodigoAFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreSubTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FuncionarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignaciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
