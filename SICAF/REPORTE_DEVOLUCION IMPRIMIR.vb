Public Class REPORTE_DEVOLUCION_IMPRIMIR

    Private Sub REPORTE_DEVOLUCION_IMPRIMIR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DevolucionesTableAdapter1.Fill(Me.SicafDataSet1.devoluciones)

        Me.REPORT_DEVOL_IMPR1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.REPORT_DEVOL_IMPR1
    End Sub
End Class