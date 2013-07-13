Public Class login
    Dim existe As Boolean
    Dim nivel As String
    Public cod_res As String
    Public unidad As String

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        existe = False
        nivel = String.Empty
        cod_res = String.Empty
        unidad = String.Empty
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ingresar
        If TextBox1.Text = TextBox2.Text Then
            Me.QueriesTableAdapter1.unidad_empleado(TextBox1.Text, unidad)
            If unidad = "FALSE" Then
                MessageBox.Show("USTED NO ES UN EMPLEADO" & vbCrLf & "CONTACTECE CON EL ADMINISTRADOR")
            Else
                Principal.Show()
                TextBox1.Text = String.Empty
                TextBox2.Text = String.Empty
            End If
            Close()
        Else
            Me.QueriesTableAdapter1.logeo(TextBox1.Text, TextBox2.Text, existe, nivel, cod_res)
            If (existe = True) Then
                MessageBox.Show("BIENVENIDO")
                If (nivel = "ADMINISTRADOR") Then
                    Administrador.Show()
                    TextBox1.Text = String.Empty
                    TextBox2.Text = String.Empty
                End If
                Close()
            Else
                MessageBox.Show("USTED NO ESTA REGISTRADO" & vbCrLf & "CONTACTECE CON EL ADMINISTRADOR")
            End If
        End If
    End Sub
End Class