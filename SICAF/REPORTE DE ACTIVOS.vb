Public Class REPORTE_DE_ACTIVOS

    Private Sub REPORTE_DE_ACTIVOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.View_activosTableAdapter1.Fill(Me.SicafDataSet1.view_activos)

        Me.ACTIVOS1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.ACTIVOS1
    End Sub
End Class