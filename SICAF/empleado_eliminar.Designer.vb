<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado_eliminar
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CiTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PatTextBox = New System.Windows.Forms.TextBox()
        Me.MatTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.Telf_funTextBox = New System.Windows.Forms.TextBox()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.EmpleadoTableAdapter = New SICAF.sicafDataSetTableAdapters.empleadoTableAdapter()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        CiLabel = New System.Windows.Forms.Label()
        PatLabel = New System.Windows.Forms.Label()
        MatLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        Cod_uniLabel = New System.Windows.Forms.Label()
        Telf_funLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(628, 42)
        Me.Label1.Text = "Eliminar Funcionario"
        '
        'CiLabel
        '
        CiLabel.AutoSize = True
        CiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiLabel.Location = New System.Drawing.Point(24, 28)
        CiLabel.Name = "CiLabel"
        CiLabel.Size = New System.Drawing.Size(177, 20)
        CiLabel.TabIndex = 18
        CiLabel.Text = "Carnet De Identidad:"
        '
        'PatLabel
        '
        PatLabel.AutoSize = True
        PatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PatLabel.Location = New System.Drawing.Point(24, 28)
        PatLabel.Name = "PatLabel"
        PatLabel.Size = New System.Drawing.Size(119, 20)
        PatLabel.TabIndex = 18
        PatLabel.Text = "Ape. Paterno:"
        '
        'MatLabel
        '
        MatLabel.AutoSize = True
        MatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatLabel.Location = New System.Drawing.Point(24, 60)
        MatLabel.Name = "MatLabel"
        MatLabel.Size = New System.Drawing.Size(122, 20)
        MatLabel.TabIndex = 20
        MatLabel.Text = "Ape. Materno:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.Location = New System.Drawing.Point(24, 92)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(85, 20)
        NombresLabel.TabIndex = 22
        NombresLabel.Text = "Nombres:"
        '
        'Cod_uniLabel
        '
        Cod_uniLabel.AutoSize = True
        Cod_uniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_uniLabel.Location = New System.Drawing.Point(24, 124)
        Cod_uniLabel.Name = "Cod_uniLabel"
        Cod_uniLabel.Size = New System.Drawing.Size(71, 20)
        Cod_uniLabel.TabIndex = 24
        Cod_uniLabel.Text = "Unidad:"
        '
        'Telf_funLabel
        '
        Telf_funLabel.AutoSize = True
        Telf_funLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telf_funLabel.Location = New System.Drawing.Point(24, 156)
        Telf_funLabel.Name = "Telf_funLabel"
        Telf_funLabel.Size = New System.Drawing.Size(145, 20)
        Telf_funLabel.TabIndex = 26
        Telf_funLabel.Text = "Telefono/Celular:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.Location = New System.Drawing.Point(24, 188)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(62, 20)
        CargoLabel.TabIndex = 28
        CargoLabel.Text = "Cargo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(CiLabel)
        Me.GroupBox2.Controls.Add(Me.CiTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 72)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Funcionario"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(492, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CiTextBox
        '
        Me.CiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CiTextBox.Enabled = False
        Me.CiTextBox.Location = New System.Drawing.Point(246, 25)
        Me.CiTextBox.Name = "CiTextBox"
        Me.CiTextBox.Size = New System.Drawing.Size(240, 26)
        Me.CiTextBox.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 340)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "cod_uni", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(246, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 26)
        Me.TextBox1.TabIndex = 32
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(246, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 43)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = Global.SICAF.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(380, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 43)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PatTextBox
        '
        Me.PatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "pat", True))
        Me.PatTextBox.Enabled = False
        Me.PatTextBox.Location = New System.Drawing.Point(246, 25)
        Me.PatTextBox.Name = "PatTextBox"
        Me.PatTextBox.Size = New System.Drawing.Size(240, 26)
        Me.PatTextBox.TabIndex = 19
        '
        'MatTextBox
        '
        Me.MatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "mat", True))
        Me.MatTextBox.Enabled = False
        Me.MatTextBox.Location = New System.Drawing.Point(246, 57)
        Me.MatTextBox.Name = "MatTextBox"
        Me.MatTextBox.Size = New System.Drawing.Size(240, 26)
        Me.MatTextBox.TabIndex = 21
        '
        'NombresTextBox
        '
        Me.NombresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombres", True))
        Me.NombresTextBox.Enabled = False
        Me.NombresTextBox.Location = New System.Drawing.Point(246, 89)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(240, 26)
        Me.NombresTextBox.TabIndex = 23
        '
        'Telf_funTextBox
        '
        Me.Telf_funTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telf_funTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "telf_fun", True))
        Me.Telf_funTextBox.Enabled = False
        Me.Telf_funTextBox.Location = New System.Drawing.Point(246, 153)
        Me.Telf_funTextBox.Name = "Telf_funTextBox"
        Me.Telf_funTextBox.Size = New System.Drawing.Size(240, 26)
        Me.Telf_funTextBox.TabIndex = 27
        '
        'CargoTextBox
        '
        Me.CargoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "cargo", True))
        Me.CargoTextBox.Enabled = False
        Me.CargoTextBox.Location = New System.Drawing.Point(246, 185)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(240, 26)
        Me.CargoTextBox.TabIndex = 29
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'empleado_eliminar
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(652, 590)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "empleado_eliminar"
        Me.Text = "empleado_eliminar"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telf_funTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As SICAF.sicafDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
