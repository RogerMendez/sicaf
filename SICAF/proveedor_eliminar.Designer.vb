<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedor_eliminar
    Inherits plantillaform

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label8 As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim Nom_proLabel As System.Windows.Forms.Label
        Dim Dir_provLabel As System.Windows.Forms.Label
        Dim Tel_provLabel As System.Windows.Forms.Label
        Dim Wev_provLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        Label8 = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        Nom_proLabel = New System.Windows.Forms.Label()
        Dir_provLabel = New System.Windows.Forms.Label()
        Tel_provLabel = New System.Windows.Forms.Label()
        Wev_provLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "Eliminar Proveedor"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(15, 22)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(42, 20)
        Label8.TabIndex = 2
        Label8.Text = "NIT:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NitLabel.Location = New System.Drawing.Point(15, 28)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(42, 20)
        NitLabel.TabIndex = 0
        NitLabel.Text = "NIT:"
        '
        'Nom_proLabel
        '
        Nom_proLabel.AutoSize = True
        Nom_proLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_proLabel.Location = New System.Drawing.Point(15, 60)
        Nom_proLabel.Name = "Nom_proLabel"
        Nom_proLabel.Size = New System.Drawing.Size(76, 20)
        Nom_proLabel.TabIndex = 2
        Nom_proLabel.Text = "Nombre:"
        '
        'Dir_provLabel
        '
        Dir_provLabel.AutoSize = True
        Dir_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dir_provLabel.Location = New System.Drawing.Point(15, 92)
        Dir_provLabel.Name = "Dir_provLabel"
        Dir_provLabel.Size = New System.Drawing.Size(89, 20)
        Dir_provLabel.TabIndex = 4
        Dir_provLabel.Text = "Dirección:"
        '
        'Tel_provLabel
        '
        Tel_provLabel.AutoSize = True
        Tel_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tel_provLabel.Location = New System.Drawing.Point(15, 124)
        Tel_provLabel.Name = "Tel_provLabel"
        Tel_provLabel.Size = New System.Drawing.Size(84, 20)
        Tel_provLabel.TabIndex = 6
        Tel_provLabel.Text = "Telefono:"
        '
        'Wev_provLabel
        '
        Wev_provLabel.AutoSize = True
        Wev_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wev_provLabel.Location = New System.Drawing.Point(15, 156)
        Wev_provLabel.Name = "Wev_provLabel"
        Wev_provLabel.Size = New System.Drawing.Size(58, 20)
        Wev_provLabel.TabIndex = 8
        Wev_provLabel.Text = "Email:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(15, 188)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(48, 20)
        TipoLabel.TabIndex = 10
        TipoLabel.Text = "Tipo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 71)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(339, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(146, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 26)
        Me.TextBox1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Location = New System.Drawing.Point(19, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 303)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(93, 217)
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
        Me.Button1.Location = New System.Drawing.Point(227, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NitTextBox
        '
        Me.NitTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nit", True))
        Me.NitTextBox.Enabled = False
        Me.NitTextBox.Location = New System.Drawing.Point(146, 25)
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
        Me.Nom_proTextBox.Enabled = False
        Me.Nom_proTextBox.Location = New System.Drawing.Point(146, 57)
        Me.Nom_proTextBox.Name = "Nom_proTextBox"
        Me.Nom_proTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Nom_proTextBox.TabIndex = 3
        '
        'Dir_provTextBox
        '
        Me.Dir_provTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Dir_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "dir_prov", True))
        Me.Dir_provTextBox.Enabled = False
        Me.Dir_provTextBox.Location = New System.Drawing.Point(146, 89)
        Me.Dir_provTextBox.Name = "Dir_provTextBox"
        Me.Dir_provTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Dir_provTextBox.TabIndex = 5
        '
        'Tel_provTextBox
        '
        Me.Tel_provTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tel_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "tel_prov", True))
        Me.Tel_provTextBox.Enabled = False
        Me.Tel_provTextBox.Location = New System.Drawing.Point(146, 121)
        Me.Tel_provTextBox.Name = "Tel_provTextBox"
        Me.Tel_provTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Tel_provTextBox.TabIndex = 7
        '
        'Wev_provTextBox
        '
        Me.Wev_provTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Wev_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "wev_prov", True))
        Me.Wev_provTextBox.Enabled = False
        Me.Wev_provTextBox.Location = New System.Drawing.Point(146, 153)
        Me.Wev_provTextBox.Name = "Wev_provTextBox"
        Me.Wev_provTextBox.Size = New System.Drawing.Size(187, 26)
        Me.Wev_provTextBox.TabIndex = 9
        '
        'TipoTextBox
        '
        Me.TipoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "tipo", True))
        Me.TipoTextBox.Enabled = False
        Me.TipoTextBox.Location = New System.Drawing.Point(146, 185)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(187, 26)
        Me.TipoTextBox.TabIndex = 11
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'proveedor_eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 451)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "proveedor_eliminar"
        Me.Text = "Eliminar Proveedor"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_proTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dir_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Wev_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As SICAF.sicafDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
End Class
