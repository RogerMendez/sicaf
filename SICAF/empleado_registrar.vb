﻿Public Class empleado_registrar
    Dim ci As Integer
    Dim pat, nom, cargo, uni As String

    Private Sub empleado_registrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UnidadTableAdapter.Fill(Me.SicafDataSet.unidad)
        ci = Nothing
        pat = String.Empty
        nom = String.Empty
        uni = ComboBox1.Text
        cargo = String.Empty
    End Sub

    Private Sub CiTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CiTextBox.KeyPress
        'validar que el carnet solo sean numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CiTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CiTextBox.Validating
        'validar que el ci no este vacio no exista y tenga 7 u 8 numeros
        Dim flag As Boolean
        flag = False
        If (CiTextBox.Text.Length = 7 Or CiTextBox.Text.Length = 8) Then
            Me.QueriesTableAdapter1.existe_empleado(CiTextBox.Text, flag)
            If (flag = False) Then
                ci = CiTextBox.Text
                ErrorProvider1.SetError(CiTextBox, Nothing)
            Else
                ErrorProvider1.SetError(CiTextBox, "El Carnet De Identidad Ya Esta Registrado")
                ci = Nothing
            End If
        Else
            ErrorProvider1.SetError(CiTextBox, "El Carnet De Identidad Debe Tener 7 u 8 Numeros")
            ci = Nothing
        End If
    End Sub

    Private Sub PatTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PatTextBox.KeyPress
        'validar que paterno solo sean letras
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

    Private Sub PatTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PatTextBox.Validating
        'validar que el paterno no este vacio
        If (PatTextBox.Text.Length > 0) Then
            pat = PatTextBox.Text
            ErrorProvider1.SetError(PatTextBox, Nothing)
        Else
            pat = String.Empty
            ErrorProvider1.SetError(PatTextBox, "Debe Registrar El Nombre Del Empleado")
        End If
    End Sub

    Private Sub MatTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MatTextBox.KeyPress
        'validar que materno solo sean letras
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

    Private Sub NombresTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombresTextBox.KeyPress
        'validar que el nombre solo sean letras
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
        'validar que el nombre no este vacio
        If (NombresTextBox.Text.Length > 0) Then
            nom = NombresTextBox.Text
            ErrorProvider1.SetError(NombresTextBox, Nothing)
        Else
            nom = String.Empty
            ErrorProvider1.SetError(NombresTextBox, "Debe Registrar El Nombre Del Empleado")
        End If
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
        'validar que la unidad no este vacia y exista
        Dim flag As Boolean
        flag = False
        If (ComboBox1.Text.Length > 0) Then
            Me.QueriesTableAdapter1.existe_unidad(ComboBox1.Text, flag)
            If (flag = True) Then
                uni = ComboBox1.Text
                ErrorProvider1.SetError(ComboBox1, Nothing)
            Else
                uni = String.Empty
                ErrorProvider1.SetError(ComboBox1, "Debe Seleccionar Una Unidad Valida")
            End If
        Else
            uni = String.Empty
            ErrorProvider1.SetError(ComboBox1, "Debe Seleccionar Una Unidad")
        End If
    End Sub

    Private Sub Telf_funTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Telf_funTextBox.KeyPress
        'validar que el telefono celular solo sean numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CargoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CargoTextBox.Validating
        'validar que el cargo no este vacio
        If (CargoTextBox.Text.Length > 0) Then
            cargo = CargoTextBox.Text
            ErrorProvider1.SetError(CargoTextBox, Nothing)
        Else
            cargo = String.Empty
            ErrorProvider1.SetError(CargoTextBox, "Debe Seleccionar El Cargo Del Empleado")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        ci = Nothing
        pat = String.Empty
        nom = String.Empty
        cargo = String.Empty
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'guardar
        Dim filas As Object
        If (ci = Nothing Or pat = Nothing Or nom = Nothing Or uni = Nothing Or cargo = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS REQUERIDOS")
        Else
            filas = Me.EmpleadoTableAdapter.Insert(ci, pat, MatTextBox.Text, nom, uni, Telf_funTextBox.Text, cargo)
            If (filas > 0) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class