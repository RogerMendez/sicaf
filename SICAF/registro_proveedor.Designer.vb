<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_proveedor
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
        Dim NitLabel As System.Windows.Forms.Label
        Dim Nom_proLabel As System.Windows.Forms.Label
        Dim Dir_provLabel As System.Windows.Forms.Label
        Dim Tel_provLabel As System.Windows.Forms.Label
        Dim Wev_provLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Nom_proTextBox = New System.Windows.Forms.TextBox()
        Me.Dir_provTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_provTextBox = New System.Windows.Forms.TextBox()
        Me.Wev_provTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedoresTableAdapter = New SICAF.sicafDataSetTableAdapters.proveedoresTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        NitLabel = New System.Windows.Forms.Label()
        Nom_proLabel = New System.Windows.Forms.Label()
        Dir_provLabel = New System.Windows.Forms.Label()
        Tel_provLabel = New System.Windows.Forms.Label()
        Wev_provLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "Registro Proveedor"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NitLabel.Location = New System.Drawing.Point(15, 48)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(42, 20)
        NitLabel.TabIndex = 0
        NitLabel.Text = "NIT:"
        '
        'Nom_proLabel
        '
        Nom_proLabel.AutoSize = True
        Nom_proLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_proLabel.Location = New System.Drawing.Point(15, 80)
        Nom_proLabel.Name = "Nom_proLabel"
        Nom_proLabel.Size = New System.Drawing.Size(76, 20)
        Nom_proLabel.TabIndex = 2
        Nom_proLabel.Text = "Nombre:"
        '
        'Dir_provLabel
        '
        Dir_provLabel.AutoSize = True
        Dir_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dir_provLabel.Location = New System.Drawing.Point(15, 112)
        Dir_provLabel.Name = "Dir_provLabel"
        Dir_provLabel.Size = New System.Drawing.Size(89, 20)
        Dir_provLabel.TabIndex = 4
        Dir_provLabel.Text = "Dirección:"
        '
        'Tel_provLabel
        '
        Tel_provLabel.AutoSize = True
        Tel_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tel_provLabel.Location = New System.Drawing.Point(15, 144)
        Tel_provLabel.Name = "Tel_provLabel"
        Tel_provLabel.Size = New System.Drawing.Size(84, 20)
        Tel_provLabel.TabIndex = 6
        Tel_provLabel.Text = "Telefono:"
        '
        'Wev_provLabel
        '
        Wev_provLabel.AutoSize = True
        Wev_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wev_provLabel.Location = New System.Drawing.Point(15, 176)
        Wev_provLabel.Name = "Wev_provLabel"
        Wev_provLabel.Size = New System.Drawing.Size(58, 20)
        Wev_provLabel.TabIndex = 8
        Wev_provLabel.Text = "Email:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(15, 208)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(48, 20)
        TipoLabel.TabIndex = 10
        TipoLabel.Text = "Tipo:"
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
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(NitLabel)
        Me.GroupBox1.Controls.Add(Me.NitTextBox)
        Me.GroupBox1.Controls.Add(Nom_proLabel)
        Me.GroupBox1.Controls.Add(Me.Nom_proTextBox)
        Me.GroupBox1.Controls.Add(Dir_provLabel)
        Me.GroupBox1.Controls.Add(Me.Dir_provTextBox)
        Me.GroupBox1.Controls.Add(Tel_provLabel)
        Me.GroupBox1.Controls.Add(Me.Tel_provTextBox)
        Me.GroupBox1.Controls.Add(Wev_provLabel)
        Me.GroupBox1.Controls.Add(Me.Wev_provTextBox)
        Me.GroupBox1.Controls.Add(TipoLabel)
        Me.GroupBox1.Controls.Add(Me.TipoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(123, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(123, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(123, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(123, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(123, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(220, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Campos Requeridos    *"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(93, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 41)
        Me.Button2.TabIndex = 13
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
        Me.Button1.Location = New System.Drawing.Point(224, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NitTextBox
        '
        Me.NitTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nit", True))
        Me.NitTextBox.Location = New System.Drawing.Point(146, 45)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.Size = New System.Drawing.Size(187, 26)
        Me.NitTextBox.TabIndex = 1
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nom_proTextBox
        '
        Me.Nom_proTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nom_proTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nom_pro", True))
        Me.Nom_proTextBox.Location = New System.Drawing.Point(146, 77)
        Me.Nom_proTextBox.Name = "Nom_proTextBox"
        Me.Nom_proTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Nom_proTextBox.TabIndex = 3
        '
        'Dir_provTextBox
        '
        Me.Dir_provTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Dir_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "dir_prov", True))
        Me.Dir_provTextBox.Location = New System.Drawing.Point(146, 109)
        Me.Dir_provTextBox.Name = "Dir_provTextBox"
        Me.Dir_provTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Dir_provTextBox.TabIndex = 5
        '
        'Tel_provTextBox
        '
        Me.Tel_provTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tel_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "tel_prov", True))
        Me.Tel_provTextBox.Location = New System.Drawing.Point(146, 141)
        Me.Tel_provTextBox.Name = "Tel_provTextBox"
        Me.Tel_provTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Tel_provTextBox.TabIndex = 7
        '
        'Wev_provTextBox
        '
        Me.Wev_provTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Wev_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "wev_prov", True))
        Me.Wev_provTextBox.Location = New System.Drawing.Point(146, 173)
        Me.Wev_provTextBox.Name = "Wev_provTextBox"
        Me.Wev_provTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Wev_provTextBox.TabIndex = 9
        '
        'TipoTextBox
        '
        Me.TipoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(146, 205)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(187, 26)
        Me.TipoTextBox.TabIndex = 11
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.activofTableAdapter = Nothing
        Me.TableAdapterManager.asignsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bajactTableAdapter = Nothing
        ' Me.TableAdapterManager.cuentasTableAdapter = Nothing
        Me.TableAdapterManager.devolTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        'Me.TableAdapterManager.grupoTableAdapter = Nothing
        Me.TableAdapterManager.mantenimientoTableAdapter = Nothing
        'Me.TableAdapterManager.mayoresTableAdapter = Nothing
        Me.TableAdapterManager.oficinaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.tpcambioTableAdapter = Nothing
        Me.TableAdapterManager.unidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'registro_proveedor
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(502, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "registro_proveedor"
        Me.Text = "registro_proveedor"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As SICAF.sicafDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_proTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dir_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Wev_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
