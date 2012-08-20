Public Class tipo_subtipo_registro
    Public codt As Integer
    Public nombre As String

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Administrador.RegistroTipoToolStripMenuItem.Enabled = True
    End Sub

    Private Sub tipo_subtipo_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codt = Nothing
        nombre = String.Empty
        GroupBox2.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Agragar Suptipo
        Dim filas As Object
        If (TextBox1.Text.Length > 0) Then
            ErrorProvider1.SetError(TextBox1, Nothing)
            filas = Me.QueriesTableAdapter1.insertar_tipo(TextBox1.Text, codt)
            If (filas) Then
                GroupBox2.Visible = True
                Me.SubtipoTableAdapter.mostrar_subtipo_codtipo(SicafDataSet.subtipo, codt)
                nombre = TextBox1.Text
                Label2.Text = "SubTipos En El Tipo " + nombre
                TextBox1.Text = String.Empty
            End If
        Else
            ErrorProvider1.SetError(TextBox1, "Debe Ingresasr Un Nombre de Tipo")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'agregar subtipo
        Dim filas As Object
        If (TextBox2.Text.Length > 0) Then
            ErrorProvider1.SetError(TextBox2, Nothing)
            filas = Me.SubtipoTableAdapter.Insert(TextBox2.Text, codt)
            If (filas) Then
                Me.SubtipoTableAdapter.mostrar_subtipo_codtipo(SicafDataSet.subtipo, codt)
                TextBox2.Text = String.Empty
            Else
                MessageBox.Show("OCURRIO UN ERROR AL AGREGAR EL TIPO")
            End If
        Else
            ErrorProvider1.SetError(TextBox2, "Debe Registrar Un Subtipo")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'salir
        Close()
    End Sub
End Class