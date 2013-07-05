
Public Class registroactivo
    Dim vutil As Integer
    Dim nit, des, uni, tdoc, ndoc, cond, estado, respo As String
    Dim precio As Double
    Public cod As String
    Dim codt, cods As Integer

    Private Sub registroactivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        respo = "Roger"
        nit = Nothing
        cod = String.Empty
        des = String.Empty
        uni = String.Empty
        tdoc = String.Empty
        ndoc = String.Empty
        precio = Nothing
        vutil = Nothing
        cond = String.Empty
        estado = "ALMACEN"
        codt = Nothing
        cods = Nothing
        If (Administrador.cod_respo = Nothing) Then
            respo = Principal.cod_respo
        Else
            respo = Administrador.cod_respo
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'seleccionar proveedores
        buscar_proveedor.ShowDialog()
        CprovTextBox.Text = My.Forms.buscar_proveedor.nombre
        nit = My.Forms.buscar_proveedor.nit
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        nit = Nothing
        cod = String.Empty
        des = String.Empty
        uni = String.Empty
        tdoc = String.Empty
        ndoc = String.Empty
        precio = Nothing
        vutil = Nothing
        cond = String.Empty
        estado = String.Empty
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'guardar
        Dim filas As Object
        filas = Nothing
        If (cod = Nothing Or des = Nothing Or uni = Nothing Or tdoc = Nothing Or ndoc = Nothing Or precio = Nothing Or vutil = Nothing Or cond = Nothing Or estado = Nothing Or cods = Nothing Or codt = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS REQUERIDOS")
        Else
            filas = Me.QueriesTableAdapter1.insertar_activof(cod, des.ToUpper(), uni, MarcaTextBox.Text, ProceTextBox.Text, Num_serTextBox.Text, tdoc, ndoc, precio, vutil, nit, respo, cond, estado, codt, cods)
            If (filas = 2) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub

    Private Sub CodafTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodafTextBox.Validating
        'validar que el codigo no esta vacio y no exista
        Dim flag As Boolean
        flag = False
        If (CodafTextBox.Text.Length > 0) Then
            Me.QueriesTableAdapter1.existe_activof(CodafTextBox.Text, flag)
            If (flag = False) Then
                ErrorProvider1.SetError(CodafTextBox, Nothing)
                cod = CodafTextBox.Text
            Else
                ErrorProvider1.SetError(CodafTextBox, "El Codigo De Activo Ya Existe")
                cod = String.Empty
            End If
        Else
            ErrorProvider1.SetError(CodafTextBox, "Debe Registrar El Codigo Del Activo Fijo")
            cod = Nothing
        End If
    End Sub

    Private Sub RichTextBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RichTextBox1.Validating
        'validar que la descripcion no este vacia
        If (RichTextBox1.Text.Length > 0) Then
            des = RichTextBox1.Text
            ErrorProvider1.SetError(RichTextBox1, Nothing)
        Else
            des = String.Empty
            ErrorProvider1.SetError(RichTextBox1, "Debe Registrar La Descripción Del Activo Fijo")
        End If
    End Sub

    Private Sub UnidadTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UnidadTextBox.Validating
        'validar que la unidad no este vacia
        If (UnidadTextBox.Text.Length > 0) Then
            uni = UnidadTextBox.Text
            ErrorProvider1.SetError(UnidadTextBox, Nothing)
        Else
            uni = String.Empty
            ErrorProvider1.SetError(UnidadTextBox, "Debe Registrar La Marca Del Activo")
        End If
    End Sub

    Private Sub TdocTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TdocTextBox.Validating
        'valodar que el tipo de documento no este vacio
        If (TdocTextBox.Text.Length > 0) Then
            tdoc = TdocTextBox.Text
            ErrorProvider1.SetError(TdocTextBox, Nothing)
        Else
            tdoc = String.Empty
            ErrorProvider1.SetError(TdocTextBox, "Debe Registrar El Tipo De Documento")
        End If
    End Sub

    Private Sub NrodocTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NrodocTextBox.Validating
        'validar que el numero de documento no este vacio
        If (NrodocTextBox.Text.Length > 0) Then
            ndoc = NrodocTextBox.Text
            ErrorProvider1.SetError(NrodocTextBox, Nothing)
        Else
            ndoc = String.Empty
            ErrorProvider1.SetError(NrodocTextBox, "Debe Registrar El Numero de Documento de Compra")
        End If
    End Sub

    Private Sub PrecioTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        'validar que el precion solo sean numeros ademas de ser decimal
        Dim numero As Decimal
        Dim cadena As String
        cadena = String.Empty
        Try
            cadena = PrecioTextBox.Text
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

    Private Sub PrecioTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PrecioTextBox.Validating
        'validar que el precio no este vacio
        If (PrecioTextBox.Text.Length > 0) Then
            precio = PrecioTextBox.Text
            ErrorProvider1.SetError(PrecioTextBox, Nothing)
        Else
            precio = Nothing
            ErrorProvider1.SetError(PrecioTextBox, "Debe Registrar El Precio Del Activo")
        End If
    End Sub

    Private Sub TasaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TasaTextBox.KeyPress
        'validar que la vida util solo sean numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TasaTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TasaTextBox.Validating
        'validar que la vida util no este vacia
        If (TasaTextBox.Text.Length > 0) Then
            vutil = TasaTextBox.Text
            ErrorProvider1.SetError(TasaTextBox, Nothing)
        Else
            vutil = Nothing
            ErrorProvider1.SetError(TasaTextBox, "Debe Registrar La Vida Util Dl Activo")
        End If
    End Sub

    Private Sub Cond_actTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cond_actTextBox.Validating
        'validar que la condicion del activo no este vacio
        If (Cond_actTextBox.Text.Length > 0) Then
            cond = Cond_actTextBox.Text
            ErrorProvider1.SetError(Cond_actTextBox, Nothing)
        Else
            cond = String.Empty
            ErrorProvider1.SetError(Cond_actTextBox, "Debe Registrar La Condicion Del Activo")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'seleccion tipo subtipo
        seleccion_tipo_sub.ShowDialog()
        Dim nomt, noms As String
        noms = String.Empty
        nomt = String.Empty
        codt = My.Forms.seleccion_tipo_sub.codt
        cods = My.Forms.seleccion_tipo_sub.cods
        Me.QueriesTableAdapter1.mostrar_nombres(codt, cods, nomt, noms)
        TextBox1.Text = nomt + " -> " + noms
    End Sub

End Class