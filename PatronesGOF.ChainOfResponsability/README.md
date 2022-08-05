# Patron Chain of Responsability

## Propósito
- Evitar acoplar el emisor de una petición a su receptor, dando la posibilidad de responder a la petición a mas de un objeto. Encadena los objetos y pasa la petición a través de la cadena hasta que es procesada por algún objeto.

## Aplicabilidad
- Hay más de un objeto que puede manejar un petición, y el manejador no se conoce a priori, sino que debería determinarse automáticamente.
- Se quiere enviar una petición a un objeto entre varios sin especificar explícitamente al receptor.
- El conjunto de objetos que pueden tratar una petición debería ser especificado dinámicamente.

## Consecuencias
- Reduce el acomplamiento, un objeto sólo tiene que saber que una petición será manejada "de forma apropiada".
- Añade flexibilidad para asignar responsabilidades a objetos.
- No se garantiza la recepción, dado que las, peticiones no tiene un receptor explícito, no hay garantía de que sean manejadas.

## Ejemplo
- Tenemos una compra que va a ser aprobada según su valor, si es menor a 100 la aprueba directamente el comprador. Si es menor a 1000 será aprobada por el gerente zonal. Si es mayor a 1000 la procesará el director de compras.