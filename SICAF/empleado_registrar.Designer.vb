<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado_registrar
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
        Dim PatLabel As System.Windows.Forms.Label
        Dim MatLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim Cod_uniLabel As System.Windows.Forms.Label
        Dim Telf_funLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New SICAF.sicafDataSetTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UnidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CiTextBox = New System.Windows.Forms.TextBox()
        Me.PatTextBox = New System.Windows.Forms.TextBox()
        Me.MatTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.Telf_funTextBox = New System.Windows.Forms.TextBox()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Me.UnidadTableAdapter = New SICAF.sicafDataSetTableAdapters.unidadTableAdapter()
        CiLabel = New System.Windows.Forms.Label()
        PatLabel = New System.Windows.Forms.Label()
        MatLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        Cod_uniLabel = New System.Windows.Forms.Label()
        Telf_funLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UnidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(643, 42)
        Me.Label1.Text = "Registrar Funcionario"
        '
        'CiLabel
        '
        CiLabel.AutoSize = True
        CiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiLabel.Location = New System.Drawing.Point(24, 45)
        CiLabel.Name = "CiLabel"
        CiLabel.Size = New System.Drawing.Size(177, 20)
        CiLabel.TabIndex = 16
        CiLabel.Text = "Carnet De Identidad:"
        '
        'PatLabel
        '
        PatLabel.AutoSize = True
        PatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PatLabel.Location = New System.Drawing.Point(24, 77)
        PatLabel.Name = "PatLabel"
        PatLabel.Size = New System.Drawing.Size(119, 20)
        PatLabel.TabIndex = 18
        PatLabel.Text = "Ape. Paterno:"
        '
        'MatLabel
        '
        MatLabel.AutoSize = True
        MatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatLabel.Location = New System.Drawing.Point(24, 109)
        MatLabel.Name = "MatLabel"
        MatLabel.Size = New System.Drawing.Size(122, 20)
        MatLabel.TabIndex = 20
        MatLabel.Text = "Ape. Materno:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.Location = New System.Drawing.Point(24, 141)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(85, 20)
        NombresLabel.TabIndex = 22
        NombresLabel.Text = "Nombres:"
        '
        'Cod_uniLabel
        '
        Cod_uniLabel.AutoSize = True
        Cod_uniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_uniLabel.Location = New System.Drawing.Point(24, 173)
        Cod_uniLabel.Name = "Cod_uniLabel"
        Cod_uniLabel.Size = New System.Drawing.Size(71, 20)
        Cod_uniLabel.TabIndex = 24
        Cod_uniLabel.Text = "Unidad:"
        '
        'Telf_funLabel
        '
        Telf_funLabel.AutoSize = True
        Telf_funLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telf_funLabel.Location = New System.Drawing.Point(24, 205)
        Telf_funLabel.Name = "Telf_funLabel"
        Telf_funLabel.Size = New System.Drawing.Size(145, 20)
        Telf_funLabel.TabIndex = 26
        Telf_funLabel.Text = "Telefono/Celular:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.Location = New System.Drawing.Point(24, 237)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(62, 20)
        CargoLabel.TabIndex = 28
        CargoLabel.Text = "Cargo:"
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.SicafDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.mantenimientoTableAdapter = Nothing
        Me.TableAdapterManager.oficinaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.revaluosTableAdapter = Nothing
        Me.TableAdapterManager.subtipoTableAdapter = Nothing
        Me.TableAdapterManager.tipoTableAdapter = Nothing
        Me.TableAdapterManager.tpcambioTableAdapter = Nothing
        Me.TableAdapterManager.unidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(CiLabel)
        Me.GroupBox1.Controls.Add(Me.CiTextBox)
        Me.GroupBox1.Controls.Add(PatLabel)
        Me.GroupBox1.Controls.Add(Me.PatTextBox)
        Me.GroupBox1.Controls.Add(MatLabel)
        Me.GroupBox1.Controls.Add(Me.MatTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Cod_uniLabel)
        Me.GroupBox1.Controls.Add(Telf_funLabel)
        Me.GroupBox1.Controls.Add(Me.Telf_funTextBox)
        Me.GroupBox1.Controls.Add(CargoLabel)
        Me.GroupBox1.Controls.Add(Me.CargoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 340)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(223, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(223, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(223, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(223, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(223, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(307, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Campos Requeridos    *"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UnidadBindingSource
        Me.ComboBox1.DisplayMember = "cod_uni"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(246, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 28)
        Me.ComboBox1.TabIndex = 32
        '
        'UnidadBindingSource
        '
        Me.UnidadBindingSource.DataMember = "unidad"
        Me.UnidadBindingSource.DataSource = Me.SicafDataSet
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(246, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 43)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(377, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 43)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CiTextBox
        '
        Me.CiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "ci", True))
        Me.CiTextBox.Location = New System.Drawing.Point(246, 42)
        Me.CiTextBox.Name = "CiTextBox"
        Me.CiTextBox.Size = New System.Drawing.Size(240, 26)
        Me.CiTextBox.TabIndex = 17
        '
        'PatTextBox
        '
        Me.PatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "pat", True))
        Me.PatTextBox.Location = New System.Drawing.Point(246, 74)
        Me.PatTextBox.Name = "PatTextBox"
        Me.PatTextBox.Size = New System.Drawing.Size(240, 26)
        Me.PatTextBox.TabIndex = 19
        '
        'MatTextBox
        '
        Me.MatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "mat", True))
        Me.MatTextBox.Location = New System.Drawing.Point(246, 106)
        Me.MatTextBox.Name = "MatTextBox"
        Me.MatTextBox.Size = New System.Drawing.Size(240, 26)
        Me.MatTextBox.TabIndex = 21
        '
        'NombresTextBox
        '
        Me.NombresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(246, 138)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(240, 26)
        Me.NombresTextBox.TabIndex = 23
        '
        'Telf_funTextBox
        '
        Me.Telf_funTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telf_funTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "telf_fun", True))
        Me.Telf_funTextBox.Location = New System.Drawing.Point(246, 202)
        Me.Telf_funTextBox.Name = "Telf_funTextBox"
        Me.Telf_funTextBox.Size = New System.Drawing.Size(240, 26)
        Me.Telf_funTextBox.TabIndex = 27
        '
        'CargoTextBox
        '
        Me.CargoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(246, 234)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(240, 26)
        Me.CargoTextBox.TabIndex = 29
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UnidadTableAdapter
        '
        Me.UnidadTableAdapter.ClearBeforeFill = True
        '
        'empleado_registrar
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(667, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "empleado_registrar"
        Me.Text = "empleado_registrar"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UnidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As SICAF.sicafDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telf_funTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UnidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadTableAdapter As SICAF.sicafDataSetTableAdapters.unidadTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
