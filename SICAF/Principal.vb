Public Class Principal
    Public unidad As String
    Public cod_respo As String

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        unidad = login.unidad
        'MessageBox.Show(unidad)
    End Sub

    Private Sub VerActivosAsignadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerActivosAsignadosToolStripMenuItem.Click
        My.Forms.activos_asignados_unidad.MdiParent = Me
        activos_asignados_unidad.Show()
    End Sub
End Class