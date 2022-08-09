# Patr�n Visitor

## Prop�sito
- Representa una operacion sobre los elementos de una estructura de objetos. Permite definir una nueva operaci�n sin cambiar las clases de los elementos sobre los que opera.
- Es una forma de separar el algoritmo de la estructura de un objeto.

## Aplicabilidad
- Una estructura de objetos contiene muchas clases de objetos con diferentes interfaces, y queremos realizar operaciones sobre esos elementos que dependen de si clase concreta.
- Se necesita realizar muchas operaciones distintas y no relacionadas sobre objetos de una estructura y no se desea contaminar las clases con estas operaciones.
- Las clases que definen la estructura de objetos rara vez cambian, pero muchas veces queremos definir nuevas operaciones sobre la estructura.

## Consecuencias
- El visitante facilita a�adir nuevas operaciones.
- Un visitante agrupa operaciones relacionadas y separa las que no lo est�n.
- Es dif�cil a�adir nuevas clases a un Elemento Concreto.
- Visitar varias jerarqu�as de clases.
- Acumular estado.
- Romer la encapsulaci�n.

## Ejemplo
- Tenemos diferentes componentes de una computadora, los cuales pueden ser una Placa Base, un Procesador o un Disco Rigido. Cada componente tendr� un n�mero de serie diferente. Los componentes van a recibir un visitante quien imprimir� por pantalla el numero de serie.