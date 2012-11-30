Imports System.Windows.Forms
Public Class Administrador
    Dim cod As String
    Public cod_respo As String

    Private Sub NuevoUsuarioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem1.Click
        'nuevo usuario
        My.Forms.usuario_registrar.MdiParent = Me
        usuario_registrar.Show()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUsuarioToolStripMenuItem1.Click
        'modificar usuario
        My.Forms.usuario_modificar.MdiParent = Me
        usuario_modificar.Show()
    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        'eliminar usuario
        My.Forms.usuario_eliminar.MdiParent = Me
        usuario_eliminar.Show()
    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click
        'nueva unidad
        My.Forms.unidad_registrar.MdiParent = Me
        unidad_registrar.Show()
    End Sub

    Private Sub NuevaOficinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaOficinaToolStripMenuItem.Click
        'nueva oficina
        My.Forms.oficina_registrar.MdiParent = Me
        oficina_registrar.Show()
    End Sub

    Private Sub ModificarOficicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarOficicaToolStripMenuItem.Click
        'modificar oficina
        My.Forms.oficina_modificar.MdiParent = Me
        oficina_modificar.Show()
    End Sub

    Private Sub EliminarOficinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarOficinaToolStripMenuItem.Click
        My.Forms.oficina_eliminar.MdiParent = Me
        oficina_eliminar.Show()
    End Sub

    Private Sub RegistrarEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarEmpleadoToolStripMenuItem.Click
        'registrar empleado
        My.Forms.empleado_registrar.MdiParent = Me
        empleado_registrar.Show()
    End Sub

    Private Sub ModificarEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarEmpleadoToolStripMenuItem.Click
        'modificar empleado
        My.Forms.empleado_modificar.MdiParent = Me
        empleado_modificar.Show()
    End Sub

    Private Sub EliminarEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarEmpleadoToolStripMenuItem.Click
        'eliminar empleado
        My.Forms.empleado_eliminar.MdiParent = Me
        empleado_eliminar.Show()
    End Sub

    Private Sub RegistrarActivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarActivoToolStripMenuItem.Click
        'registrar activo
        'Dim formulario As New registroactivo
        'formulario.MdiParent = Me
        'formulario.Show()
        'MessageBox.Show(nombre)
        My.Forms.registroactivo.MdiParent = Me
        My.Forms.registroactivo.Show()
    End Sub

    Private Sub RegistroTipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroTipoToolStripMenuItem.Click
        'registro tipo
        My.Forms.tipo_subtipo_registro.MdiParent = Me
        tipo_subtipo_registro.Show()
    End Sub

    Private Sub AgregarQuitarSubtipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarQuitarSubtipoToolStripMenuItem.Click
        'agragar subtipo
        My.Forms.subtipo_agregar.MdiParent = Me
        subtipo_agregar.Show()
    End Sub

    Private Sub AsignarActivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarActivoToolStripMenuItem.Click
        'asignacion activo fijo
        My.Forms.asignacion_registro.MdiParent = Me
        asignacion_registro.Show()
    End Sub

    Private Sub DevoluciónActivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluciónActivoToolStripMenuItem.Click
        'registro devolucion
        My.Forms.devolucion_registro.MdiParent = Me
        devolucion_registro.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarToolStripMenuItem.Click
        'registrar tipo cambio
        My.Forms.tcambio_registrar.MdiParent = Me
        tcambio_registrar.Show()
    End Sub

    Private Sub mantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mantenimientoToolStripMenuItem.Click
        'matenimiento activo
        My.Forms.mantenimiento_registro.MdiParent = Me
        mantenimiento_registro.Show()
    End Sub

    Private Sub RevaluarActvoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevaluarActvoToolStripMenuItem.Click
        'revaluos
        My.Forms.revaluos_registro.MdiParent = Me
        My.Forms.revaluos_registro.Show()
    End Sub

    Private Sub BajaActivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaActivoToolStripMenuItem.Click
        'baja activo
        My.Forms.baja_af_registro.MdiParent = Me
        My.Forms.baja_af_registro.Show()
    End Sub

    Private Sub RegistrarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarProveedorToolStripMenuItem.Click
        'proveedor nuevo
        My.Forms.registro_proveedor.MdiParent = Me
        registro_proveedor.Show()
    End Sub

    Private Sub ModficarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModficarProveedorToolStripMenuItem.Click
        'modificar proveedor
        My.Forms.modificar_proveedor.MdiParent = Me
        modificar_proveedor.Show()
    End Sub

    Private Sub Administrador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cod = My.Forms.login.cod_res
        'MessageBox.Show("El codigo es:      " & cod)
        Me.QueriesTableAdapter1.buscando(cod, cod_respo)
    End Sub
End Class