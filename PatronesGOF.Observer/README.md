# Patr�n Observer

## Prop�sito
- Define una dependencia de uno-a-muchos entre objetos, de forma que cuando un objeto cambie de estado se notifique y se actualicen automanticamente todos los objetos que dependan de �l.
- Tambi�n conocido como Dependents (dependientes), Publish-Suscribe (Publicar-Suscribir).

## Aplicabilidad
- Cuando una abstracci�n tiene dos aspectos y uno depende de otro.
- Cuando un cambio en un objeto requiere cambiar otros, y no sabemos cu�ntos objetos necesitan cambiarse.
- Cuando un objeto deber�a ser capaz de notificar a otros sin hacer suposiciones sobre qui�nes son dichos objetos.

## Consecuencias
- El patr�n Observer permite modificar los sujetos y observadores de forma independiente. Es posible reutilizar objetos sin reutilizar sus observadores, y viseversa. Esto permite a�adir observadores sin modificar al sujeto u otros observadores.
- Acoplamiento abstracto entre Sujeto y Observador.
- Capacidad de comunicaci�n mediante difusion.
- Actualizaciones inesperadas.

## Ejemplo
- Tendremos una lista de productos y una lista de usuarios. Queremos poder suscribir usuarios a un producto para que, ante un cambio de precio del producto, los usuarios sean notificados y reciba una actualizaci�n con el precio nuevo.