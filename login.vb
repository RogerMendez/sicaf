Public Class login
    Dim existe As Boolean
    Dim nivel As String
    Public codires As String

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        existe = False
        nivel = String.Empty
        codires = String.Empty
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cancelar
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ingresar
        Me.QueriesTableAdapter1.logeo(TextBox1.Text, TextBox2.Text, existe, nivel, codires)
        If (existe = True) Then
            MessageBox.Show("BIENVENIDO")
            If (nivel = "ADMINISTRADOR") Then
                Dim m As New Administrador
                m.Show()
            Else
                Dim em As New Principal
                em.Show()
            End If
            Close()
        Else
            MessageBox.Show("USTED NO ESTA REGISTRADO" & vbCrLf & "CONTACTECE CON EL ADMINISTRADOR")
        End If
    End Sub
End Class