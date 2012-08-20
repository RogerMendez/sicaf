Public Class asignacion_registro
    Dim codaf As String
    Dim ci, respo As Integer

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If (Administrador.codigo = Nothing) Then

        Else
            Administrador.AsignarActivoToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub asignacion_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Administrador.codigo = Nothing) Then
            respo = Principal.codigo
        Else
            respo = Administrador.codigo
        End If
        codaf = Nothing
        ci = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'seleccion activo fijo
        Dim a As New activof_seleccion()
        a.ShowDialog()
        codaf = a.codaf
        Cod_actTextBox.Text = codaf
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'seleccion funcionario
        empleado_seleccionar.ShowDialog()
        ci = My.Forms.empleado_seleccionar.ci
        Cod_funTextBox.Text = ci
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'aceptar
        Dim filas As Object
        If (codaf = Nothing Or ci = Nothing) Then
            MessageBox.Show("DEBE SELECCIONAR LOS CAMPOS REQUERiDOS")
        Else
            filas = Me.QueriesTableAdapter1.registro_asignacion(codaf, ci, respo, ObsRichTextBox.Text.ToUpper())
            If (filas = 2) Then
                MessageBox.Show("ASIGNACION REALIZADA CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR")
            End If
        End If
    End Sub
End Class