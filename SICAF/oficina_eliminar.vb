Public Class oficina_eliminar
    Dim cod As String

    Private Sub oficina_eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cod = String.Empty
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'seleccionar oficina
        oficina_seleccionar.ShowDialog()
        cod = My.Forms.oficina_seleccionar.cod
        Cod_ofiTextBox.Text = cod
        Me.OficinaTableAdapter.seleccionar_oficina(sicafDataSet.oficina, cod)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'eliminar
        Dim filas As Object
        If (cod = Nothing) Then
            MessageBox.Show("DEBE SELECCIONAR UNA OFICINA")
        Else
            If MessageBox.Show("¿Estas Seguro de Eliminar La Oficna?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.eliminar_oficina(cod)
                If (filas = 1) Then
                    Me.Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL ELIMINAR LOS DATOS")
                End If
            End If
        End If
    End Sub
End Class