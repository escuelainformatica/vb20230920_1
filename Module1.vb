Module Module1

    Sub Main()
        ' variables
        ' listados de datos
        ' clases.
        ' ciclos
        ' linq.
        Dim resultado As Boolean
        resultado = True ' o False
        resultado = 1 < 2  ' True porque 1 es menor que 2
        resultado = 1 <= 2  ' True porque 1 es menor o igual que 2
        resultado = 1 = 2  ' false porque 1 es igual a 2 es falso
        resultado = 1 <> 2 ' True porque 1 no es igual a 2 es verdadero
        Dim n1 As Integer = 20
        Dim n2 As Integer = 20
        Dim n3 As Integer = 30
        Debug.WriteLine(n1 < n2) ' true porque 10 es menor que 20
        Debug.WriteLine(n1 < n2 And n1 < n3) ' si n1 es menor que n2 (y ademas) n1 es menor que n3
        Debug.WriteLine(n1 < n2 Or n1 < n3) ' es verdadero si solo una o mas condiciones se cumple

        If n1 < n2 Then
            Debug.WriteLine("n1 es menor que n2")
        ElseIf n1 = n2 Then
            Debug.WriteLine("n2 es igual a n1")
        Else
            Debug.WriteLine("n2 es menor que n1")
        End If

        If n1 < n2 Then
            Debug.WriteLine("n1 es menor que n2")
        End If
        If n1 = n2 Then
            Debug.WriteLine("son iguales")
        End If
        If n2 < n1 Then
            Debug.WriteLine("n2 es menor que n1")
        End If


        ' quisiera que me indique el valor menor.
        If n1 < n2 And n1 < n3 Then
            Debug.WriteLine("n1 es el menor de todos")
        End If
        If n2 < n1 And n2 < n3 Then
            Debug.WriteLine("n2 es el menor de todos")
        End If
        If n3 < n1 And n3 < n2 Then
            Debug.WriteLine("n3 es el menor de todos")
        End If

        Dim numero As Integer = 3
        Select Case numero
            Case 1
                Debug.WriteLine("uno")
            Case 2
                Debug.WriteLine("dos")
            Case 3
                Debug.WriteLine("tres")
            Case Else
                Debug.WriteLine("otro valor")
        End Select

        Dim listadoEncomiendas = New List(Of Encomienda)
        listadoEncomiendas.Add(New Encomienda("arica", "santiago", 444, "john"))
        listadoEncomiendas.Add(New Encomienda("iquique", "santiago", 664, "peter"))
        listadoEncomiendas.Add(New Encomienda("antofagasta", "valdivia", 333, "susan"))
        ' quisiera ver todas las encomiendas que tienen destino santiago.
        For Each enc In listadoEncomiendas
            If enc.Destino = "santiago" Then
                Debug.WriteLine(enc.Origen + " => " + enc.Destino)
            End If
        Next

        Dim filtradoSantiago = (From enc In listadoEncomiendas
                                Where enc.Destino = "santiago").ToList
        filtradoSantiago.ForEach(Sub(enc)
                                     Debug.WriteLine(enc.Origen + " => " + enc.Destino)
                                 End Sub
                                 )
        ' quisiera mostrar todas las encomiendas cuyo peso es mayor a 400
        filtradoSantiago = (From enc In listadoEncomiendas
                            Where enc.Peso > 400).ToList
        filtradoSantiago.ForEach(Sub(enc)
                                     Debug.WriteLine(enc.Origen + " => " + enc.Destino + " peso: " + enc.Peso.ToString)
                                 End Sub
                                 )

        Dim listadoHelados = New List(Of Helado)
        listadoHelados.Add(New Helado("Chocolate", 100, 75))
        listadoHelados.Add(New Helado("Vainilla", 200, 50))
        listadoHelados.Add(New Helado("Strawberry", 300, 0))
        listadoHelados.Add(New Helado("Lucuma", 210, 70))
        listadoHelados.Add(New Helado("Piña", 15, 75))
        listadoHelados.Add(New Helado("Chocolate Menta", 260, 300))
        Dim filtradoHelado = New List(Of Helado)
        Debug.WriteLine("------------helados-------------------------")
        ' numero de ordenes son mayor a 50
        ' Usando LINQ: (consulta)
        filtradoHelado = (From helado In listadoHelados
                          Where helado.NumOrdenes > 50).ToList

        ' Usando LINQ: (procedural)
        filtradoHelado = listadoHelados.Where(Function(helado) helado.NumOrdenes > 50).ToList

        ' Usando ciclo for each:
        filtradoHelado = New List(Of Helado) ' limpiar en listado
        For Each Helado In listadoHelados
            If Helado.NumOrdenes > 50 Then
                filtradoHelado.Add(Helado)
            End If
        Next

        Debug.WriteLine("numero de ordenes son mayor a 50:")
        mostrarHelados(filtradoHelado)
        ' cantidad sea mayor a 200 y las ordenes mayor a 50
        ' LINQ: (consulta)
        filtradoHelado = (From helado In listadoHelados
                          Where helado.NumOrdenes > 50 And helado.Cantidas > 200).ToList

        ' LINQ: (procedural)
        filtradoHelado = listadoHelados.
            Where(Function(helado) helado.NumOrdenes > 50 And helado.Cantidas > 200).
            ToList
        ' for each:
        filtradoHelado = New List(Of Helado)
        For Each helado In listadoHelados
            If helado.NumOrdenes > 50 And helado.Cantidas > 200 Then
                filtradoHelado.Add(helado)
            End If
        Next

        Debug.WriteLine("cantidad sea mayor a 200 y las ordenes mayor a 50:")
        mostrarHelados(filtradoHelado)
        ' los helados que son de vainilla
        filtradoHelado = (From helado In listadoHelados
                          Where helado.Sabor = "Vainilla").ToList
        Debug.WriteLine("los helados que son de vainilla:")
        mostrarHelados(filtradoHelado)
        ' los helados que sean de chocolate (incluyendo menta)
        Debug.WriteLine("los helados que sean de chocolate (incluyendo menta):")
        filtradoHelado = (From helado In listadoHelados
                          Where helado.Sabor.Contains("Chocolate")).ToList
        mostrarHelados(filtradoHelado)

        Debug.WriteLine("los helados ordenados por nombre:")
        filtradoHelado = (From helado In listadoHelados
                          Order By helado.Sabor
                            ).ToList
        mostrarHelados(filtradoHelado)
        Debug.WriteLine("aplicar todo:")
        ' como linq: (consulta)
        filtradoHelado = (From helado In listadoHelados
                          Where helado.Sabor.Contains("Chocolate")
                          Where helado.NumOrdenes > 50 And helado.Cantidas > 200
                          Order By helado.Sabor).ToList
        ' como linq: (procedural):
        filtradoHelado = listadoHelados.
            Where(Function(helado) helado.Sabor.Contains("Chocolate")).
            Where(Function(helado) helado.NumOrdenes > 50 And helado.Cantidas > 200).
            OrderBy(Function(helado) helado.Sabor).ToList
        ' como linq: (consulta) y un solo where
        filtradoHelado = (From helado In listadoHelados
                          Where helado.Sabor.Contains("Chocolate") And helado.NumOrdenes > 50 And helado.Cantidas > 200
                          Order By helado.Sabor).ToList
        mostrarHelados(filtradoHelado)


    End Sub
    Public Sub mostrarHelados(listado As List(Of Helado))
        For Each helado In listado
            Debug.WriteLine($"{helado.Sabor} cantidad:{helado.Cantidas} numordenes:{helado.NumOrdenes} ")
        Next

    End Sub

End Module
