﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORT_DEVOL_IMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORT_DEVOL_IMP))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.REPORT_DEVOL_IMPR1 = New SICAF.REPORT_DEVOL_IMPR()
        Me.DevolucionesTableAdapter1 = New SICAF.sicafDataSetTableAdapters.devolucionesTableAdapter()
        Me.SicafDataSet1 = New SICAF.sicafDataSet()
        CType(Me.SicafDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 44)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.REPORT_DEVOL_IMPR1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(916, 530)
        Me.CrystalReportViewer1.TabIndex = 10
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'DevolucionesTableAdapter1
        '
        Me.DevolucionesTableAdapter1.ClearBeforeFill = True
        '
        'SicafDataSet1
        '
        Me.SicafDataSet1.DataSetName = "sicafDataSet"
        Me.SicafDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REPORT_DEVOL_IMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(954, 586)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.DoubleBuffered = True
        Me.Name = "REPORT_DEVOL_IMP"
        Me.Text = "REPORT_DEVOL_IMP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SicafDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents REPORT_DEVOL_IMPR1 As SICAF.REPORT_DEVOL_IMPR
    Friend WithEvents DevolucionesTableAdapter1 As SICAF.sicafDataSetTableAdapters.devolucionesTableAdapter
    Friend WithEvents SicafDataSet1 As SICAF.sicafDataSet
End Class
