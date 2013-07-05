Public Class Principal
    Public cod_respo As String

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cod_respo = Nothing

    End Sub

    Private Sub RegistrarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarProveedorToolStripMenuItem.Click
        'proveedor nuevo
        My.Forms.registro_proveedor.MdiParent = Me
        registro_proveedor.Show()
    End Sub

    Private Sub ModificarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarProveedorToolStripMenuItem.Click
        'modificar proveedor
        My.Forms.modificar_proveedor.MdiParent = Me
        modificar_proveedor.Show()
    End Sub

    Private Sub EliminarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarProveedorToolStripMenuItem.Click
        'eliminar proveedor
        My.Forms.proveedor_eliminar.MdiParent = Me
        proveedor_eliminar.Show()
    End Sub

End Class