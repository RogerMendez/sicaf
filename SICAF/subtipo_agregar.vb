Public Class subtipo_agregar
    Dim codt As Integer
    Dim nombre As String

    Private Sub subtipo_agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Visible = False
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
        codt = NombreComboBox.SelectedValue
        'My.Forms.seleccion_tipo_sub.codt
        nombre = NombreComboBox.Text
        'My.Forms.seleccion_tipo_sub.nombre
        If (nombre.Length > 0 And codt.ToString().Length > 0) Then
            GroupBox2.Visible = True
            codt = NombreComboBox.SelectedValue
            nombre = NombreComboBox.Text
            Me.SubtipoTableAdapter.mostrar_suptipo_codtipo(SicafDataSet.subtipo, codt)
            Label2.Text = "SubTipos En El Tipo " + nombre
        Else
            codt = Nothing
            nombre = String.Empty
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'mostrar subtipo
        If (NombreComboBox.Text.Length > 0) Then
            GroupBox2.Visible = True
            codt = NombreComboBox.SelectedValue
            nombre = NombreComboBox.Text
            Me.SubtipoTableAdapter.mostrar_suptipo_codtipo(SicafDataSet.subtipo, codt)
            ErrorProvider1.SetError(NombreComboBox, Nothing)
            Label2.Text = "SubTipos En El Tipo " + nombre
        Else
            ErrorProvider1.SetError(NombreComboBox, "Debe Seleccionar Un Tipo")
        End If
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'agregar subtipo
        Dim filas As Object
        If (TextBox2.Text.Length > 0) Then
            ErrorProvider1.SetError(TextBox2, Nothing)
            filas = Me.SubtipoTableAdapter.Insert(TextBox2.Text, codt)
            If (filas) Then
                Me.SubtipoTableAdapter.mostrar_suptipo_codtipo(SicafDataSet.subtipo, codt)
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