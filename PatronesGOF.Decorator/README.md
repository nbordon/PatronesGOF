# Patrón Decorator

## Propósito
- Asigna responsabilidades adicionales a un objeto dinámicamente, proporcionando una alternativa flexible a la herencia para extender funcionalidad.
- También conocido como Wrapper

## Aplicabilidad
- Para añadir objetos individuales de forma dinámica y transparente, es decir, sin afectar a otros objetos.
- Par responsabilidades que pueden ser retiradas.
- Cuando la extensión mediante la herencia no es viable.

## Consecuencias
- Más felxibilidad que la herencia estática, las responsabilidades se añaden dinámicamente.
- Evita clases cargadas de funciones en la parte de arriba de la jerarquía.
- Un decorador y su componente no son idénticos, evita apoyarse en la identidad de objetos.
- Muchos objetos pequeños.

## Ejemplo
- Nos piden desarrollar un sistema para calcular el costo de una bebida, en base a distintos parámetros:
	- Puede ser café solo ($10), café expreso ($12), café descafeinado ($15) y té tradicional ($8).
	- Pueden añadirse diferentes condimentos como: leche ($2), crema ($4), edulcorante ($1) y azúcar ($0.50).
	- Cada bebida o condimento tiene un costo específico, y la combinación da el costo total.
- Pedimos un café.
- Le agregamos crema.
- Le agregamos azucar.
- Calcular el costo.