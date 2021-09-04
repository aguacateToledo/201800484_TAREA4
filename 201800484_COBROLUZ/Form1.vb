Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nit As String = ""
        Dim saldoAnterior As Double = 0
        Dim consumoKiloWattsPH As Double = 0
        Dim pagoInicial As Double = 0
        Dim mora As Double = 0
        Dim descuento As Double = 0
        Dim pagoTotal As Double = 0
        Dim precio As Double = 0


        saldoAnterior = Val(txtSaldoAnterior.Text)
            consumoKiloWattsPH = Val(txtConsumoKiloW.Text)
            Servicios(FILA) = cbxServicio.Text
            Tarifas(FILA) = cbxTarifa.Text

            Select Case cbxServicio.Text
                Case "residencial"
                    Select Case consumoKiloWattsPH
                        Case 1 To 100
                            precio = 0.99
                        Case 101 To 300
                            precio = 1.2
                        Case Is >= 301
                            precio = 3.0

                    End Select
                Case "industrial"
                    Select Case consumoKiloWattsPH
                        Case 1 To 100
                            precio = 1.99
                        Case 101 To 300
                            precio = 2.2
                        Case Is >= 301
                            precio = 4.0

                    End Select
                Case Else

            End Select

            Select Case cbxTarifa.Text
                Case "social"
                    descuento = 0.02
                Case "no social"
                    descuento = 0.01
            End Select

            If saldoAnterior > 0 Then
                mora = saldoAnterior * 0.02
            End If

            pagoInicial = precio * consumoKiloWattsPH
            PagosInicial(FILA) = pagoInicial
            SaldosAnteriores(FILA) = saldoAnterior
            Moras(FILA) = mora
            pagoTotal = saldoAnterior + (mora) + pagoInicial
            descuento = pagoTotal * descuento
            Descuentos(FILA) = descuento
            pagoTotal += descuento
            PagosTotales(FILA) = pagoTotal

            FILA += 1

            printList()

    End Sub

    Sub printList()
        Dim X As Byte
        listDescuento.Items.Clear()
        listMora.Items.Clear()
        listPagoInicial.Items.Clear()
        listPagoTotal.Items.Clear()
        listSaldoAnterior.Items.Clear()
        listServicios.Items.Clear()
        listTarifa.Items.Clear()

        For X = 0 To 10
            If Servicios(X) <> Nothing Then
                listDescuento.Items.Add(Str(Descuentos(X)))
                listMora.Items.Add(Str(Moras(X)))
                listPagoInicial.Items.Add(Str(PagosInicial(X)))
                listPagoTotal.Items.Add(Str(PagosTotales(X)))
                listSaldoAnterior.Items.Add(Str(SaldosAnteriores(X)))
                listServicios.Items.Add((Servicios(X)))
                listTarifa.Items.Add((Tarifas(X)))
            Else
                Exit For
            End If
        Next X

    End Sub

    Private Sub btnBodega_Click(sender As Object, e As EventArgs) Handles btnBodega.Click
        Dim J As Byte

        For J = 0 To 4
            Descuentos(J) = Nothing
            Moras(J) = Nothing
            PagosInicial(J) = Nothing
            PagosTotales(J) = Nothing
            SaldosAnteriores(J) = Nothing
            Servicios(J) = Nothing
            Tarifas(J) = Nothing
        Next J
        listDescuento.Items.Clear()
        listMora.Items.Clear()
        listPagoInicial.Items.Clear()
        listPagoTotal.Items.Clear()
        listSaldoAnterior.Items.Clear()
        listServicios.Items.Clear()
        listTarifa.Items.Clear()
    End Sub
End Class
