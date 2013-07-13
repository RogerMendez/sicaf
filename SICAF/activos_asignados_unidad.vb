Public Class activos_asignados_unidad
    Dim unidad As String

    Private Sub activos_asignados_unidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SicafDataSet.asignacion_unidad' table. You can move, or remove it, as needed.
        unidad = Principal.unidad
        Me.Asignacion_unidadTableAdapter.mostrar_activos_unidad_asinado(Me.SicafDataSet.asignacion_unidad, unidad)

    End Sub

    Private Sub Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Cancelar.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Asignacion_unidadTableAdapter.mostrar_activos_unidad_asinado(Me.SicafDataSet.asignacion_unidad, unidad)
    End Sub
End Class