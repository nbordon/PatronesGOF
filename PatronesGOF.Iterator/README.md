# Patrón Iterator

## Propósito
- Proporciona un modo de acceder secuencialmente a los elementos de un objeto agregado sin exponer su representación interna.
- Tambien conocido como Cursor

## Aplicabilidad
- Para acceder al contenido de un objeto agregado sin exponer sus representación interna.
- Para permitir varios recorridos sobre objetos agregados.
- Para proporcionar una interfaz uniforme para recorrer diferentes estructuras agregadas.

## Consecuencias
- Permite variaciones en el recorrido de un agregado.
- Los iteradores simplifican la interfaz de Agregado (Aggregate), no es necesaria la misma interfaz.
- Se puede hacer más de un recorrido a la vez sobre un agregado (Aggregate).

## Ejemplo
- Crearemos una abstracción para recorrer una lista secuencialmente.

Tambien podemos aprovechar la implementacion de .net a través de las interfaces IEnumerable e IEnumerator.