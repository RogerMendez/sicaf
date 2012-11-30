<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unidad_registrar
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
        Dim Cod_uniLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cod_uniTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.UnidadTableAdapter = New SICAF.sicafDataSetTableAdapters.unidadTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Cod_uniLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UnidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "Registrar Unidad"
        '
        'Cod_uniLabel
        '
        Cod_uniLabel.AutoSize = True
        Cod_uniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_uniLabel.Location = New System.Drawing.Point(27, 28)
        Cod_uniLabel.Name = "Cod_uniLabel"
        Cod_uniLabel.Size = New System.Drawing.Size(132, 20)
        Cod_uniLabel.TabIndex = 0
        Cod_uniLabel.Text = "Codigo Unidad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(27, 60)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Cod_uniLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_uniTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 233)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Unidad"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(234, 60)
        Me.RichTextBox1.MaxLength = 200
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 96)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(215, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(328, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cod_uniTextBox
        '
        Me.Cod_uniTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cod_uniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadBindingSource, "cod_uni", True))
        Me.Cod_uniTextBox.Location = New System.Drawing.Point(234, 25)
        Me.Cod_uniTextBox.Name = "Cod_uniTextBox"
        Me.Cod_uniTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Cod_uniTextBox.TabIndex = 1
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
        'UnidadTableAdapter
        '
        Me.UnidadTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.oficinaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.tpcambioTableAdapter = Nothing
        Me.TableAdapterManager.unidadTableAdapter = Me.UnidadTableAdapter
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'unidad_registrar
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(502, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "unidad_registrar"
        Me.Text = "Registrar Unidad"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UnidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents UnidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadTableAdapter As SICAF.sicafDataSetTableAdapters.unidadTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cod_uniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
