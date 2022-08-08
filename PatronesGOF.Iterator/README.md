# Patr�n Iterator

## Prop�sito
- Proporciona un modo de acceder secuencialmente a los elementos de un objeto agregado sin exponer su representaci�n interna.
- Tambien conocido como Cursor

## Aplicabilidad
- Para acceder al contenido de un objeto agregado sin exponer sus representaci�n interna.
- Para permitir varios recorridos sobre objetos agregados.
- Para proporcionar una interfaz uniforme para recorrer diferentes estructuras agregadas.

## Consecuencias
- Permite variaciones en el recorrido de un agregado.
- Los iteradores simplifican la interfaz de Agregado (Aggregate), no es necesaria la misma interfaz.
- Se puede hacer m�s de un recorrido a la vez sobre un agregado (Aggregate).

## Ejemplo
- Crearemos una abstracci�n para recorrer una lista secuencialmente.

Tambien podemos aprovechar la implementacion de .net a trav�s de las interfaces IEnumerable e IEnumerator.