# Patrón Memento

## Propósito
- Representa y externaliza el estado interno de un objeto sin violar el encapsulamiento, de forma que éste pueda a dicho estado mas tarde.
- Tambien conocido como Token.

## Aplicabilidad
- Hay que guardar una instantánea del estado de un objeto (o parte de éste) para que pueda volver posteriormente a este estado.
- Una interfaz directa para obtener que el estado exponga detalles de implementación y rompa la encapsulación del objeto.

## Consecuencias
- Preservación de los límites del encapsulamiento.
- Simplifica al Creador, el creador no mantiene los estados.
- El uso de mementos puede ser costoso.
- Definición de interfaces reducidas y amplias.
Costes ocultos en el cuidado de los mementos ¿Quién y cuándo elimina los mementos? ¿Qué estado tiene?

## Ejemplo
Patron check list
- Identificar los roles "Caretaker" y "Originator".
- Crear una clase Memento y declarar la relación con el Originator.
- El "Caretaker" sabe cuando registrar un punto de control del "Originator".
- El "Caretaker" sabe cundo hacer retroceder el "Originator".
- El "Originator" restituye su estado en base al estado guardado en el "Memento".
Crearemos un Memento para mantener el estado de una Persona.