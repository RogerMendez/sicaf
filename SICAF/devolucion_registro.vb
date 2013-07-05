Public Class devolucion_registro
    Dim ci, respo As String

    Private Sub devolucion_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Administrador.cod_respo = Nothing) Then
            respo = Principal.cod_respo
        Else
            respo = Administrador.cod_respo
        End If
        ci = String.Empty
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'seleccionar empleado
        empleado_seleccionar.ShowDialog()
        ci = My.Forms.empleado_seleccionar.ci
        CiTextBox.Text = ci
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'mostrar asignaciones funcionario
        Me.Mostrar_asignacionesTableAdapter.mostrar_asignaciones_funcionario(SicafDataSet.mostrar_asignaciones, ci)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cancelar
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'devolver
        Dim filas As Object
        Dim codaf As String
        codaf = String.Empty
        codaf = Me.SicafDataSet.mostrar_asignaciones(Me.MostrarasignacionesBindingSource.Position).Codigo_A__F_
        If (codaf.Length > 0 And ci.Length > 0) Then
            If MessageBox.Show("¿Estas Seguro de Realizar La Devolucion del Activo?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.registro_devolucion(codaf, ci, respo, RichTextBox1.Text)
                If (filas = 2) Then
                    MessageBox.Show("DEBOLUCION REALIZADA CORRECTAMENTE")
                    Me.Mostrar_asignacionesTableAdapter.mostrar_asignaciones_funcionario(SicafDataSet.mostrar_asignaciones, ci)
                Else
                    MessageBox.Show("OCURRIO UN ERROR")
                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub
End Class