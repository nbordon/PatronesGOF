# Patron Chain of Responsability

## Prop�sito
- Evitar acoplar el emisor de una petici�n a su receptor, dando la posibilidad de responder a la petici�n a mas de un objeto. Encadena los objetos y pasa la petici�n a trav�s de la cadena hasta que es procesada por alg�n objeto.

## Aplicabilidad
- Hay m�s de un objeto que puede manejar un petici�n, y el manejador no se conoce a priori, sino que deber�a determinarse autom�ticamente.
- Se quiere enviar una petici�n a un objeto entre varios sin especificar expl�citamente al receptor.
- El conjunto de objetos que pueden tratar una petici�n deber�a ser especificado din�micamente.

## Consecuencias
- Reduce el acomplamiento, un objeto s�lo tiene que saber que una petici�n ser� manejada "de forma apropiada".
- A�ade flexibilidad para asignar responsabilidades a objetos.
- No se garantiza la recepci�n, dado que las, peticiones no tiene un receptor expl�cito, no hay garant�a de que sean manejadas.

## Ejemplo
- Tenemos una compra que va a ser aprobada seg�n su valor, si es menor a 100 la aprueba directamente el comprador. Si es menor a 1000 ser� aprobada por el gerente zonal. Si es mayor a 1000 la procesar� el director de compras.