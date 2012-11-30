Public Class activof_seleccion
    Public codaf As String

    Private Sub activof_seleccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
        Me.ActivofTableAdapter.mostrar_asing_activo(Me.SicafDataSet.activof)
        codaf = String.Empty
    End Sub

    Private Sub ActivofDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivofDataGridView.DoubleClick
        'seleccion activo fijo
        codaf = Me.SicafDataSet.activof(Me.ActivofBindingSource.Position).codaf
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'mostrar subtipo despues de escojer tipo
        Me.SubtipoTableAdapter.mostrar_subtipo_codtipo(Me.SicafDataSet.subtipo, ComboBox1.SelectedValue)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cancelar 
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'mostrar activos fijos
        If (ComboBox1.Text.Length > 0 And ComboBox2.Text.Length > 0) Then
            Me.ActivofTableAdapter.seleccionar_activof_tipo(Me.SicafDataSet.activof, ComboBox1.SelectedValue, ComboBox2.SelectedValue)
        Else
            MessageBox.Show("DEBE SELECCIONAR UN SUBTIPO")
        End If
    End Sub
End Class