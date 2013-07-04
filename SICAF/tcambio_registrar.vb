Public Class tcambio_registrar
    Dim respo As Integer
    Dim fecha As Date
    Dim dolar, ufv As Double

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Administrador.RegistrarToolStripMenuItem.Enabled = True
    End Sub

    Private Sub tcambio_registrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Administrador.codigo = Nothing) Then
            respo = Administrador.codigo
        Else
            respo = Principal.codigo
        End If
        fecha = Nothing
        dolar = Nothing
        ufv = Nothing
    End Sub

    Private Sub DolarTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DolarTextBox.KeyPress
        'validar que el dolar solo sean numeros ademas de ser decimal
        Dim numero As Decimal
        Dim cadena As String
        cadena = String.Empty
        Try
            cadena = DolarTextBox.Text
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

    Private Sub DolarTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DolarTextBox.Validating
        'validar que el dolar no esta vacio
        If (DolarTextBox.Text.Length > 0) Then
            dolar = DolarTextBox.Text
            ErrorProvider1.SetError(DolarTextBox, Nothing)
        Else
            ErrorProvider1.SetError(DolarTextBox, "DEBE REGISTRAR EL DOLAR")
            dolar = Nothing
        End If
    End Sub

    Private Sub UfvTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UfvTextBox.KeyPress
        'validar que el ufv solo sean numeros ademas de ser decimal
        Dim numero As Decimal
        Dim cadena As String
        cadena = String.Empty
        Try
            cadena = UfvTextBox.Text
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

    Private Sub UfvTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UfvTextBox.Validating
        'validar que el ufv no esta vacio
        If (UfvTextBox.Text.Length > 0) Then
            ufv = UfvTextBox.Text
            ErrorProvider1.SetError(UfvTextBox, Nothing)
        Else
            ErrorProvider1.SetError(UfvTextBox, "DEBE REGISTRAR EL UFV")
            ufv = Nothing
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'guardar
        Dim fila As Object
        If (dolar = Nothing Or ufv = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS")
        Else
            fila = Me.TpcambioTableAdapter.Insert(FechDateTimePicker.Text, DolarTextBox.Text, UfvTextBox.Text, respo)
            If (fila) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR")
            End If
        End If
    End Sub
End Class