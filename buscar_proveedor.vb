Public Class buscar_proveedor
    Public nit, nombre As String

    Private Sub buscar_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nit = nombre = String.Empty

        Me.ProveedoresTableAdapter.Fill(Me.SicafDataSet.proveedores)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'registro proveedor
        registro_proveedor.ShowDialog()
        nombre = My.Forms.registro_proveedor.nombre
        Me.ProveedoresTableAdapter.seleccionar_proveedor(Me.SicafDataSet.proveedores, nombre, "")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'buscar proveedores
        Me.ProveedoresTableAdapter.seleccionar_proveedor(Me.SicafDataSet.proveedores, TextBox1.Text, "")
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'seleccionamos al proveedor
        nit = Me.SicafDataSet.proveedores(ProveedoresBindingSource.Position).nit
        nombre = Me.SicafDataSet.proveedores(ProveedoresBindingSource.Position).nom_pro
        Close()
    End Sub
End Class