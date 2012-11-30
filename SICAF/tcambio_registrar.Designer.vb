<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tcambio_registrar
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
        Dim FechLabel As System.Windows.Forms.Label
        Dim DolarLabel As System.Windows.Forms.Label
        Dim UfvLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FechDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TpcambioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.DolarTextBox = New System.Windows.Forms.TextBox()
        Me.UfvTextBox = New System.Windows.Forms.TextBox()
        Me.TpcambioTableAdapter = New SICAF.sicafDataSetTableAdapters.tpcambioTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        FechLabel = New System.Windows.Forms.Label()
        DolarLabel = New System.Windows.Forms.Label()
        UfvLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TpcambioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(585, 42)
        Me.Label1.Text = "Registro Tipo Cambio"
        '
        'FechLabel
        '
        FechLabel.AutoSize = True
        FechLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechLabel.Location = New System.Drawing.Point(15, 36)
        FechLabel.Name = "FechLabel"
        FechLabel.Size = New System.Drawing.Size(64, 20)
        FechLabel.TabIndex = 0
        FechLabel.Text = "Fecha:"
        '
        'DolarLabel
        '
        DolarLabel.AutoSize = True
        DolarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DolarLabel.Location = New System.Drawing.Point(15, 67)
        DolarLabel.Name = "DolarLabel"
        DolarLabel.Size = New System.Drawing.Size(57, 20)
        DolarLabel.TabIndex = 2
        DolarLabel.Text = "Dolar:"
        '
        'UfvLabel
        '
        UfvLabel.AutoSize = True
        UfvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UfvLabel.Location = New System.Drawing.Point(15, 99)
        UfvLabel.Name = "UfvLabel"
        UfvLabel.Size = New System.Drawing.Size(50, 20)
        UfvLabel.TabIndex = 4
        UfvLabel.Text = "UFV:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(FechLabel)
        Me.GroupBox1.Controls.Add(Me.FechDateTimePicker)
        Me.GroupBox1.Controls.Add(DolarLabel)
        Me.GroupBox1.Controls.Add(Me.DolarTextBox)
        Me.GroupBox1.Controls.Add(UfvLabel)
        Me.GroupBox1.Controls.Add(Me.UfvTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 293)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Tipo Cambio"
        '
        'Button2
        '
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(171, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 38)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(322, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FechDateTimePicker
        '
        Me.FechDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TpcambioBindingSource, "fech", True))
        Me.FechDateTimePicker.Location = New System.Drawing.Point(141, 31)
        Me.FechDateTimePicker.Name = "FechDateTimePicker"
        Me.FechDateTimePicker.Size = New System.Drawing.Size(286, 26)
        Me.FechDateTimePicker.TabIndex = 1
        '
        'TpcambioBindingSource
        '
        Me.TpcambioBindingSource.DataMember = "tpcambio"
        Me.TpcambioBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DolarTextBox
        '
        Me.DolarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TpcambioBindingSource, "dolar", True))
        Me.DolarTextBox.Location = New System.Drawing.Point(141, 63)
        Me.DolarTextBox.Name = "DolarTextBox"
        Me.DolarTextBox.Size = New System.Drawing.Size(236, 26)
        Me.DolarTextBox.TabIndex = 3
        '
        'UfvTextBox
        '
        Me.UfvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TpcambioBindingSource, "ufv", True))
        Me.UfvTextBox.Location = New System.Drawing.Point(141, 95)
        Me.UfvTextBox.Name = "UfvTextBox"
        Me.UfvTextBox.Size = New System.Drawing.Size(236, 26)
        Me.UfvTextBox.TabIndex = 5
        '
        'TpcambioTableAdapter
        '
        Me.TpcambioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tipoTableAdapter = Nothing
        Me.TableAdapterManager.tpcambioTableAdapter = Me.TpcambioTableAdapter
        Me.TableAdapterManager.unidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tcambio_registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "tcambio_registrar"
        Me.Text = "tcambio_registrar"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TpcambioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents TpcambioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TpcambioTableAdapter As SICAF.sicafDataSetTableAdapters.tpcambioTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FechDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DolarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UfvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
