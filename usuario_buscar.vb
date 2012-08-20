Public Class usuario_buscar
    Public nick As String
    Public cod, nom As String

    Private Sub usuario_buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.SicafDataSet.users)
        nick = String.Empty
        cod = String.Empty
        nom = String.Empty
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'registro usuario
        usuario_registrar.ShowDialog()
        nick = My.Forms.usuario_registrar.nick
        Me.UsersTableAdapter.seleccionar_usuario(SicafDataSet.users, "", "", nick)
    End Sub

    Private Sub NombresTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombresTextBox.TextChanged
        'buscar users
        Me.UsersTableAdapter.seleccionar_usuario(SicafDataSet.users, NombresTextBox.Text, NombresTextBox.Text, "")

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        cod = Me.SicafDataSet.users(UsersBindingSource.Position).cod_user
        nom = Me.SicafDataSet.users(UsersBindingSource.Position).nombres
        nick = Me.SicafDataSet.users(UsersBindingSource.Position).usuario
        Close()
    End Sub
End Class