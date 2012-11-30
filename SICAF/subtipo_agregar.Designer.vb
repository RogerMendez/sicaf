<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subtipo_agregar
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubtipoDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigosubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TipoTableAdapter = New SICAF.sicafDataSetTableAdapters.tipoTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SubtipoTableAdapter = New SICAF.sicafDataSetTableAdapters.subtipoTableAdapter()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SubtipoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubtipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(596, 42)
        Me.Label1.Text = "Agregar Quitar Subtipos"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(16, 39)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(115, 20)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre Tipo:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel1.Location = New System.Drawing.Point(16, 28)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(147, 20)
        NombreLabel1.TabIndex = 0
        NombreLabel1.Text = "Nombre SubTipo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.NombreComboBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 117)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccion Tipo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoBindingSource, "nombre", True))
        Me.NombreComboBox.DataSource = Me.TipoBindingSource
        Me.NombreComboBox.DisplayMember = "nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(180, 36)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(225, 28)
        Me.NombreComboBox.TabIndex = 3
        Me.NombreComboBox.ValueMember = "codigo"
        '
        'TipoBindingSource
        '
        Me.TipoBindingSource.DataMember = "tipo"
        Me.TipoBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.SubtipoDataGridView)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(NombreLabel1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 327)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Subtipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaShell
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SubTipos En El Tipo"
        '
        'SubtipoDataGridView
        '
        Me.SubtipoDataGridView.AllowUserToAddRows = False
        Me.SubtipoDataGridView.AllowUserToDeleteRows = False
        Me.SubtipoDataGridView.AllowUserToOrderColumns = True
        Me.SubtipoDataGridView.AutoGenerateColumns = False
        Me.SubtipoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SubtipoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubtipoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigosubDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.SubtipoDataGridView.DataSource = Me.SubtipoBindingSource
        Me.SubtipoDataGridView.Location = New System.Drawing.Point(7, 120)
        Me.SubtipoDataGridView.MultiSelect = False
        Me.SubtipoDataGridView.Name = "SubtipoDataGridView"
        Me.SubtipoDataGridView.ReadOnly = True
        Me.SubtipoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SubtipoDataGridView.Size = New System.Drawing.Size(422, 201)
        Me.SubtipoDataGridView.TabIndex = 7
        '
        'CodigosubDataGridViewTextBoxColumn
        '
        Me.CodigosubDataGridViewTextBoxColumn.DataPropertyName = "codigosub"
        Me.CodigosubDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigosubDataGridViewTextBoxColumn.Name = "CodigosubDataGridViewTextBoxColumn"
        Me.CodigosubDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigosubDataGridViewTextBoxColumn.Width = 84
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 90
        '
        'SubtipoBindingSource
        '
        Me.SubtipoBindingSource.DataMember = "subtipo"
        Me.SubtipoBindingSource.DataSource = Me.SicafDataSet
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(180, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 26)
        Me.TextBox2.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.Add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(311, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TipoTableAdapter
        '
        Me.TipoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.activof_tipoTableAdapter = Nothing
        Me.TableAdapterManager.activofTableAdapter = Nothing
        Me.TableAdapterManager.asignsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bajactTableAdapter = Nothing
        Me.TableAdapterManager.cuentacontableTableAdapter = Nothing
        Me.TableAdapterManager.devolTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.mantenimientoTableAdapter = Nothing
        Me.TableAdapterManager.oficinaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.revaluosTableAdapter = Nothing
        Me.TableAdapterManager.subtipoTableAdapter = Nothing
        Me.TableAdapterManager.tipoTableAdapter = Me.TipoTableAdapter
        Me.TableAdapterManager.tpcambioTableAdapter = Nothing
        Me.TableAdapterManager.unidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SubtipoTableAdapter
        '
        Me.SubtipoTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SICAF.My.Resources.Resources.delete1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(453, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 46)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Salir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'subtipo_agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 556)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "subtipo_agregar"
        Me.Text = "subtipo_agregar"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SubtipoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubtipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubtipoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents TipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoTableAdapter As SICAF.sicafDataSetTableAdapters.tipoTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SubtipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubtipoTableAdapter As SICAF.sicafDataSetTableAdapters.subtipoTableAdapter
    Friend WithEvents CodigosubDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
