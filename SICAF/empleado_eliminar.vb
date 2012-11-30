Public Class empleado_eliminar
    Dim ci As Integer

    Private Sub empleado_eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ci = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'eliminar empleado
        Dim filas As Object
        If (ci = Nothing) Then
            MessageBox.Show("DEBE SELECCIONAR AL EMPLEADO")
        Else
            If MessageBox.Show("¿Estas Seguro de Eliminar Al Empleado?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.eliminar_empleado(ci)
                If (filas > 0) Then
                    Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL ACTUALIZAR LOS DATOS")
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'seleccionar empleado
        empleado_seleccionar.ShowDialog()
        ci = My.Forms.empleado_seleccionar.ci
        CiTextBox.Text = ci
        Me.EmpleadoTableAdapter.seleccionar_empleado(Me.SicafDataSet.empleado, ci)
    End Sub
End Class