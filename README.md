# Comparaciones

* Ejemplo1: condicion basica
```vbnet
	if n1<n2 then
		' aqui se ejecuta cuando la expresion n1<n2 es verdadera
	end if
```
* Ejemplo2: condicion usando "else"
```vbnet
	if n1<n2 then
		' aqui se ejecuta cuando la expresion n1<n2 es verdadera
	else
	    ' se ejecuta esto si no se cumple la expresion (n1 no es menor que n2)
	end if
```
* Ejemplo3: condicion usando "elseif" y "else"
```vbnet
	if n1<n2 then
		' aqui se ejecuta cuando la expresion n1<n2 es verdadera
	elseif n1<n3 then
		' se ejecuta si n1 no es menor que n2 y n1 es menor que n3
	else
	    ' se ejecuta esto si no se cumple la expresion (n1 no es menor que n2)
	end if
```
* Ejemplo4: Select si se quiere comparar varios valores
```vbnet
  select n1
      case 1
	     ' se ejecuta si n1=1
      case 2
	     ' se ejecuta si n1=2
      case default
	     ' se ejecuta si no se cumple ninguna condicion anterior
  end select
```
* Ejemplo 5 ocupando linq

```vbnet
' consulta:
resultado=(From alias in listado
           Where condicion<1).ToList
' procedural:
resultado=listado.Where(function(alias) condicion<1).ToList
```

# Ejercicio 20 Septiembre 2023

## Ejercicio #1
Cree un nuevo proyecto de consola, y en la subrutina main() de Module1.vb haga el ejercicio:  
* Cree dos variables con los siguientes valores
    * stock = 200
    * venta = 300
* Y compare las variables (usando if) usando las siguientes condiciones
    * si venta es mayor al stock, mostrar un mensaje que diga: "sobre venta"
    * si venta es igual a stock, mostrar un mensaje que diga: "stock vendido completamente"
	* si venta es menor a stock, mostrar un mensaje que diga: "stock falta por vende"

## Ejercicio #2
* Cree otra variable llamada numMes con el valor 5
* Y comparela (usando select) para que muestre el nombre del mes (agregue 12 condiciones, una para cada mes)

## Ejercicio #3
* En el mismo proyecto, cree una clase llamada Cliente con las siguientes propiedades
   * Nombre (string)
   * Deuda (integer)
   * Pagado (integer)
* Y agregue ambos constructores
* Luego, en la subrutina main, cree un listado de clientes usando los siguientes datos:

| Nombre  | Deuda | Pagado |
| ------- | ----- | ------ |
| John    | 5000  | 5000   |
| Anna    | 0     | 0      |
| Susan   | 3500  | 1500   |
| Bob     | 0     | 0      |
| Peter   | 600   | 200    |
| James   | 700   | 700    |
| William | 200   | 0      |

* En Module1.vb cree una subrutina para mostrar los clientes (igual que el ejemplo creado aqui)
Ejemplo:
```vbnet
    Public Sub mostrarHelados(listado As List(Of Helado))
        For Each helado In listado
            Debug.WriteLine($"{helado.Sabor} cantidad:{helado.Cantidas} numordenes:{helado.NumOrdenes} ")
        Next

    End Sub
```
* Cree una nueva variable que tenga en listado de clientes filtrado por lo clientes con deuda
* Use LINQ
   * Los clientes que tienen deuda son los cliente donde la deuda>pago
* Y muestre la variable usando la subrutina para mostrar los clientes
* Cree otra variable que tambien tenga un listado de clientes filtrados por los clientes sin deuda
* Use LINQ
   * Los clientes sin deuda son los cliente donde la deuda=pago
* Y muestre la variable usando la subrutina para mostrar los clientes	 
