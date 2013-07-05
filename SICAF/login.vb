Public Class login
    Dim existe As Boolean
    Dim nivel As String
    Public cod_res As String

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        existe = False
        nivel = String.Empty
        cod_res = String.Empty
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ingresar
        Me.QueriesTableAdapter1.logeo(TextBox1.Text, TextBox2.Text, existe, nivel, cod_res)
        If (existe = True) Then
            MessageBox.Show("BIENVENIDO")
            If (nivel = "ADMINISTRADOR") Then
                Administrador.Show()
            Else
                Principal.Show()
            End If
            Close()
        Else
            MessageBox.Show("USTED NO ESTA REGISTRADO" & vbCrLf & "CONTACTECE CON EL ADMINISTRADOR")
        End If
    End Sub
End Class