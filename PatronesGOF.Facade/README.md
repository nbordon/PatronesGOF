# Patrón Facade

## Proposito
- Define una interfaz de alto nivel que para que un subsistema sea mas facil de entender.

## Aplicabilidad
- Queremos proporcionar una interfaz simple para un subsitema complejo
- Existen muchas dependencias entre los clientes y las clases que implementan una abstracción.
- Queremos dividir en capas nuestros subsistemas.

## Consecuencias
- Oculta a los clientes los componentes del subsitema.
- Promueve un débil acoplamiento entre el subsitema y sus clientes.
- No impide que las aplicaciones usen las clases del subsistema en caso de que sea necesario.

## Ejemplo
Queremos realizar la reserva de un vuelo o un hotel, donde tenemos 2 servicios que nos devuelven la disponibilidad, una para los vuelos y otra para los hoteles. Nuestra fachada se encuentra en una clase que referencia a ambos servicios y realiza la busqueda.