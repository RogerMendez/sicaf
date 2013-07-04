Public Class REPORTE_DE_REVALUOS

    Private Sub REPORTE_DE_REVALUOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_revauosTableAdapter1.Fill(Me.SicafDataSet1.mostrar_revauos)

        Me.REPORTE_REVALUO1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.REPORTE_REVALUO1
    End Sub
End Class