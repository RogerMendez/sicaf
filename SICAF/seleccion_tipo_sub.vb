Public Class seleccion_tipo_sub
    Public codt, cods As Integer
    Public nombre As String

    Private Sub seleccion_tipo_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SicafDataSet.tipo' table. You can move, or remove it, as needed.
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
        codt = Nothing
        nombre = String.Empty
        cods = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'salir
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'mostrar subtipo
        If (NombreComboBox.Text.Length > 0) Then
            GroupBox2.Visible = True
            codt = NombreComboBox.SelectedValue
            nombre = NombreComboBox.Text
            Me.SubtipoTableAdapter.mostrar_subtipo_codtipo(SicafDataSet.subtipo, codt)
            ErrorProvider1.SetError(NombreComboBox, Nothing)
            Label2.Text = "SubTipos En El Tipo " + nombre
        Else
            ErrorProvider1.SetError(NombreComboBox, "Debe Seleccionar Un Tipo")
        End If
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'nuevo tipo
        tipo_subtipo_registro.ShowDialog()
        codt = My.Forms.tipo_subtipo_registro.codt
        nombre = My.Forms.tipo_subtipo_registro.nombre
        If (codt.ToString.Length > 0) Then
            Me.SubtipoTableAdapter.mostrar_subtipo_codtipo(SicafDataSet.subtipo, codt)

            Label2.Text = "SubTipos En El Tipo " + nombre
        End If
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'agregar subtipo
        subtipo_agregar.ShowDialog()
        Me.SubtipoTableAdapter.mostrar_subtipo_codtipo(SicafDataSet.subtipo, codt)
        Me.TipoTableAdapter.Fill(Me.SicafDataSet.tipo)
    End Sub

    Private Sub SubtipoDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtipoDataGridView.DoubleClick
        'codt = NombreComboBox.SelectedValue
        codt = Me.SicafDataSet.subtipo(Me.SubtipoBindingSource.Position).codtipo
        cods = Me.SicafDataSet.subtipo(Me.SubtipoBindingSource.Position).codigosub
        Close()
    End Sub
End Class