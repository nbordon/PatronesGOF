# Patr�n Command

## Prop�sito
- encapsula una petici�n en un objeto, permitiendo as� parametrizar a los clientes con diferentes peticiones, hacer cola o llevar un registro de las peticiones, y poder deshacer las operaciones.
- Tambi�n conocido como Action (Acci�n), Transaction (Transacci�n).

## Aplicabilidad
- Parametrizar objetos con una acci�n a realizar. Los objetos command son un sustituto orientado a objetos para las funciones callback.
- Poner en cola y ejecutar peticiones en diferentes instantes de tiempo.
- Permitir deshacer. Cada objeto Command sabe como deshacer su propia ejecuci�n.
- Permitir registrar los cambios de manera que se puedan volver a aplicar en caso de una ca�da de sistema.
- Estructurar un sistema alrededor de operaciones de alto nivel construidas sobre operaciones b�sicas.

## Consecuencias
- Desacobla el objeto que invoca la operacion de aqu�l que sabe c�mo realizarla.
- Los Command son objetos de primera clase. Pueden ser manipulados y extendidos como cualquier otro objeto.
- Se pueden ensamblar �rdenes en una orden compuesta.
- Es f�cil a�adir nuevas �rdenes, ya que no hay  que cambiar las clases exitentes.

## Ejemplo
Tenemos un producto que puede sumar y restar stock por medio de distintas ordenes. Las ordenes son comandos para alta y baja de stock. Por ultimo contamos con una empresa que toma las ordenes y las procesa.