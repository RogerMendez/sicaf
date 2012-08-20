Public Class registro_proveedor
    Public nombre As String
    Dim nit, direc, fono, tipo As String

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Administrador.RegistrarProveedorToolStripMenuItem.Enabled = True
    End Sub

    Private Sub registro_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nombre = Nothing
        nit = Nothing
        direc = Nothing
        fono = Nothing
        tipo = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        nombre = Nothing
        nit = Nothing
        direc = Nothing
        fono = Nothing
        tipo = Nothing
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal ev As System.EventArgs) Handles Button1.Click
        'guardar
        Dim filas As Object
        If (nombre = Nothing Or nit = Nothing Or direc = Nothing Or fono = Nothing Or tipo = Nothing) Then
            MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS REQUERIDOS")
        Else
            filas = Me.ProveedoresTableAdapter.Insert(nit, nombre, direc, fono, Wev_provTextBox.Text, tipo)
            If (filas = 1) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
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
            Me.QueriesTableAdapter1.existe_proveedor(NitTextBox.Text, flag)
            If (flag = False) Then
                ErrorProvider.SetError(NitTextBox, Nothing)
                nit = NitTextBox.Text
            Else
                ErrorProvider.SetError(NitTextBox, "EL NIT YA ESTA REGISTRADO")
                nit = Nothing
            End If
        Else
            ErrorProvider.SetError(NitTextBox, "EL NIT DEBE CONTENER 10 NUMEROS")
            nit = Nothing
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
            nombre = Nothing
        End If
    End Sub

    Private Sub Dir_provTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Dir_provTextBox.Validating
        ' que no este vacio la direccion
        If (Dir_provTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(Dir_provTextBox, Nothing)
            direc = Dir_provTextBox.Text
        Else
            ErrorProvider.SetError(Dir_provTextBox, "DEBE INTRODUCIR LA DIRECCIÓN")
            direc = Nothing
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
            fono = Nothing
        End If
    End Sub

    Private Sub TipoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TipoTextBox.Validating
        'validar que el tipo no este vacio
        If (TipoTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(TipoTextBox, Nothing)
            tipo = TipoTextBox.Text
        Else
            ErrorProvider.SetError(TipoTextBox, "DEBE INTRODUCIR EL TIPO")
            tipo = Nothing
        End If
    End Sub
End Class