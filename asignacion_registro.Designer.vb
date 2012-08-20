<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignacion_registro
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
        Dim ObsLabel As System.Windows.Forms.Label
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.AsignsTableAdapter = New SICAF.sicafDataSetTableAdapters.asignsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cod_actTextBox = New System.Windows.Forms.TextBox()
        Me.AsignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cod_funTextBox = New System.Windows.Forms.TextBox()
        Me.ObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Cod_actLabel = New System.Windows.Forms.Label()
        Cod_funLabel = New System.Windows.Forms.Label()
        ObsLabel = New System.Windows.Forms.Label()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AsignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(507, 42)
        Me.Label1.Text = "Asignacion de Activo"
        '
        'Cod_actLabel
        '
        Cod_actLabel.AutoSize = True
        Cod_actLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_actLabel.Location = New System.Drawing.Point(13, 66)
        Cod_actLabel.Name = "Cod_actLabel"
        Cod_actLabel.Size = New System.Drawing.Size(124, 20)
        Cod_actLabel.TabIndex = 2
        Cod_actLabel.Text = "Codigo Activo:"
        '
        'Cod_funLabel
        '
        Cod_funLabel.AutoSize = True
        Cod_funLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_funLabel.Location = New System.Drawing.Point(13, 98)
        Cod_funLabel.Name = "Cod_funLabel"
        Cod_funLabel.Size = New System.Drawing.Size(108, 20)
        Cod_funLabel.TabIndex = 4
        Cod_funLabel.Text = "Funcionario:"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsLabel.Location = New System.Drawing.Point(13, 130)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(132, 20)
        ObsLabel.TabIndex = 10
        ObsLabel.Text = "Observaciones:"
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsignsTableAdapter
        '
        Me.AsignsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Cod_actLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_actTextBox)
        Me.GroupBox1.Controls.Add(Cod_funLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_funTextBox)
        Me.GroupBox1.Controls.Add(ObsLabel)
        Me.GroupBox1.Controls.Add(Me.ObsRichTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 363)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Asignación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(145, 95)
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
        Me.Label3.Location = New System.Drawing.Point(145, 64)
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
        Me.Label2.Location = New System.Drawing.Point(217, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Campos Requeridos    *"
        '
        'Button4
        '
        Me.Button4.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(168, 237)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 42)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(291, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 42)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Aceptar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(402, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 26)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(402, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cod_actTextBox
        '
        Me.Cod_actTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignsBindingSource, "cod_act", True))
        Me.Cod_actTextBox.Enabled = False
        Me.Cod_actTextBox.Location = New System.Drawing.Point(168, 63)
        Me.Cod_actTextBox.Name = "Cod_actTextBox"
        Me.Cod_actTextBox.Size = New System.Drawing.Size(228, 26)
        Me.Cod_actTextBox.TabIndex = 3
        '
        'AsignsBindingSource
        '
        Me.AsignsBindingSource.DataMember = "asigns"
        Me.AsignsBindingSource.DataSource = Me.SicafDataSet
        '
        'Cod_funTextBox
        '
        Me.Cod_funTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignsBindingSource, "cod_fun", True))
        Me.Cod_funTextBox.Enabled = False
        Me.Cod_funTextBox.Location = New System.Drawing.Point(168, 95)
        Me.Cod_funTextBox.Name = "Cod_funTextBox"
        Me.Cod_funTextBox.Size = New System.Drawing.Size(228, 26)
        Me.Cod_funTextBox.TabIndex = 5
        '
        'ObsRichTextBox
        '
        Me.ObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignsBindingSource, "obs", True))
        Me.ObsRichTextBox.Location = New System.Drawing.Point(168, 127)
        Me.ObsRichTextBox.Name = "ObsRichTextBox"
        Me.ObsRichTextBox.Size = New System.Drawing.Size(228, 104)
        Me.ObsRichTextBox.TabIndex = 11
        Me.ObsRichTextBox.Text = ""
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.activof_tipoTableAdapter = Nothing
        Me.TableAdapterManager.activofTableAdapter = Nothing
        Me.TableAdapterManager.asignsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bajactTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'asignacion_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "asignacion_registro"
        Me.Text = "asignacion_registro"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AsignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents AsignsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsignsTableAdapter As SICAF.sicafDataSetTableAdapters.asignsTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cod_actTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_funTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
