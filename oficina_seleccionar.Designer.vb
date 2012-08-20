<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oficina_seleccionar
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
        Me.OficinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.OficinaTableAdapter = New SICAF.sicafDataSetTableAdapters.oficinaTableAdapter()
        Me.CodofiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodunidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pat_reso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(822, 42)
        Me.Label1.Text = "Seleccionar Oficina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ubicación/Descripción:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(227, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(436, 26)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodofiDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CodunidDataGridViewTextBoxColumn, Me.pat_reso, Me.NomresoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OficinaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 94)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(815, 321)
        Me.DataGridView1.TabIndex = 3
        '
        'OficinaBindingSource
        '
        Me.OficinaBindingSource.DataMember = "oficina"
        Me.OficinaBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OficinaTableAdapter
        '
        Me.OficinaTableAdapter.ClearBeforeFill = True
        '
        'CodofiDataGridViewTextBoxColumn
        '
        Me.CodofiDataGridViewTextBoxColumn.DataPropertyName = "cod_ofi"
        Me.CodofiDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodofiDataGridViewTextBoxColumn.Name = "CodofiDataGridViewTextBoxColumn"
        Me.CodofiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.MaxInputLength = 30
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodunidDataGridViewTextBoxColumn
        '
        Me.CodunidDataGridViewTextBoxColumn.DataPropertyName = "cod_unid"
        Me.CodunidDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.CodunidDataGridViewTextBoxColumn.Name = "CodunidDataGridViewTextBoxColumn"
        Me.CodunidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'pat_reso
        '
        Me.pat_reso.DataPropertyName = "pat_reso"
        Me.pat_reso.HeaderText = "Paterno Res."
        Me.pat_reso.Name = "pat_reso"
        Me.pat_reso.ReadOnly = True
        '
        'NomresoDataGridViewTextBoxColumn
        '
        Me.NomresoDataGridViewTextBoxColumn.DataPropertyName = "nom_reso"
        Me.NomresoDataGridViewTextBoxColumn.HeaderText = "Nombre Res."
        Me.NomresoDataGridViewTextBoxColumn.Name = "NomresoDataGridViewTextBoxColumn"
        Me.NomresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'oficina_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 451)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "oficina_seleccionar"
        Me.Text = "oficina_seleccionar"
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents OficinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OficinaTableAdapter As SICAF.sicafDataSetTableAdapters.oficinaTableAdapter
    Friend WithEvents CodofiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodunidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pat_reso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
