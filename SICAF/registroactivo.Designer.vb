<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroactivo
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
        Dim CodafLabel As System.Windows.Forms.Label
        Dim DesafLabel As System.Windows.Forms.Label
        Dim UnidadLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ProceLabel As System.Windows.Forms.Label
        Dim Num_serLabel As System.Windows.Forms.Label
        Dim TdocLabel As System.Windows.Forms.Label
        Dim NrodocLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim TasaLabel As System.Windows.Forms.Label
        Dim CprovLabel As System.Windows.Forms.Label
        Dim Cond_actLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CodafTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ProceTextBox = New System.Windows.Forms.TextBox()
        Me.Num_serTextBox = New System.Windows.Forms.TextBox()
        Me.TdocTextBox = New System.Windows.Forms.TextBox()
        Me.NrodocTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.CprovTextBox = New System.Windows.Forms.TextBox()
        Me.Cond_actTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ActivofBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SicafDataSet = New SICAF.sicafDataSet()
        Me.ActivofTableAdapter = New SICAF.sicafDataSetTableAdapters.activofTableAdapter()
        Me.TableAdapterManager = New SICAF.sicafDataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.QueriesTableAdapter()
        CodafLabel = New System.Windows.Forms.Label()
        DesafLabel = New System.Windows.Forms.Label()
        UnidadLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ProceLabel = New System.Windows.Forms.Label()
        Num_serLabel = New System.Windows.Forms.Label()
        TdocLabel = New System.Windows.Forms.Label()
        NrodocLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        TasaLabel = New System.Windows.Forms.Label()
        CprovLabel = New System.Windows.Forms.Label()
        Cond_actLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivofBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(913, 42)
        Me.Label1.Text = "Registro de Activo"
        '
        'CodafLabel
        '
        CodafLabel.AutoSize = True
        CodafLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodafLabel.Location = New System.Drawing.Point(10, 42)
        CodafLabel.Name = "CodafLabel"
        CodafLabel.Size = New System.Drawing.Size(124, 20)
        CodafLabel.TabIndex = 0
        CodafLabel.Text = "Codigo Activo:"
        '
        'DesafLabel
        '
        DesafLabel.AutoSize = True
        DesafLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesafLabel.Location = New System.Drawing.Point(9, 74)
        DesafLabel.Name = "DesafLabel"
        DesafLabel.Size = New System.Drawing.Size(162, 20)
        DesafLabel.TabIndex = 2
        DesafLabel.Text = "Descripcion Activo:"
        '
        'UnidadLabel
        '
        UnidadLabel.AutoSize = True
        UnidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnidadLabel.Location = New System.Drawing.Point(9, 176)
        UnidadLabel.Name = "UnidadLabel"
        UnidadLabel.Size = New System.Drawing.Size(71, 20)
        UnidadLabel.TabIndex = 4
        UnidadLabel.Text = "Unidad:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(9, 208)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(63, 20)
        MarcaLabel.TabIndex = 6
        MarcaLabel.Text = "Marca:"
        '
        'ProceLabel
        '
        ProceLabel.AutoSize = True
        ProceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProceLabel.Location = New System.Drawing.Point(9, 240)
        ProceLabel.Name = "ProceLabel"
        ProceLabel.Size = New System.Drawing.Size(113, 20)
        ProceLabel.TabIndex = 8
        ProceLabel.Text = "Procedencia:"
        '
        'Num_serLabel
        '
        Num_serLabel.AutoSize = True
        Num_serLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_serLabel.Location = New System.Drawing.Point(9, 272)
        Num_serLabel.Name = "Num_serLabel"
        Num_serLabel.Size = New System.Drawing.Size(148, 20)
        Num_serLabel.TabIndex = 10
        Num_serLabel.Text = "Numero de Serie:"
        '
        'TdocLabel
        '
        TdocLabel.AutoSize = True
        TdocLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TdocLabel.Location = New System.Drawing.Point(444, 45)
        TdocLabel.Name = "TdocLabel"
        TdocLabel.Size = New System.Drawing.Size(145, 20)
        TdocLabel.TabIndex = 12
        TdocLabel.Text = "Tipo Documento:"
        '
        'NrodocLabel
        '
        NrodocLabel.AutoSize = True
        NrodocLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NrodocLabel.Location = New System.Drawing.Point(444, 77)
        NrodocLabel.Name = "NrodocLabel"
        NrodocLabel.Size = New System.Drawing.Size(173, 20)
        NrodocLabel.TabIndex = 14
        NrodocLabel.Text = "Numero Documento:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.Location = New System.Drawing.Point(444, 109)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(64, 20)
        PrecioLabel.TabIndex = 16
        PrecioLabel.Text = "Precio:"
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TasaLabel.Location = New System.Drawing.Point(444, 141)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(82, 20)
        TasaLabel.TabIndex = 18
        TasaLabel.Text = "Vida Util:"
        '
        'CprovLabel
        '
        CprovLabel.AutoSize = True
        CprovLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CprovLabel.Location = New System.Drawing.Point(447, 173)
        CprovLabel.Name = "CprovLabel"
        CprovLabel.Size = New System.Drawing.Size(90, 20)
        CprovLabel.TabIndex = 20
        CprovLabel.Text = "Proveedor"
        '
        'Cond_actLabel
        '
        Cond_actLabel.AutoSize = True
        Cond_actLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cond_actLabel.Location = New System.Drawing.Point(444, 205)
        Cond_actLabel.Name = "Cond_actLabel"
        Cond_actLabel.Size = New System.Drawing.Size(93, 20)
        Cond_actLabel.TabIndex = 26
        Cond_actLabel.Text = "Condicion:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(796, 141)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(50, 20)
        Label10.TabIndex = 41
        Label10.Text = "Años"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(444, 237)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(115, 20)
        Label11.TabIndex = 42
        Label11.Text = "Tipo, Subtipo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(CodafLabel)
        Me.Panel1.Controls.Add(Me.CodafTextBox)
        Me.Panel1.Controls.Add(DesafLabel)
        Me.Panel1.Controls.Add(UnidadLabel)
        Me.Panel1.Controls.Add(Me.UnidadTextBox)
        Me.Panel1.Controls.Add(MarcaLabel)
        Me.Panel1.Controls.Add(Me.MarcaTextBox)
        Me.Panel1.Controls.Add(ProceLabel)
        Me.Panel1.Controls.Add(Me.ProceTextBox)
        Me.Panel1.Controls.Add(Num_serLabel)
        Me.Panel1.Controls.Add(Me.Num_serTextBox)
        Me.Panel1.Controls.Add(TdocLabel)
        Me.Panel1.Controls.Add(Me.TdocTextBox)
        Me.Panel1.Controls.Add(NrodocLabel)
        Me.Panel1.Controls.Add(Me.NrodocTextBox)
        Me.Panel1.Controls.Add(PrecioLabel)
        Me.Panel1.Controls.Add(Me.PrecioTextBox)
        Me.Panel1.Controls.Add(TasaLabel)
        Me.Panel1.Controls.Add(Me.TasaTextBox)
        Me.Panel1.Controls.Add(CprovLabel)
        Me.Panel1.Controls.Add(Me.CprovTextBox)
        Me.Panel1.Controls.Add(Cond_actLabel)
        Me.Panel1.Controls.Add(Me.Cond_actTextBox)
        Me.Panel1.Location = New System.Drawing.Point(32, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 363)
        Me.Panel1.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(623, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 24)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(623, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 24)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(623, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 24)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "*"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(852, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 27)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "status", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(646, 234)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 26)
        Me.TextBox1.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(623, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 24)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(623, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(623, 74)
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
        Me.Label6.Location = New System.Drawing.Point(623, 42)
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
        Me.Label5.Location = New System.Drawing.Point(177, 176)
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
        Me.Label4.Location = New System.Drawing.Point(177, 74)
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
        Me.Label3.Location = New System.Drawing.Point(176, 39)
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
        Me.Label2.Location = New System.Drawing.Point(302, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Campos Requeridos    *"
        '
        'Button3
        '
        Me.Button3.Image = Global.SICAF.My.Resources.Resources._Next
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(421, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 39)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Guardar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SICAF.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(292, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 39)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(852, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 27)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(199, 74)
        Me.RichTextBox1.MaxLength = 200
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 96)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'CodafTextBox
        '
        Me.CodafTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "codaf", True))
        Me.CodafTextBox.Location = New System.Drawing.Point(199, 39)
        Me.CodafTextBox.Name = "CodafTextBox"
        Me.CodafTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CodafTextBox.TabIndex = 1
        '
        'UnidadTextBox
        '
        Me.UnidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "unidad", True))
        Me.UnidadTextBox.Location = New System.Drawing.Point(199, 176)
        Me.UnidadTextBox.Name = "UnidadTextBox"
        Me.UnidadTextBox.Size = New System.Drawing.Size(200, 26)
        Me.UnidadTextBox.TabIndex = 5
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(199, 208)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(200, 26)
        Me.MarcaTextBox.TabIndex = 7
        '
        'ProceTextBox
        '
        Me.ProceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "proce", True))
        Me.ProceTextBox.Location = New System.Drawing.Point(199, 240)
        Me.ProceTextBox.Name = "ProceTextBox"
        Me.ProceTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProceTextBox.TabIndex = 9
        '
        'Num_serTextBox
        '
        Me.Num_serTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Num_serTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "num_ser", True))
        Me.Num_serTextBox.Location = New System.Drawing.Point(199, 272)
        Me.Num_serTextBox.Name = "Num_serTextBox"
        Me.Num_serTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Num_serTextBox.TabIndex = 11
        '
        'TdocTextBox
        '
        Me.TdocTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TdocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "tdoc", True))
        Me.TdocTextBox.Location = New System.Drawing.Point(646, 42)
        Me.TdocTextBox.Name = "TdocTextBox"
        Me.TdocTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TdocTextBox.TabIndex = 13
        '
        'NrodocTextBox
        '
        Me.NrodocTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NrodocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "nrodoc", True))
        Me.NrodocTextBox.Location = New System.Drawing.Point(646, 74)
        Me.NrodocTextBox.Name = "NrodocTextBox"
        Me.NrodocTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NrodocTextBox.TabIndex = 15
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(646, 106)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PrecioTextBox.TabIndex = 17
        '
        'TasaTextBox
        '
        Me.TasaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "tasa", True))
        Me.TasaTextBox.Location = New System.Drawing.Point(646, 138)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(144, 26)
        Me.TasaTextBox.TabIndex = 19
        '
        'CprovTextBox
        '
        Me.CprovTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CprovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "cprov", True))
        Me.CprovTextBox.Enabled = False
        Me.CprovTextBox.Location = New System.Drawing.Point(646, 170)
        Me.CprovTextBox.Name = "CprovTextBox"
        Me.CprovTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CprovTextBox.TabIndex = 21
        '
        'Cond_actTextBox
        '
        Me.Cond_actTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cond_actTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivofBindingSource, "cond_act", True))
        Me.Cond_actTextBox.Location = New System.Drawing.Point(646, 202)
        Me.Cond_actTextBox.Name = "Cond_actTextBox"
        Me.Cond_actTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Cond_actTextBox.TabIndex = 27
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ActivofBindingSource
        '
        Me.ActivofBindingSource.DataMember = "activof"
        Me.ActivofBindingSource.DataSource = Me.SicafDataSet
        '
        'SicafDataSet
        '
        Me.SicafDataSet.DataSetName = "sicafDataSet"
        Me.SicafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivofTableAdapter
        '
        Me.ActivofTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.activof_tipoTableAdapter = Nothing
        Me.TableAdapterManager.activofTableAdapter = Me.ActivofTableAdapter
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
        Me.TableAdapterManager.tpcambioTableAdapter = Nothing
        Me.TableAdapterManager.unidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SICAF.sicafDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'registroactivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "registroactivo"
        Me.Text = "registroactivo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivofBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SicafDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SicafDataSet As SICAF.sicafDataSet
    Friend WithEvents ActivofBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivofTableAdapter As SICAF.sicafDataSetTableAdapters.activofTableAdapter
    Friend WithEvents TableAdapterManager As SICAF.sicafDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_serTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TdocTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NrodocTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TasaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CprovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cond_actTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents QueriesTableAdapter1 As SICAF.sicafDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
