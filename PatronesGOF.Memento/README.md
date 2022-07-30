# Patr�n Memento

## Prop�sito
- Representa y externaliza el estado interno de un objeto sin violar el encapsulamiento, de forma que �ste pueda a dicho estado mas tarde.
- Tambien conocido como Token.

## Aplicabilidad
- Hay que guardar una instant�nea del estado de un objeto (o parte de �ste) para que pueda volver posteriormente a este estado.
- Una interfaz directa para obtener que el estado exponga detalles de implementaci�n y rompa la encapsulaci�n del objeto.

## Consecuencias
- Preservaci�n de los l�mites del encapsulamiento.
- Simplifica al Creador, el creador no mantiene los estados.
- El uso de mementos puede ser costoso.
- Definici�n de interfaces reducidas y amplias.
Costes ocultos en el cuidado de los mementos �Qui�n y cu�ndo elimina los mementos? �Qu� estado tiene?

## Ejemplo
Patron check list
- Identificar los roles "Caretaker" y "Originator".
- Crear una clase Memento y declarar la relaci�n con el Originator.
- El "Caretaker" sabe cuando registrar un punto de control del "Originator".
- El "Caretaker" sabe cundo hacer retroceder el "Originator".
- El "Originator" restituye su estado en base al estado guardado en el "Memento".
Crearemos un Memento para mantener el estado de una Persona.