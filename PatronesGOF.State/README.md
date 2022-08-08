# Patr�n State

## Prop�sito
- Permite que un objeto modifique su comportamiento cada vez que cambie su estado interno. Parecer� qie cambia la clase de objeto.
- Tambi�n conocido como Objects for States (Estados por Objetos).

## Aplicabilidad
- El comportamiento de un objeto depende de su estado, y debe cambiar en tiempo de ejecuci�n dependiendo de ese estado.
- Las operaciones tienen largas sentencias condicionales con m�ltiples ramas que dependen del estado del objeto. Este estado se suele representar por una o mas constantes enumeradas (enumeraciones).

## Consecuencias
- Localiza el comportamiento dependiente del estado y divide dicho comportamiento en diferentes estados.
- Hace expl�citas las transiciones entre estados.
- Los objetos Estado pueden compartirse, si es que no poseen estado o variables.

## Ejemplo
- Tenemos un switch que permite cambiar su estado de prendido a apagado al presionar.