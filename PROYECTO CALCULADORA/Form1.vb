Public Class Form1
    Public aux1, aux2, aux3, sinresultado As Double
    Public operacion As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        txtvisor.Text = txtvisor.Text & "1"
        lbloperacion.Text = lbloperacion.Text & "1"


    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtvisor.Text = txtvisor.Text & "2"
        lbloperacion.Text = lbloperacion.Text & "2"
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtvisor.Text = txtvisor.Text & "3"
        lbloperacion.Text = lbloperacion.Text & "3"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtvisor.Text = txtvisor.Text & "4"
        lbloperacion.Text = lbloperacion.Text & "4"
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtvisor.Text = txtvisor.Text & "5"
        lbloperacion.Text = lbloperacion.Text & "5"
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtvisor.Text = txtvisor.Text & "6"
        lbloperacion.Text = lbloperacion.Text & "6"
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtvisor.Text = txtvisor.Text & "7"
        lbloperacion.Text = lbloperacion.Text & "7"
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtvisor.Text = txtvisor.Text & "8"
        lbloperacion.Text = lbloperacion.Text & "8"
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtvisor.Text = txtvisor.Text & "9"
        lbloperacion.Text = lbloperacion.Text & "9"
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtvisor.Text = txtvisor.Text & "0"
        lbloperacion.Text = lbloperacion.Text & "0"
    End Sub
    Private Sub btncoma_Click(sender As Object, e As EventArgs) Handles btncoma.Click

        If txtvisor.Text = "" Then
            txtvisor.Text = "0,"
            lbloperacion.Text = "0,"
        ElseIf existecoma(txtvisor.Text) = False Then
            txtvisor.Text = txtvisor.Text & ","
            lbloperacion.Text = lbloperacion.Text & ","
        End If


    End Sub
    Private Function existecoma(ByVal cadena As String) As Boolean
        Dim largo As Double
        Dim respuesta As Boolean = False
        largo = cadena.Length
        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "," Then
                respuesta = True

            End If
        Next
        Return respuesta
    End Function

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        aux2 = Val(txtvisor.Text)

        Select Case operacion


            Case "suma"
                operacion = 0.0
                txtvisor.Text = aux1 + aux2

                lbloperacion.Text = lbloperacion.Text & " = " & txtvisor.Text

            Case "resta"
                operacion = 0.0
                aux2 = Val(txtvisor.Text)
                txtvisor.Text = aux1 - aux2
                lbloperacion.Text = lbloperacion.Text & " = " & txtvisor.Text
            Case "multiplicar"
                operacion = 0.0
                txtvisor.Text = aux1 * aux2
                lbloperacion.Text = lbloperacion.Text & " = " & txtvisor.Text
            Case "dividir"
                operacion = 0.0
                aux2 = Val(txtvisor.Text)
                txtvisor.Text = aux1 / aux2
                lbloperacion.Text = lbloperacion.Text & " = " & txtvisor.Text

            Case "porcentaje"
                operacion = 0.0
                txtvisor.Text = aux1 * aux2 / 100
                lbloperacion.Text = lbloperacion.Text & " = " & txtvisor.Text


        End Select


    End Sub
    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click

        aux1 = Val(txtvisor.Text)

        operacion = "suma"
        lbloperacion.Text = lbloperacion.Text & " + "

        txtvisor.Text = ""

    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click

        aux1 = Val(txtvisor.Text)

        operacion = "resta"
        lbloperacion.Text = lbloperacion.Text & " - "
        txtvisor.Text = ""

    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        aux1 = Val(txtvisor.Text)
        operacion = "multiplicar"
        lbloperacion.Text = lbloperacion.Text & " * "
        txtvisor.Text = ""
    End Sub
    Private Sub btndivi_Click(sender As Object, e As EventArgs) Handles btndivi.Click
        aux1 = Val(txtvisor.Text)
        operacion = "dividir"
        lbloperacion.Text = lbloperacion.Text & " / "
        txtvisor.Text = ""
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs)
        txtvisor.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtvisor.Text = ""
        aux1 = 0.0
        aux2 = 0.0
        lbloperacion.Text = ""
    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        If txtvisor.Text <> "" Then
            txtvisor.Text = Mid((txtvisor.Text), 1, (Len(txtvisor.Text) - 1))
            lbloperacion.Text = txtvisor.Text
        End If
        'txtvisor.Text = Mid(txtvisor.Text, 4, 3)

        'Try
        '    Dim largo As Double
        '    Dim largolabel As Double
        '    If txtvisor.Text <> "" Then
        '        largo = txtvisor.Text.Length
        '        largolabel = lbloperacion.Text.Length
        '        txtvisor.Text = Mid(txtvisor.Text, 1, largo - 1)
        '        lbloperacion.Text = Mid(lbloperacion.Text, 1, largolabel - 1)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnporcentaje_Click(sender As Object, e As EventArgs) Handles btnporcentaje.Click

        aux1 = Val(txtvisor.Text)
        operacion = "porcentaje"
        lbloperacion.Text = lbloperacion.Text & " % "
        txtvisor.Clear()

    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        Dim raiz As Double
        aux1 = Val(txtvisor.Text)
        operacion = "raiz"
        raiz = Val(txtvisor.Text) ^ (1 / 2)
        txtvisor.Text = raiz
        lbloperacion.Text = lbloperacion.Text & " (√ 2) " & " = " & raiz
    End Sub

    Private Sub lbloperacion_Click(sender As Object, e As EventArgs) Handles lbloperacion.Click


    End Sub



End Class
