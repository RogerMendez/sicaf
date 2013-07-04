Public Class REPORTE_DE_PROVEEDORES

    Private Sub REPORTE_DE_PROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ProveedoresTableAdapter1.Fill(Me.SicafDataSet1.proveedores)

        Me.REPORTE_PROVEEDORES1.SetDataSource(Me.SicafDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.REPORTE_PROVEEDORES1
    End Sub
End Class