Public Class oficina_seleccionar
    Public cod As String

    Private Sub oficina_seleccionar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SicafDataSet.oficina' table. You can move, or remove it, as needed.
        Me.OficinaTableAdapter.Fill(Me.SicafDataSet.oficina)

        cod = String.Empty
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.OficinaTableAdapter.seleccionar_oficina(SicafDataSet.oficina, TextBox1.Text)
    End Sub

    Private Sub DataGridView1_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'seleccionar oficina
        cod = Me.SicafDataSet.oficina(Me.OficinaBindingSource.Position).cod_ofi
        Close()
    End Sub
End Class