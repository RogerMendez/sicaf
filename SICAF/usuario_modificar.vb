﻿Public Class usuario_modificar
    Dim nombre, ape, rol, tipo, nick, nick1, pass, confirpass, cod As String

    Private Sub usuario_modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nombre = String.Empty
        ape = String.Empty
        rol = String.Empty
        tipo = String.Empty
        nick = String.Empty
        pass = String.Empty
        confirpass = String.Empty
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'seleccionar usuario
        usuario_buscar.ShowDialog()
        TextBox2.Text = My.Forms.usuario_buscar.nom
        nick1 = My.Forms.usuario_buscar.nick
        cod = My.Forms.usuario_buscar.cod
        Me.UsersTableAdapter.seleccionar_usuario(SicafDataSet.users, TextBox2.Text, Nothing, nick1)
        nombre = NombresTextBox.Text
        ape = ApellidosTextBox.Text
        rol = ComboBox1.Text
        tipo = ComboBox2.Text
        nick = UsuarioTextBox.Text
        pass = Password0TextBox.Text
        confirpass = TextBox1.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'actualizar
        Dim filas As Object
        If (nombre = Nothing Or ape = Nothing Or rol = Nothing Or tipo = Nothing Or nick = Nothing Or pass = Nothing Or confirpass = Nothing) Then
            MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS OBLIGATORIOS")
            'MessageBox.Show(nombre & ape & rol & tipo & nick & pass & confirpass)
        Else
            If MessageBox.Show("¿Estas Seguro de Actualizar El Usuario?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.actualizar_usuario(nombre, ape, confirpass, rol, tipo, nick, cod)
                If (filas > 0) Then
                    Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL MODIFICAR LOS DATOS")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        nombre = String.Empty
        ape = String.Empty
        rol = String.Empty
        tipo = String.Empty
        nick = String.Empty
        pass = String.Empty
        confirpass = String.Empty
        Close()
    End Sub

    Private Sub NombresTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombresTextBox.KeyPress
        'validar nombre solo caracteres
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

    Private Sub NombresTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NombresTextBox.Validating
        'validar longitud del nombre
        If (NombresTextBox.Text.Length > 0) Then
            ErrorProvider1.SetError(NombresTextBox, Nothing)
            nombre = NombresTextBox.Text
        Else
            ErrorProvider1.SetError(NombresTextBox, "Deve Introducir El Nombre")
            nombre = String.Empty
        End If
    End Sub

    Private Sub ApellidosTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidosTextBox.KeyPress
        'validar solo letras apellidos
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

    Private Sub ApellidosTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ApellidosTextBox.Validating
        ' validar el apellido
        If (ApellidosTextBox.Text.Length > 0) Then
            ErrorProvider1.SetError(ApellidosTextBox, Nothing)
            ape = ApellidosTextBox.Text
        Else
            ErrorProvider1.SetError(ApellidosTextBox, "Deve Introducir El Apellido")
            ape = String.Empty
        End If
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
        'ESCOGER UNA OPCION rol
        If (ComboBox1.Text.Length > 0) Then
            rol = ComboBox1.Text
            ErrorProvider1.SetError(ComboBox1, Nothing)
        Else
            ErrorProvider1.SetError(ComboBox1, "Debe Escojer Una Opción")
            rol = String.Empty
        End If
    End Sub

    Private Sub ComboBox2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox2.Validating
        'ESCOGER UNA OPCION tipo
        If (ComboBox2.Text.Length > 0) Then
            tipo = ComboBox2.Text
            ErrorProvider1.SetError(ComboBox2, Nothing)
        Else
            ErrorProvider1.SetError(ComboBox2, "Debe Escojer Una Opción")
            tipo = String.Empty
        End If
    End Sub

    Private Sub UsuarioTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UsuarioTextBox.Validating
        'el nick no este vacio
        Dim flag As Boolean
        flag = False
        If (UsuarioTextBox.Text.Length > 0) Then
            Me.QueriesTableAdapter1.existe_nick(UsuarioTextBox.Text, flag)
            If (flag = False) Then
                nick = UsuarioTextBox.Text
                ErrorProvider1.SetError(UsuarioTextBox, Nothing)
            Else
                ErrorProvider1.SetError(UsuarioTextBox, "ESTE USUARIO YA ESTA REEGISTRARDO")
                nick = String.Empty
            End If
        Else
            ErrorProvider1.SetError(UsuarioTextBox, "Debe Registrar El NICK")
            nick = String.Empty
        End If
    End Sub

    Private Sub Password0TextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Password0TextBox.Validating
        'contraseña no este vacia
        If (Password0TextBox.Text.Length > 6) Then
            ErrorProvider1.SetError(Password0TextBox, Nothing)
            pass = Password0TextBox.Text
        Else
            ErrorProvider1.SetError(Password0TextBox, "La Contraseña Debe Tener Mas de 6 Caracteres")
            pass = String.Empty
        End If
    End Sub

    Private Sub TextBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        'confirmar contraseña
        If (TextBox1.Text = pass) Then
            ErrorProvider1.SetError(TextBox1, Nothing)
            confirpass = TextBox1.Text
        Else
            ErrorProvider1.SetError(TextBox1, "Las Contraseñas No Coinciden")
            confirpass = String.Empty
        End If
    End Sub
End Class