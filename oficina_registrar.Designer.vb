<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oficina_registrar
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
        Dim Cod_ofiLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Dim PisoLabel As System.Windows.Forms.Label
        Dim Cod_unidLabel As System.Windows.Forms.Label
        Dim Pat_resoLabel As System.Windows.Forms.Label
        Dim Mat_respLabel As System.Windows.Forms.Label
        Dim Nom_resoLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.UnidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Cod_ofiTextBox = New System.Windows.Forms.TextBox()
        Me.OficinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pat_resoTextBox = New System.Windows.Forms.TextBox()
        Me.Mat_respTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_resoTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OficinaTableAdapter = New SICAF.sicafDataSetTableAdapters.oficinaTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.UnidadTableAdapter = New SICAF.sicafDataSetTableAdapters.unidadTableAdapter()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Cod_ofiLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        PisoLabel = New System.Windows.Forms.Label()
        Cod_unidLabel = New System.Windows.Forms.Label()
        Pat_resoLabel = New System.Windows.Forms.Label()
        Mat_respLabel = New System.Windows.Forms.Label()
        Nom_resoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UnidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(516, 42)
        Me.Label1.Text = "Registrar Oficina"
        '
        'Cod_ofiLabel
        '
        Cod_ofiLabel.AutoSize = True
        Cod_ofiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_ofiLabel.Location = New System.Drawing.Point(23, 28)
        Cod_ofiLabel.Name = "Cod_ofiLabel"
        Cod_ofiLabel.Size = New System.Drawing.Size(131, 20)
        Cod_ofiLabel.TabIndex = 0
        Cod_ofiLabel.Text = "Codigo Oficina:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(23, 60)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripcion:"
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UbicacionLabel.Location = New System.Drawing.Point(23, 162)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(93, 20)
        UbicacionLabel.TabIndex = 4
        UbicacionLabel.Text = "Ubicacion:"
        '
        'PisoLabel
        '
        PisoLabel.AutoSize = True
        PisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PisoLabel.Location = New System.Drawing.Point(23, 194)
        PisoLabel.Name = "PisoLabel"
        PisoLabel.Size = New System.Drawing.Size(48, 20)
        PisoLabel.TabIndex = 6
        PisoLabel.Text = "Piso:"
        '
        'Cod_unidLabel
        '
        Cod_unidLabel.AutoSize = True
        Cod_unidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_unidLabel.Location = New System.Drawing.Point(23, 226)
        Cod_unidLabel.Name = "Cod_unidLabel"
        Cod_unidLabel.Size = New System.Drawing.Size(157, 20)
        Cod_unidLabel.TabIndex = 8
        Cod_unidLabel.Text = "Codigo de Unidad:"
        '
        'Pat_resoLabel
        '
        Pat_resoLabel.AutoSize = True
        Pat_resoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pat_resoLabel.Location = New System.Drawing.Point(23, 37)
        Pat_resoLabel.Name = "Pat_resoLabel"
        Pat_resoLabel.Size = New System.Drawing.Size(114, 20)
        Pat_resoLabel.TabIndex = 16
        Pat_resoLabel.Text = "Ape. Paterno"
        '
        'Mat_respLabel
        '
        Mat_respLabel.AutoSize = True
        Mat_respLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mat_respLabel.Location = New System.Drawing.Point(23, 69)
        Mat_respLabel.Name = "Mat_respLabel"
        Mat_respLabel.Size = New System.Drawing.Size(122, 20)
        Mat_respLabel.TabIndex = 18
        Mat_respLabel.Text = "Ape. Materno:"
        '
        'Nom_resoLabel
        '
        Nom_resoLabel.AutoSize = True
        Nom_resoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_resoLabel.Location = New System.Drawing.Point(23, 101)
        Nom_resoLabel.Name = "Nom_resoLabel"
        Nom_resoLabel.Size = New System.Drawing.Size(76, 20)
        Nom_resoLabel.TabIndex = 20
        Nom_resoLabel.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Cod_ofiLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_ofiTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(UbicacionLabel)
        Me.GroupBox1.Controls.Add(Me.UbicacionTextBox)
        Me.GroupBox1.Controls.Add(PisoLabel)
        Me.GroupBox1.Controls.Add(Cod_unidLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 266)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO OFICINA"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.UnidadBindingSource
        Me.ComboBox2.DisplayMember = "cod_uni"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(219, 223)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 28)
        Me.ComboBox2.TabIndex = 11
        '
        'UnidadBindingSource
        '
        Me.UnidadBindingSource.DataMember = "unidad"
        Me.UnidadBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(219, 57)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(225, 96)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"-2", "-1", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.ComboBox1.Location = New System.Drawing.Point(219, 191)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 28)
        Me.ComboBox1.TabIndex = 10
        '
        'Cod_ofiTextBox
        '
        Me.Cod_ofiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cod_ofiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinaBindingSource, "cod_ofi", True))
        Me.Cod_ofiTextBox.Location = New System.Drawing.Point(219, 25)
        Me.Cod_ofiTextBox.Name = "Cod_ofiTextBox"
        Me.Cod_ofiTextBox.Size = New System.Drawing.Size(225, 26)
        Me.Cod_ofiTextBox.TabIndex = 1
        '
        'OficinaBindingSource
        '
        Me.OficinaBindingSource.DataMember = "oficina"
        Me.OficinaBindingSource.DataSource = Me.SicafDataSet
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinaBindingSource, "ubicacion", True))
        Me.UbicacionTextBox.Location = New System.Drawing.Point(219, 159)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(225, 26)
        Me.UbicacionTextBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Pat_resoLabel)
        Me.GroupBox2.Controls.Add(Me.Pat_resoTextBox)
        Me.GroupBox2.Controls.Add(Mat_respLabel)
        Me.GroupBox2.Controls.Add(Me.Mat_respTextBox)
        Me.GroupBox2.Controls.Add(Nom_resoLabel)
        Me.GroupBox2.Controls.Add(Me.Nom_resoTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 183)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS RESPONSABLE"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(204, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 41)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(335, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 41)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pat_resoTextBox
        '
        Me.Pat_resoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pat_resoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinaBindingSource, "pat_reso", True))
        Me.Pat_resoTextBox.Location = New System.Drawing.Point(219, 34)
        Me.Pat_resoTextBox.Name = "Pat_resoTextBox"
        Me.Pat_resoTextBox.Size = New System.Drawing.Size(225, 26)
        Me.Pat_resoTextBox.TabIndex = 17
        '
        'Mat_respTextBox
        '
        Me.Mat_respTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mat_respTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinaBindingSource, "mat_resp", True))
        Me.Mat_respTextBox.Location = New System.Drawing.Point(219, 66)
        Me.Mat_respTextBox.Name = "Mat_respTextBox"
        Me.Mat_respTextBox.Size = New System.Drawing.Size(225, 26)
        Me.Mat_respTextBox.TabIndex = 19
        '
        'Nom_resoTextBox
        '
        Me.Nom_resoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nom_resoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinaBindingSource, "nom_reso", True))
        Me.Nom_resoTextBox.Location = New System.Drawing.Point(219, 98)
        Me.Nom_resoTextBox.Name = "Nom_resoTextBox"
        Me.Nom_resoTextBox.Size = New System.Drawing.Size(225, 26)
        Me.Nom_resoTextBox.TabIndex = 21
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'OficinaTableAdapter
        '
        Me.OficinaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.activofTableAdapter = Nothing
        Me.TableAdapterManager.asignsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bajactTableAdapter = Nothing
        'Me.TableAdapterManager.cuentasTableAdapter = Nothing
        Me.TableAdapterManager.devolTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        'Me.TableAdapterManager.grupoTableAdapter = Nothing
        Me.TableAdapterManager.mantenimientoTableAdapter = Nothing
        'Me.TableAdapterManager.mayoresTableAdapter = Nothing
        Me.TableAdapterManager.oficinaTableAdapter = Me.OficinaTableAdapter
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.tpcambioTableAdapter = Nothing
        Me.TableAdapterManager.unidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'UnidadTableAdapter
        '
        Me.UnidadTableAdapter.ClearBeforeFill = True
        '
        'oficina_registrar
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(540, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "oficina_registrar"
        Me.Text = "Registrar Oficina"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UnidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents OficinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OficinaTableAdapter As SICAF.sicafDataSetTableAdapters.oficinaTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cod_ofiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Pat_resoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mat_respTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_resoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadTableAdapter As SICAF.sicafDataSetTableAdapters.unidadTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
