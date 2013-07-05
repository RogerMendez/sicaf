Public Class REPORTE_BAJAS

    Private Sub REPORTE_BAJAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_bajasTableAdapter1.Fill(Me.SicafDataSet1.mostrar_bajas)
        Me.Mostrar_bajasTableAdapter1.Fill(Me.SicafDataSet1.mostrar_bajas)

        Me.report_bajas1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.report_bajas1
        

    End Sub
End Class