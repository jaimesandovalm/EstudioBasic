Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Declaracion de variables
        Dim num1 As Integer
        Dim num2 As Integer

        Dim suma, resta As Integer
        Dim mult, div, pot, raiz As Double

        'Entrada de datos
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)

        'Operacion Matématica

        suma = (num1 + num2)
        resta = (num1 - num2)
        mult = (num1 * num2)
        div = (num1 / num2)
        pot = (num1 ^ num2)
        raiz = (num1 ^ (1 / 2))

        'Imprimir Resultados
        txtsuma.Text = suma
        txtresta.Text = resta
        txtmult.Text = mult
        txtdiv.Text = div
        txtpot.Text = pot
        txtraiz.Text = raiz
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnum1.Clear()
        txtnum2.Clear()
        txtsuma.Clear()
        txtresta.Clear()
        txtmult.Clear()
        txtdiv.Clear()
        txtpot.Clear()
        txtraiz.Clear()

    End Sub


    Private Sub btncalculararea_Click(sender As Object, e As EventArgs) Handles btncalculararea.Click
        'Declaracion de variables
        Const pi As Double = 3.14159 'delcaracion de una constante
        Dim radio As Double
        Dim area As Double

        'Entrada de las variables
        radio = Val(txtradio.Text)

        'Calcular el Radio
        area = pi * (radio ^ 2)

        'Salida del Resultado
        txtarea.Text = area


    End Sub

    Private Sub btnmonto_Click(sender As Object, e As EventArgs) Handles btnmonto.Click
        'Declaracion de Variables
        Dim cant As Integer
        Dim punitario, desc, pparcial, pneto As Single
        Dim marcadesc As Boolean

        'Entrada Datos
        punitario = Val(txtpunitario.Text)
        cant = Val(txtcant.Text)
        marcadesc = chkdesc.Checked

        'Inicializar variable dscto
        desc = 0

        'Proceso
        pparcial = cant * punitario

        'Aplicar Dscto
        If (marcadesc = True) Then
            desc = pparcial * 7 / 100
        End If

        pneto = pparcial - desc
        'Salida de Informacion
        txtpparcial.Text = pparcial
        txtpdesc.Text = desc
        txtpneto.Text = pneto

    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        txtpunitario.Clear()
        txtcant.Clear()
        txtpparcial.Clear()
        txtpdesc.Clear()
        txtpneto.Clear()

        chkdesc.Checked = False

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Declaracion de Variables
        Dim notaa, notab, notac As Byte
        Dim promedio As Single
        Dim situacion As String

        'Entrada Datos
        notaa = Val(txtnotaa.Text)
        notab = Val(txtnotab.Text)
        notac = Val(txtnotac.Text)

        'Proceso
        promedio = (notaa * 3 + notab * 4 + notac * 2) / 9

        'Evaluacion de Estado
        If (promedio >= 5.5) Then
            situacion = "Aprobado"
        Else
            situacion = "Reprobado"

        End If

        'Salida Resultados
        txtprom.Text = promedio
        txtsitu.Text = situacion

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtnotaa.Clear()
        txtnotab.Clear()
        txtnotac.Clear()
        txtprom.Clear()
        txtsitu.Clear()

    End Sub

    Private Sub btnutilidad_Click(sender As Object, e As EventArgs) Handles btnutilidad.Click
        'Declaracion de Variables
        Dim salario, utilidad As Double
        Dim antiguedad As Byte

        'Entrada de Datos
        salario = Val(txtsalario.Text)
        antiguedad = Val(cboantiguedad.Text)

        'Proceso
        If (antiguedad < 1) Then
            utilidad = salario * 5 / 100
        ElseIf (antiguedad >= 1 And antiguedad < 2) Then
            utilidad = salario * 7 / 100
        ElseIf (antiguedad >= 2 And antiguedad < 5) Then
            utilidad = salario * 10 / 100
        ElseIf (antiguedad >= 5 And antiguedad < 10) Then
            utilidad = salario * 15 / 100
        ElseIf (antiguedad >= 10) Then
            utilidad = salario * 20 / 100
        End If

        'Salidad de Datos
        txtutilidad.Text = utilidad

    End Sub

    Private Sub btnnuevouti_Click(sender As Object, e As EventArgs) Handles btnnuevouti.Click
        txtsalario.Clear()
        txtsalario.Clear()

    End Sub

    Private Sub btnsaliruti_Click(sender As Object, e As EventArgs) Handles btnsaliruti.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btndia.Click
        'Declaracion de Variables
        Dim num As Integer
        Dim dia As String

        'Entrada Datos
        num = Val(txtnumero.Text)

        'Proceso
        Select Case (num)
            Case 1
                dia = "lunes"
            Case 2
                dia = "martes"
            Case 3
                dia = "miercoles"
            Case 4
                dia = "jueves"
            Case 5
                dia = "viernes"
            Case 6
                dia = "sabado"
            Case 7
                dia = "domingo"
            Case Else
                dia = "Error, Intente con un numero nuevo"
        End Select

        'Salida de Datos
        txtdia.Text = dia


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnnuevodia.Click
        txtnumero.Clear()
        txtdia.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnsalirdia.Click
        Me.Close()
    End Sub
End Class
