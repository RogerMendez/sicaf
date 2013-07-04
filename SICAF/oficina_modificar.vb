Public Class oficina_modificar
    Dim cod, descr, ubi, piso, uni, pat, mat, nom As String

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Administrador.ModificarOficicaToolStripMenuItem.Enabled = True
    End Sub

    Private Sub oficina_modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UnidadTableAdapter.Fill(Me.SicafDataSet.unidad)
        cod = String.Empty
        descr = String.Empty
        ubi = String.Empty
        piso = String.Empty
        uni = String.Empty
        pat = String.Empty
        mat = String.Empty
        nom = String.Empty
    End Sub

    Private Sub Cod_ofiTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cod_ofiTextBox.Validating
        'validar codigo oficia no este vacio y no exista
        Dim flag As Boolean
        flag = False
        If (Cod_ofiTextBox.Text.Length > 0) Then
            Me.QueriesTableAdapter1.existe_oficina(Cod_ofiTextBox.Text, flag)
            If (flag = False) Then
                ErrorProvider.SetError(Cod_ofiTextBox, Nothing)
                cod = Cod_ofiTextBox.Text
            Else
                cod = String.Empty
                ErrorProvider.SetError(Cod_ofiTextBox, "El Codigo De La Oficina Ya existe")
            End If
        Else
            cod = String.Empty
            ErrorProvider.SetError(Cod_ofiTextBox, "Debe Registrar El Codigo De Oficina")
        End If
    End Sub

    Private Sub RichTextBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RichTextBox1.Validating
        'validar que la descripcion no este vacia
        If (RichTextBox1.Text.Length > 0) Then
            descr = RichTextBox1.Text
            ErrorProvider.SetError(RichTextBox1, Nothing)
        Else
            descr = String.Empty
            ErrorProvider.SetError(RichTextBox1, "Este Campo No Puede estar Vacio")
        End If
    End Sub

    Private Sub UbicacionTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UbicacionTextBox.Validating
        'validar que la ubicacion no este vacio
        If (UbicacionTextBox.Text.Length > 0) Then
            ubi = UbicacionTextBox.Text
            ErrorProvider.SetError(UbicacionTextBox, Nothing)
        Else
            ubi = UbicacionTextBox.Text
            ErrorProvider.SetError(UbicacionTextBox, "Debe Registrar La Ubicación")
        End If
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
        'validar que el piso este seleccionado
        If (ComboBox1.Text.Length > 0) Then
            ErrorProvider.SetError(ComboBox1, Nothing)
            piso = ComboBox1.Text
        Else
            ErrorProvider.SetError(ComboBox1, "Debe Seleccionar Un Piso")
            piso = String.Empty
        End If
    End Sub

    Private Sub ComboBox2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox2.Validating
        'validar seleccionar codigo unidad
        Dim flag As Boolean
        flag = False
        If (ComboBox2.Text.Length > 0) Then
            Me.QueriesTableAdapter1.existe_unidad(ComboBox2.Text, flag)
            If (flag = True) Then
                ErrorProvider.SetError(ComboBox2, Nothing)
                uni = ComboBox2.Text
            Else
                ErrorProvider.SetError(ComboBox2, "La Unidad No Existe")
                uni = String.Empty
            End If
        Else
            ErrorProvider.SetError(ComboBox2, "Debe Seleccionar Una Unidad")
            uni = String.Empty
        End If
    End Sub

    Private Sub Pat_resoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pat_resoTextBox.KeyPress
        'validar que solo sean letras 
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

    Private Sub Pat_resoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Pat_resoTextBox.Validating
        'validar que el paterno no este vacio
        If (Pat_resoTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(Cod_ofiTextBox, Nothing)
            pat = Pat_resoTextBox.Text
        Else
            ErrorProvider.SetError(Pat_resoTextBox, "Debe Registrar El Apellido Paterno del Resposable")
            pat = String.Empty
        End If
    End Sub

    Private Sub Mat_respTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Mat_respTextBox.KeyPress
        'validar que solo sean letras 
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

    Private Sub Mat_respTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Mat_respTextBox.Validating
        'validar que el materno no este vacio
        If (Mat_respTextBox.Text.Length > 0) Then
            ErrorProvider.SetError(Mat_respTextBox, Nothing)
            mat = Mat_respTextBox.Text
        Else
            ErrorProvider.SetError(Mat_respTextBox, "Debe Registrar El Apellido Materno Del Responsable")
            mat = String.Empty
        End If
    End Sub

    Private Sub Nom_resoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_resoTextBox.KeyPress
        'validar que solo sean letras 
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

    Private Sub Nom_resoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Nom_resoTextBox.Validating
        'validar que el nombre no este vacio
        If (Nom_resoTextBox.Text.Length > 0) Then
            nom = Nom_resoTextBox.Text
            ErrorProvider.SetError(Nom_resoTextBox, Nothing)
        Else
            nom = String.Empty
            ErrorProvider.SetError(Nom_resoTextBox, "Debe Registrar El Nombre Del Responsable")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        cod = String.Empty
        descr = String.Empty
        ubi = String.Empty
        piso = String.Empty
        uni = String.Empty
        pat = String.Empty
        mat = String.Empty
        nom = String.Empty
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'guardar()
        Dim filas As Object
        If (nom = Nothing Or pat = Nothing Or mat = Nothing Or cod = Nothing Or descr = Nothing Or ubi = Nothing Or piso = Nothing Or uni = Nothing) Then
            MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS")
        Else
            If MessageBox.Show("¿Estas Seguro de Modificar La Oficna?", "Mensaje de confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                filas = Me.QueriesTableAdapter1.actualizar_oficina(descr, ubi, uni, piso, pat, mat, nom, cod)
                If (filas > 0) Then
                    Close()
                Else
                    MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'seleccionar oficina
        oficina_seleccionar.ShowDialog()
        cod = My.Forms.oficina_seleccionar.cod
        Cod_ofiTextBox.Text = cod
        Me.OficinaTableAdapter.seleccionar_oficina(SicafDataSet.oficina, cod)
        descr = RichTextBox1.Text
        ubi = UbicacionTextBox.Text
        piso = ComboBox1.Text
        uni = ComboBox2.Text
        pat = Pat_resoTextBox.Text
        mat = Mat_respTextBox.Text
        nom = Nom_resoTextBox.Text
    End Sub
End Class