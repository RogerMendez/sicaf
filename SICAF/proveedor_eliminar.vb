Public Class proveedor_eliminar
    Dim nombre As String
    Dim nit As String

    Private Sub proveedor_eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nit = String.Empty
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ''buscar proveedor
        buscar_proveedor.ShowDialog()
        TextBox1.Text = My.Forms.buscar_proveedor.nit
        nit = My.Forms.buscar_proveedor.nit
        Me.ProveedoresTableAdapter.seleccionar_proveedor(SicafDataSet.proveedores, TextBox1.Text, nit)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filas As Object
        If (TextBox1.Text.Length = 0) Then
            MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR")
        Else
            If MessageBox.Show("¿Estas Seguro de Eliminar El Proveedor?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.eliminar_proveedores(nit)
                If (filas = 1) Then
                    Me.Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL ELIMINAR LOS DATOS")
                End If
            End If
        End If
    End Sub
End Class