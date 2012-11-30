<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baja_af_registro
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
        Dim Cod_funLabel As System.Windows.Forms.Label
        Dim MotivoLabel As System.Windows.Forms.Label
        Dim ObsLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cod_actTextBox = New System.Windows.Forms.TextBox()
        Me.BajactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Cod_funTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoTextBox = New System.Windows.Forms.TextBox()
        Me.ObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BajactTableAdapter = New SICAF.sicafDataSetTableAdapters.bajactTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Cod_actLabel = New System.Windows.Forms.Label()
        Cod_funLabel = New System.Windows.Forms.Label()
        MotivoLabel = New System.Windows.Forms.Label()
        ObsLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BajactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(703, 42)
        Me.Label1.Text = "Registro Baja Activo Fijo"
        '
        'Cod_actLabel
        '
        Cod_actLabel.AutoSize = True
        Cod_actLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_actLabel.Location = New System.Drawing.Point(15, 28)
        Cod_actLabel.Name = "Cod_actLabel"
        Cod_actLabel.Size = New System.Drawing.Size(97, 20)
        Cod_actLabel.TabIndex = 2
        Cod_actLabel.Text = "Activo Fijo:"
        '
        'Cod_funLabel
        '
        Cod_funLabel.AutoSize = True
        Cod_funLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_funLabel.Location = New System.Drawing.Point(15, 60)
        Cod_funLabel.Name = "Cod_funLabel"
        Cod_funLabel.Size = New System.Drawing.Size(103, 20)
        Cod_funLabel.TabIndex = 6
        Cod_funLabel.Text = "Funcionario"
        '
        'MotivoLabel
        '
        MotivoLabel.AutoSize = True
        MotivoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotivoLabel.Location = New System.Drawing.Point(15, 92)
        MotivoLabel.Name = "MotivoLabel"
        MotivoLabel.Size = New System.Drawing.Size(66, 20)
        MotivoLabel.TabIndex = 10
        MotivoLabel.Text = "Motivo:"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsLabel.Location = New System.Drawing.Point(15, 124)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(132, 20)
        ObsLabel.TabIndex = 12
        ObsLabel.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Cod_actLabel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Cod_actTextBox)
        Me.GroupBox1.Controls.Add(Cod_funLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_funTextBox)
        Me.GroupBox1.Controls.Add(MotivoLabel)
        Me.GroupBox1.Controls.Add(Me.MotivoTextBox)
        Me.GroupBox1.Controls.Add(ObsLabel)
        Me.GroupBox1.Controls.Add(Me.ObsRichTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 378)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'Button4
        '
        Me.Button4.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(215, 223)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 40)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(363, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 40)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Guardar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 29)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cod_actTextBox
        '
        Me.Cod_actTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cod_actTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BajactBindingSource, "cod_act", True))
        Me.Cod_actTextBox.Enabled = False
        Me.Cod_actTextBox.Location = New System.Drawing.Point(167, 25)
        Me.Cod_actTextBox.Name = "Cod_actTextBox"
        Me.Cod_actTextBox.Size = New System.Drawing.Size(300, 26)
        Me.Cod_actTextBox.TabIndex = 3
        '
        'BajactBindingSource
        '
        Me.BajactBindingSource.DataMember = "bajact"
        Me.BajactBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cod_funTextBox
        '
        Me.Cod_funTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cod_funTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BajactBindingSource, "cod_fun", True))
        Me.Cod_funTextBox.Enabled = False
        Me.Cod_funTextBox.Location = New System.Drawing.Point(167, 57)
        Me.Cod_funTextBox.Name = "Cod_funTextBox"
        Me.Cod_funTextBox.Size = New System.Drawing.Size(300, 26)
        Me.Cod_funTextBox.TabIndex = 7
        '
        'MotivoTextBox
        '
        Me.MotivoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MotivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BajactBindingSource, "motivo", True))
        Me.MotivoTextBox.Location = New System.Drawing.Point(167, 89)
        Me.MotivoTextBox.Name = "MotivoTextBox"
        Me.MotivoTextBox.Size = New System.Drawing.Size(300, 26)
        Me.MotivoTextBox.TabIndex = 11
        '
        'ObsRichTextBox
        '
        Me.ObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BajactBindingSource, "obs", True))
        Me.ObsRichTextBox.Location = New System.Drawing.Point(167, 121)
        Me.ObsRichTextBox.Name = "ObsRichTextBox"
        Me.ObsRichTextBox.Size = New System.Drawing.Size(300, 96)
        Me.ObsRichTextBox.TabIndex = 13
        Me.ObsRichTextBox.Text = ""
        '
        'BajactTableAdapter
        '
        Me.BajactTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.activof_tipoTableAdapter = Nothing
        Me.TableAdapterManager.activofTableAdapter = Nothing
        Me.TableAdapterManager.asignsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bajactTableAdapter = Me.BajactTableAdapter
        Me.TableAdapterManager.cuentacontableTableAdapter = Nothing
        Me.TableAdapterManager.devolTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'baja_af_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "baja_af_registro"
        Me.Text = "baja_af_registro"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BajactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents BajactBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BajactTableAdapter As SICAF.sicafDataSetTableAdapters.bajactTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cod_actTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_funTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
