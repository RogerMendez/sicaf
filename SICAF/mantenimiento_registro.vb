Public Class mantenimiento_registro
    Dim codaf, descrip, tipman, personmant As String

    Private Sub mantenimiento_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codaf = String.Empty
        descrip = String.Empty
        tipman = String.Empty
        personmant = String.Empty
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'seleccionar activo
        Dim a As New activof_seleccion()
        a.ShowDialog()
        codaf = a.codaf
        Cod_actTextBox.Text = codaf
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'guardar
        Dim filas As Object
        If (codaf = Nothing Or descrip = Nothing Or tipman = Nothing Or personmant = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR LOS CAMPOS OBLIGATORIOS")
        Else
            Dim costo_p, costo_m As Double
            costo_p = Cost_partTextBox.Text
            costo_m = Cost_manTextBox.Text
            'MessageBox.Show(Cost_partTextBox.Text)
            filas = Me.QueriesTableAdapter1.insertar_mantenimiento(codaf, Fech_manDateTimePicker.Text, Fech_retDateTimePicker.Text, descrip, tipman, costo_p, costo_m, personmant)
            If (filas = 2) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR")
            End If
        End If
    End Sub

    Private Sub Desc_manRichTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Desc_manRichTextBox.Validating
        'validar que la descripcion no este vacio
        If (Desc_manRichTextBox.Text.Length > 0) Then
            descrip = Desc_manRichTextBox.Text
            ErrorProvider1.SetError(Desc_manRichTextBox, Nothing)
        Else
            descrip = String.Empty
            ErrorProvider1.SetError(Desc_manRichTextBox, "Debe Registrar La Descripcion")
        End If
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
        'validar seleccion tipo mantenimiento
        If (ComboBox1.Text.Length > 0) Then
            tipman = ComboBox1.Text
            ErrorProvider1.SetError(ComboBox1, Nothing)
        Else
            tipman = String.Empty
            ErrorProvider1.SetError(ComboBox1, "Debe Seleccionar Un Mantenimiento")
        End If
    End Sub

    Private Sub Cost_partTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cost_partTextBox.KeyPress
        'validar que el costo partes solo sean numeros ademas de ser decimal
        Dim numero As Decimal
        Dim cadena As String
        cadena = String.Empty
        Try
            cadena = Cost_partTextBox.Text()
            numero = Convert.ToDecimal(e.KeyChar.ToString)

        Catch ex As Exception
            If e.KeyChar <> "," Or e.KeyChar.Equals(vbBack) Then
                e.Handled = True
            Else

                If (cadena.LastIndexOf(",") > 0) Then
                    e.Handled = True
                End If
            End If
        End Try
    End Sub

    Private Sub Cost_manTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cost_manTextBox.KeyPress
        'validar que el costo mantenimiento solo sean numeros ademas de ser decimal
        Dim numero As Decimal
        Dim cadena As String
        cadena = String.Empty
        Try
            cadena = Cost_manTextBox.Text
            numero = Convert.ToDecimal(e.KeyChar.ToString)

        Catch ex As Exception
            If e.KeyChar <> "," Or e.KeyChar.Equals(vbBack) Then
                e.Handled = True
            Else

                If (cadena.LastIndexOf(",") > 0) Then
                    e.Handled = True
                End If
            End If
        End Try
    End Sub

    Private Sub Pers_manTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Pers_manTextBox.Validating
        If (Pers_manTextBox.Text.Length > 0) Then
            personmant = Pers_manTextBox.Text
            ErrorProvider1.SetError(Pers_manTextBox, Nothing)
        Else
            personmant = String.Empty
            ErrorProvider1.SetError(Pers_manTextBox, "Debe Registrar Al Encargado de Mantenimiento")
        End If
    End Sub

End Class