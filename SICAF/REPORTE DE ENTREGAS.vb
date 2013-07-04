Public Class REPORTE_DE_ENTREGAS
    Public cod As Integer
    Private Sub REPORTE_DE_ENTREGAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reportes_asignacionesTableAdapter1.select_report_asigna(Me.SicafDataSet1.reportes_asignaciones)

        Me.reportes_de_entregas1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.reportes_de_entregas1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'seleccionar activo fijo

        Dim a As New LISTA_DE_ASIGNACIONES()
        a.ShowDialog()
        cod = a.ID
        Cod_actTextBox.Text = cod
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Reportes_asignacionesTableAdapter1.select_report_asigna_id(Me.SicafDataSet1.reportes_asignaciones, cod)

        Me.reportes_de_entregas1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.reportes_de_entregas1
    End Sub
End Class