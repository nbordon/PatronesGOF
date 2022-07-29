# Patrón Command

## Propósito
- encapsula una petición en un objeto, permitiendo así parametrizar a los clientes con diferentes peticiones, hacer cola o llevar un registro de las peticiones, y poder deshacer las operaciones.
- También conocido como Action (Acción), Transaction (Transacción).

## Aplicabilidad
- Parametrizar objetos con una acción a realizar. Los objetos command son un sustituto orientado a objetos para las funciones callback.
- Poner en cola y ejecutar peticiones en diferentes instantes de tiempo.
- Permitir deshacer. Cada objeto Command sabe como deshacer su propia ejecución.
- Permitir registrar los cambios de manera que se puedan volver a aplicar en caso de una caída de sistema.
- Estructurar un sistema alrededor de operaciones de alto nivel construidas sobre operaciones básicas.

## Consecuencias
- Desacobla el objeto que invoca la operacion de aquél que sabe cómo realizarla.
- Los Command son objetos de primera clase. Pueden ser manipulados y extendidos como cualquier otro objeto.
- Se pueden ensamblar órdenes en una orden compuesta.
- Es fácil añadir nuevas órdenes, ya que no hay  que cambiar las clases exitentes.

## Ejemplo
Tenemos un producto que puede sumar y restar stock por medio de distintas ordenes. Las ordenes son comandos para alta y baja de stock. Por ultimo contamos con una empresa que toma las ordenes y las procesa.