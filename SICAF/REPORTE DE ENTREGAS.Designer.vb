<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_DE_ENTREGAS
    Inherits System.Windows.Forms.Form

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
        Dim Cod_actLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORTE_DE_ENTREGAS))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportes_de_entregas1 = New SICAF.reportes_de_entregas()
        Me.Reportes_asignacionesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.reportes_asignacionesTableAdapter()
        Me.SicafDataSet1 = New SICAF.sicafDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cod_actTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Cod_actLabel = New System.Windows.Forms.Label()
        CType(Me.SicafDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_actLabel
        '
        Cod_actLabel.AutoSize = True
        Cod_actLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_actLabel.Location = New System.Drawing.Point(31, 28)
        Cod_actLabel.Name = "Cod_actLabel"
        Cod_actLabel.Size = New System.Drawing.Size(97, 20)
        Cod_actLabel.TabIndex = 15
        Cod_actLabel.Text = "Activo Fijo:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 71)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.reportes_de_entregas1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(916, 530)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Reportes_asignacionesTableAdapter1
        '
        Me.Reportes_asignacionesTableAdapter1.ClearBeforeFill = True
        '
        'SicafDataSet1
        '
        Me.SicafDataSet1.DataSetName = "sicafDataSet"
        Me.SicafDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cod_actTextBox
        '
        Me.Cod_actTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cod_actTextBox.Enabled = False
        Me.Cod_actTextBox.Location = New System.Drawing.Point(183, 25)
        Me.Cod_actTextBox.Name = "Cod_actTextBox"
        Me.Cod_actTextBox.Size = New System.Drawing.Size(300, 20)
        Me.Cod_actTextBox.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(662, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 29)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "MOSTRAR REPORTE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'REPORTE_DE_ENTREGAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(954, 586)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Cod_actLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cod_actTextBox)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.DoubleBuffered = True
        Me.Name = "REPORTE_DE_ENTREGAS"
        Me.Text = "REPORTE_DE_ENTREGAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SicafDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportes_de_entregas1 As SICAF.reportes_de_entregas
    Friend WithEvents Reportes_asignacionesTableAdapter1 As SICAF.sicafDataSetTableAdapters.reportes_asignacionesTableAdapter
    Friend WithEvents SicafDataSet1 As SICAF.sicafDataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cod_actTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
