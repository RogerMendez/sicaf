Public Class unidad_registrar
    Dim cod As String
    Dim des As String

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Administrador.ReToolStripMenuItem.Enabled = True
    End Sub

    Private Sub unidad_registrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cod = String.Empty
        des = String.Empty
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'guardar
        Dim filas As Object
        If (cod = Nothing Or des = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS")
        Else
            filas = Me.UnidadTableAdapter.Insert(cod, des)
            If (filas > 0) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub

    Private Sub Cod_uniTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cod_uniTextBox.Validating
        'validar que el codigo no este vacio y que no exista
        Dim flag As Boolean
        flag = False
        If (Cod_uniTextBox.Text.Length > 0) Then
            Me.QueriesTableAdapter1.existe_unidad(Cod_uniTextBox.Text, flag)
            If (flag = False) Then
                cod = Cod_uniTextBox.Text
                ErrorProvider1.SetError(Cod_uniTextBox, Nothing)
            Else
                ErrorProvider1.SetError(Cod_uniTextBox, "El Codigo Ya Esta Registrado")
            End If
        Else
            ErrorProvider1.SetError(Cod_uniTextBox, "Debe Ingresar El Codigo")
            cod = String.Empty
        End If
    End Sub

    Private Sub RichTextBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RichTextBox1.Validating
        'validar la descripcion de la unidad
        If (RichTextBox1.Text.Length > 0) Then
            des = RichTextBox1.Text
            ErrorProvider1.SetError(RichTextBox1, Nothing)
        Else
            ErrorProvider1.SetError(RichTextBox1, "Debe Ingresar La Descripción")
            des = String.Empty
        End If
    End Sub
End Class