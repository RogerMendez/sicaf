Public Class REPORTES_ACTIVOS_ASIGNADOS

    Private Sub REPORTES_ACTIVOS_ASIGNADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reportes_asignacionesTableAdapter1.Fill(Me.SicafDataSet1.reportes_asignaciones)

        Me.report_asigna1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.report_asigna1
    End Sub
End Class