Public Class revaluos_registro
    Dim codaf, obs As String
    Dim respo As String

    Private Sub revaluos_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codaf = String.Empty
        obs = String.Empty
        respo = My.Forms.Administrador.cod_respo
        'MessageBox.Show(My.Forms.Administrador.codigo)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'seleccion activo fijo
        Dim a As New activof_seleccion()
        a.ShowDialog()
        codaf = a.codaf
        Cod_actTextBox.Text = codaf
    End Sub

    Private Sub ObsRichTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ObsRichTextBox.Validating
        'validar que la observaciones no esten vacias
        If (ObsRichTextBox.Text.Length > 0) Then
            ErrorProvider1.SetError(ObsRichTextBox, Nothing)
            obs = ObsRichTextBox.Text
        Else
            ErrorProvider1.SetError(ObsRichTextBox, "Debe Registrar Las Observaciones")
            obs = String.Empty
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'guardar
        Dim fila As Object
        If (codaf = Nothing Or obs = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS")
        Else
            fila = Me.QueriesTableAdapter1.insertar_revaluo(codaf, FechaDateTimePicker.Text, respo, obs.ToUpper())
            If (fila = 2) Then
                MessageBox.Show("DATOS GUARDADOS")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR")
            End If
        End If
    End Sub
End Class