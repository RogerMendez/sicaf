Public Class REPORTE_DE_MANTENIMIENTO

    Private Sub REPORTE_DE_MANTENIMIENTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_mantenimientoTableAdapter1.Fill(Me.SicafDataSet1.mostrar_mantenimiento)

        Me.REPOR_MANTENIMIENTO1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.REPOR_MANTENIMIENTO1
    End Sub
End Class