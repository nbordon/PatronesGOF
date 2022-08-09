# Patrón Visitor

## Propósito
- Representa una operacion sobre los elementos de una estructura de objetos. Permite definir una nueva operación sin cambiar las clases de los elementos sobre los que opera.
- Es una forma de separar el algoritmo de la estructura de un objeto.

## Aplicabilidad
- Una estructura de objetos contiene muchas clases de objetos con diferentes interfaces, y queremos realizar operaciones sobre esos elementos que dependen de si clase concreta.
- Se necesita realizar muchas operaciones distintas y no relacionadas sobre objetos de una estructura y no se desea contaminar las clases con estas operaciones.
- Las clases que definen la estructura de objetos rara vez cambian, pero muchas veces queremos definir nuevas operaciones sobre la estructura.

## Consecuencias
- El visitante facilita añadir nuevas operaciones.
- Un visitante agrupa operaciones relacionadas y separa las que no lo están.
- Es difícil añadir nuevas clases a un Elemento Concreto.
- Visitar varias jerarquías de clases.
- Acumular estado.
- Romer la encapsulación.

## Ejemplo
- Tenemos diferentes componentes de una computadora, los cuales pueden ser una Placa Base, un Procesador o un Disco Rigido. Cada componente tendrá un número de serie diferente. Los componentes van a recibir un visitante quien imprimirá por pantalla el numero de serie.