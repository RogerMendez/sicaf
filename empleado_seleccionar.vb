Public Class empleado_seleccionar
    Public ci As Integer

    Private Sub empleado_seleccionar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SicafDataSet.empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.SicafDataSet.empleado)
        ci = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'buscar empleado
        Me.EmpleadoTableAdapter.seleccionar_empleado(Me.SicafDataSet.empleado, TextBox1.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cancelar
        Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'seleccionar empleado
        ci = Me.SicafDataSet.empleado(Me.EmpleadoBindingSource.Position).ci
        Close()
    End Sub
End Class