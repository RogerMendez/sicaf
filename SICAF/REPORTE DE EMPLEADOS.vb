Public Class REPORTE_DE_EMPLEADOS

    Private Sub REPORTE_DE_EMPLEADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_empleadosTableAdapter1.Fill(Me.SicafDataSet1.mostrar_empleados)

        Me.reporte_emple1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.reporte_emple1
    End Sub
End Class