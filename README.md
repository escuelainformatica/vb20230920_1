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