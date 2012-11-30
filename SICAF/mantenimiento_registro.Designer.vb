<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_registro
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
        Dim Cod_actLabel As System.Windows.Forms.Label
        Dim Fech_manLabel As System.Windows.Forms.Label
        Dim Fech_retLabel As System.Windows.Forms.Label
        Dim Desc_manLabel As System.Windows.Forms.Label
        Dim Tipo_manLabel As System.Windows.Forms.Label
        Dim Cost_partLabel As System.Windows.Forms.Label
        Dim Cost_manLabel As System.Windows.Forms.Label
        Dim Pers_manLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cod_actTextBox = New System.Windows.Forms.TextBox()
        Me.MantenimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Fech_manDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fech_retDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Desc_manRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Cost_partTextBox = New System.Windows.Forms.TextBox()
        Me.Cost_manTextBox = New System.Windows.Forms.TextBox()
        Me.Pers_manTextBox = New System.Windows.Forms.TextBox()
        Me.MantenimientoTableAdapter = New SICAF.sicafDataSetTableAdapters.mantenimientoTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Cod_actLabel = New System.Windows.Forms.Label()
        Fech_manLabel = New System.Windows.Forms.Label()
        Fech_retLabel = New System.Windows.Forms.Label()
        Desc_manLabel = New System.Windows.Forms.Label()
        Tipo_manLabel = New System.Windows.Forms.Label()
        Cost_partLabel = New System.Windows.Forms.Label()
        Cost_manLabel = New System.Windows.Forms.Label()
        Pers_manLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MantenimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(744, 42)
        Me.Label1.Text = "Registro De Mantenimiento"
        '
        'Cod_actLabel
        '
        Cod_actLabel.AutoSize = True
        Cod_actLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_actLabel.Location = New System.Drawing.Point(18, 64)
        Cod_actLabel.Name = "Cod_actLabel"
        Cod_actLabel.Size = New System.Drawing.Size(145, 20)
        Cod_actLabel.TabIndex = 2
        Cod_actLabel.Text = "Codigo Activo F.:"
        '
        'Fech_manLabel
        '
        Fech_manLabel.AutoSize = True
        Fech_manLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fech_manLabel.Location = New System.Drawing.Point(18, 97)
        Fech_manLabel.Name = "Fech_manLabel"
        Fech_manLabel.Size = New System.Drawing.Size(187, 20)
        Fech_manLabel.TabIndex = 4
        Fech_manLabel.Text = "Fecha Mantenimiento:"
        '
        'Fech_retLabel
        '
        Fech_retLabel.AutoSize = True
        Fech_retLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fech_retLabel.Location = New System.Drawing.Point(18, 129)
        Fech_retLabel.Name = "Fech_retLabel"
        Fech_retLabel.Size = New System.Drawing.Size(157, 20)
        Fech_retLabel.TabIndex = 6
        Fech_retLabel.Text = "Fecha Conclusion:"
        '
        'Desc_manLabel
        '
        Desc_manLabel.AutoSize = True
        Desc_manLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Desc_manLabel.Location = New System.Drawing.Point(18, 160)
        Desc_manLabel.Name = "Desc_manLabel"
        Desc_manLabel.Size = New System.Drawing.Size(108, 20)
        Desc_manLabel.TabIndex = 8
        Desc_manLabel.Text = "Descripcion:"
        '
        'Tipo_manLabel
        '
        Tipo_manLabel.AutoSize = True
        Tipo_manLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_manLabel.Location = New System.Drawing.Point(18, 262)
        Tipo_manLabel.Name = "Tipo_manLabel"
        Tipo_manLabel.Size = New System.Drawing.Size(171, 20)
        Tipo_manLabel.TabIndex = 10
        Tipo_manLabel.Text = "Tipo Mantenimiento:"
        '
        'Cost_partLabel
        '
        Cost_partLabel.AutoSize = True
        Cost_partLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cost_partLabel.Location = New System.Drawing.Point(18, 294)
        Cost_partLabel.Name = "Cost_partLabel"
        Cost_partLabel.Size = New System.Drawing.Size(118, 20)
        Cost_partLabel.TabIndex = 12
        Cost_partLabel.Text = "Costo Partes:"
        '
        'Cost_manLabel
        '
        Cost_manLabel.AutoSize = True
        Cost_manLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cost_manLabel.Location = New System.Drawing.Point(18, 326)
        Cost_manLabel.Name = "Cost_manLabel"
        Cost_manLabel.Size = New System.Drawing.Size(184, 20)
        Cost_manLabel.TabIndex = 14
        Cost_manLabel.Text = "Costo Mantenimiento:"
        '
        'Pers_manLabel
        '
        Pers_manLabel.AutoSize = True
        Pers_manLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pers_manLabel.Location = New System.Drawing.Point(18, 358)
        Pers_manLabel.Name = "Pers_manLabel"
        Pers_manLabel.Size = New System.Drawing.Size(232, 20)
        Pers_manLabel.TabIndex = 16
        Pers_manLabel.Text = "Personal de Mantenimiento:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Cod_actLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_actTextBox)
        Me.GroupBox1.Controls.Add(Fech_manLabel)
        Me.GroupBox1.Controls.Add(Me.Fech_manDateTimePicker)
        Me.GroupBox1.Controls.Add(Fech_retLabel)
        Me.GroupBox1.Controls.Add(Me.Fech_retDateTimePicker)
        Me.GroupBox1.Controls.Add(Desc_manLabel)
        Me.GroupBox1.Controls.Add(Me.Desc_manRichTextBox)
        Me.GroupBox1.Controls.Add(Tipo_manLabel)
        Me.GroupBox1.Controls.Add(Cost_partLabel)
        Me.GroupBox1.Controls.Add(Me.Cost_partTextBox)
        Me.GroupBox1.Controls.Add(Cost_manLabel)
        Me.GroupBox1.Controls.Add(Me.Cost_manTextBox)
        Me.GroupBox1.Controls.Add(Pers_manLabel)
        Me.GroupBox1.Controls.Add(Me.Pers_manTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 453)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MANTENIMIENTO", "REPARACION", "CAMBIO DE REPUESTOS", "OTROS"})
        Me.ComboBox1.Location = New System.Drawing.Point(284, 259)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(251, 28)
        Me.ComboBox1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(261, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(261, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(261, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(261, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(261, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(261, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(260, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Campos Requeridos    *"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(284, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 29)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 27)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cod_actTextBox
        '
        Me.Cod_actTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MantenimientoBindingSource, "cod_act", True))
        Me.Cod_actTextBox.Enabled = False
        Me.Cod_actTextBox.Location = New System.Drawing.Point(284, 61)
        Me.Cod_actTextBox.Name = "Cod_actTextBox"
        Me.Cod_actTextBox.Size = New System.Drawing.Size(251, 26)
        Me.Cod_actTextBox.TabIndex = 3
        '
        'MantenimientoBindingSource
        '
        Me.MantenimientoBindingSource.DataMember = "mantenimiento"
        Me.MantenimientoBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fech_manDateTimePicker
        '
        Me.Fech_manDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MantenimientoBindingSource, "fech_man", True))
        Me.Fech_manDateTimePicker.Location = New System.Drawing.Point(284, 93)
        Me.Fech_manDateTimePicker.Name = "Fech_manDateTimePicker"
        Me.Fech_manDateTimePicker.Size = New System.Drawing.Size(251, 26)
        Me.Fech_manDateTimePicker.TabIndex = 5
        '
        'Fech_retDateTimePicker
        '
        Me.Fech_retDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MantenimientoBindingSource, "fech_ret", True))
        Me.Fech_retDateTimePicker.Location = New System.Drawing.Point(284, 125)
        Me.Fech_retDateTimePicker.Name = "Fech_retDateTimePicker"
        Me.Fech_retDateTimePicker.Size = New System.Drawing.Size(251, 26)
        Me.Fech_retDateTimePicker.TabIndex = 7
        '
        'Desc_manRichTextBox
        '
        Me.Desc_manRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MantenimientoBindingSource, "desc_man", True))
        Me.Desc_manRichTextBox.Location = New System.Drawing.Point(284, 157)
        Me.Desc_manRichTextBox.Name = "Desc_manRichTextBox"
        Me.Desc_manRichTextBox.Size = New System.Drawing.Size(251, 96)
        Me.Desc_manRichTextBox.TabIndex = 9
        Me.Desc_manRichTextBox.Text = ""
        '
        'Cost_partTextBox
        '
        Me.Cost_partTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MantenimientoBindingSource, "cost_part", True))
        Me.Cost_partTextBox.Location = New System.Drawing.Point(284, 291)
        Me.Cost_partTextBox.Name = "Cost_partTextBox"
        Me.Cost_partTextBox.Size = New System.Drawing.Size(251, 26)
        Me.Cost_partTextBox.TabIndex = 13
        '
        'Cost_manTextBox
        '
        Me.Cost_manTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MantenimientoBindingSource, "cost_man", True))
        Me.Cost_manTextBox.Location = New System.Drawing.Point(284, 323)
        Me.Cost_manTextBox.Name = "Cost_manTextBox"
        Me.Cost_manTextBox.Size = New System.Drawing.Size(251, 26)
        Me.Cost_manTextBox.TabIndex = 15
        '
        'Pers_manTextBox
        '
        Me.Pers_manTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MantenimientoBindingSource, "pers_man", True))
        Me.Pers_manTextBox.Location = New System.Drawing.Point(284, 355)
        Me.Pers_manTextBox.Name = "Pers_manTextBox"
        Me.Pers_manTextBox.Size = New System.Drawing.Size(251, 26)
        Me.Pers_manTextBox.TabIndex = 17
        '
        'MantenimientoTableAdapter
        '
        Me.MantenimientoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.mantenimientoTableAdapter = Me.MantenimientoTableAdapter
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'mantenimiento_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 545)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mantenimiento_registro"
        Me.Text = "mantenimiento_registro"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MantenimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents MantenimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MantenimientoTableAdapter As SICAF.sicafDataSetTableAdapters.mantenimientoTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cod_actTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fech_manDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fech_retDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desc_manRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Cost_partTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cost_manTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pers_manTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
