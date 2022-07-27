# Patr�n Decorator

## Prop�sito
- Asigna responsabilidades adicionales a un objeto din�micamente, proporcionando una alternativa flexible a la herencia para extender funcionalidad.
- Tambi�n conocido como Wrapper

## Aplicabilidad
- Para a�adir objetos individuales de forma din�mica y transparente, es decir, sin afectar a otros objetos.
- Par responsabilidades que pueden ser retiradas.
- Cuando la extensi�n mediante la herencia no es viable.

## Consecuencias
- M�s felxibilidad que la herencia est�tica, las responsabilidades se a�aden din�micamente.
- Evita clases cargadas de funciones en la parte de arriba de la jerarqu�a.
- Un decorador y su componente no son id�nticos, evita apoyarse en la identidad de objetos.
- Muchos objetos peque�os.

## Ejemplo
- Nos piden desarrollar un sistema para calcular el costo de una bebida, en base a distintos par�metros:
	- Puede ser caf� solo ($10), caf� expreso ($12), caf� descafeinado ($15) y t� tradicional ($8).
	- Pueden a�adirse diferentes condimentos como: leche ($2), crema ($4), edulcorante ($1) y az�car ($0.50).
	- Cada bebida o condimento tiene un costo espec�fico, y la combinaci�n da el costo total.
- Pedimos un caf�.
- Le agregamos crema.
- Le agregamos azucar.
- Calcular el costo.