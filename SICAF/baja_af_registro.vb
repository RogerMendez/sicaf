Public Class baja_af_registro
    Dim codaf, func, motivo, obs, respo As String

    Private Sub baja_af_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        respo = My.Forms.Administrador.cod_respo
        codaf = String.Empty
        func = String.Empty
        motivo = String.Empty
        obs = String.Empty
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'seleccionar activo fijo
        Dim a As New activof_seleccion()
        a.ShowDialog()
        codaf = a.codaf
        Cod_actTextBox.Text = codaf
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'seleccion funcionario
        empleado_seleccionar.ShowDialog()
        func = My.Forms.empleado_seleccionar.ci
        Cod_funTextBox.Text = func
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'guardar
        Dim fila As Object
        If (codaf = Nothing Or func = Nothing Or motivo = Nothing Or obs = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS")
        Else
            fila = Me.QueriesTableAdapter1.insertar_bajaaf(codaf, respo, func, motivo, obs.ToUpper())
            If (fila = 2) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR")
            End If
        End If
    End Sub

    Private Sub MotivoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MotivoTextBox.Validating
        'validar que el motivo no este vacio
        If (MotivoTextBox.Text.Length > 0) Then
            ErrorProvider1.SetError(MotivoTextBox, Nothing)
            motivo = MotivoTextBox.Text
        Else
            ErrorProvider1.SetError(MotivoTextBox, "Debe Registrar El Motivo De lA Baja")
            motivo = String.Empty
        End If
    End Sub

    Private Sub ObsRichTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ObsRichTextBox.Validating
        If (ObsRichTextBox.Text.Length > 0) Then
            ErrorProvider1.SetError(ObsRichTextBox, Nothing)
            obs = ObsRichTextBox.Text
        Else
            ErrorProvider1.SetError(ObsRichTextBox, "Debe Registrar La Observacion De lA Baja")
            obs = String.Empty
        End If
    End Sub
End Class