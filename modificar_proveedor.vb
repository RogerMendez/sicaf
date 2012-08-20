Public Class modificar_proveedor
    Dim nombre As String
    Dim nit, direc, fono, tipo As String

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Administrador.ModficarProveedorToolStripMenuItem.Enabled = True
    End Sub

    Private Sub modificar_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nombre = String.Empty
        nit = String.Empty
        direc = String.Empty
        fono = String.Empty
        tipo = String.Empty
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'buscar proveedor
        buscar_proveedor.ShowDialog()
        TextBox1.Text = My.Forms.buscar_proveedor.nit
        nit = My.Forms.buscar_proveedor.nit
        Me.ProveedoresTableAdapter.seleccionar_proveedor(SicafDataSet.proveedores, TextBox1.Text, nit)
        nombre = Nom_proTextBox.Text
        direc = Dir_provTextBox.Text
        fono = Tel_provTextBox.Text
        tipo = TipoTextBox.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'actualizar
        Dim filas As Object
        If (nombre = Nothing Or nit = Nothing Or direc = Nothing Or fono = Nothing Or tipo = Nothing) Then
            MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS REQUERIDOS")
        Else
            If MessageBox.Show("¿Estas Seguro de Actualizar El Proveedor?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.modificar_proveedor(NitTextBox.Text, nombre, fono, direc, Wev_provTextBox.Text, tipo, nit)
                If (filas = 1) Then
                    Me.Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL ACTUALIZAR LOS DATOS")
                End If
            End If
        End If
    End Sub

    Private Sub NitTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NitTextBox.KeyPress
        'validacion de numero en el nit
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub NitTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NitTextBox.Validating
        'validacion de longitud nit
        Dim flag As Boolean
        flag = False

        If (NitTextBox.Text.Length = 10) Then
            ErrorProvider.SetError(NitTextBox, Nothing)
            Me.QueriesTableAdapter1.existe_proveedor(NitTextBox.Text, flag)
            If (flag = False) Then
                nit = NitTextBox.Text
            Else
                ErrorProvider.SetError(NitTextBox, "EL NIT YA ESTA REGISTRADO")
                nit = String.Empty
            End If
        Else
            ErrorProvider.SetError(NitTextBox, "EL NIT DEBE CONTENER 10 NUMEROS")
            nit = String.Empty
        End If
    End Sub

    Private Sub Nom_proTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_proTextBox.KeyPress
        'validar solo caracteres nombre proveedor
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Nom_proTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Nom_proTextBox.Validating
        'validacion de nombre proveedor no vacio
        If (Nom_proTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(Nom_proTextBox, Nothing)
            nombre = Nom_proTextBox.Text
        Else
            ErrorProvider.SetError(Nom_proTextBox, "DEBE INTRODUCIR EL NOMBRE")
            nombre = String.Empty
        End If
    End Sub

    Private Sub Dir_provTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Dir_provTextBox.Validating
        ' que no este vacio la direccion
        If (Dir_provTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(Dir_provTextBox, Nothing)
            direc = Dir_provTextBox.Text
        Else
            ErrorProvider.SetError(Dir_provTextBox, "DEBE INTRODUCIR LA DIRECCIÓN")
            direc = String.Empty
        End If
    End Sub

    Private Sub Tel_provTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tel_provTextBox.KeyPress
        'valicadion solo numros del telefono
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Tel_provTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Tel_provTextBox.Validating
        'validar que el telefono no este vacio
        If (Tel_provTextBox.Text.Length > 0 And Tel_provTextBox.Text.Length = 8) Then
            ErrorProvider.SetError(Tel_provTextBox, Nothing)
            fono = Tel_provTextBox.Text
        Else
            ErrorProvider.SetError(Tel_provTextBox, "DEBE INTRODUCIR EL TELEFONO")
            fono = String.Empty
        End If
    End Sub

    Private Sub TipoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TipoTextBox.Validating
        'validar que el tipo no este vacio
        If (TipoTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(TipoTextBox, Nothing)
            tipo = TipoTextBox.Text
        Else
            ErrorProvider.SetError(TipoTextBox, "DEBE INTRODUCIR EL TIPO")
            tipo = String.Empty
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub
End Class