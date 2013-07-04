Public Class LISTA_DE_ASIGNACIONES
    Public ID As Integer
    Private Sub LISTA_DE_ASIGNACIONES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SicafDataSet.reportes_asignaciones' Puede moverla o quitarla según sea necesario.
        Me.Reportes_asignacionesTableAdapter.Fill(Me.SicafDataSet.reportes_asignaciones)

    End Sub
    Private Sub ActivofDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivofDataGridView.DoubleClick
        'seleccion activo fijo
        ID = Me.SicafDataSet.reportes_asignaciones(Me.ReportesasignacionesBindingSource.Position).cod_asing
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class