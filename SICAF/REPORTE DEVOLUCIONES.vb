Public Class REPORTE_DEVOLUCIONES

    Private Sub REPORTE_DEVOLUCIONES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DevolucionesTableAdapter1.Fill(Me.SicafDataSet1.devoluciones)

        Me.report_devol1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.report_devol1
    End Sub
End Class