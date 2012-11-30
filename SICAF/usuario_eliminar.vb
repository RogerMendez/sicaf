Public Class usuario_eliminar
    Dim nick1, cod As String

    Private Sub usuario_eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'buscar usuario
        usuario_buscar.ShowDialog()
        TextBox2.Text = My.Forms.usuario_buscar.nom
        nick1 = My.Forms.usuario_buscar.nick
        cod = My.Forms.usuario_buscar.cod
        Me.UsersTableAdapter.seleccionar_usuario(sicafDataSet.users, TextBox2.Text, Nothing, nick1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'eliminar
        Dim filas As Object
        If (TextBox2.Text.Length = 0) Then
            MessageBox.Show("DEBE SELECCIONAR UN USUARIO")
        Else
            If MessageBox.Show("¿Estas Seguro de Eliminar El Usuario?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.eliminar_usuario(cod)
                If (filas > 0) Then
                    Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL ELIMINAR LOS DATOS")
                End If
            End If
        End If
    End Sub
End Class