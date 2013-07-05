Public Class REPORT_ENTREGA

    Private Sub REPORT_ENTREGA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reportes_asignacionesTableAdapter1.select_report_asigna(Me.SicafDataSet1.reportes_asignaciones)


        Me.reportes_de_entregas1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.reportes_de_entregas1
    End Sub
End Class