# Patron Builder

## Prop�sito
- Separa la construcci�n de un objeto complejo de su representaci�n, de forma que el mismo proceso de construcci�n pueda crear diferentes representaciones.

## Aplicabilidad
- El algoritmo para crear un objeto complejo deber�a ser independiente de las partes de que se compone dicho objeto y de c�mo se ensamblan.
- El proceso de construcci�n debe permitir diferentes representaciones del objeto que est� siendo construido.

## Consecuencias
1. Permite variar la representaci�n interna de un producto.
2. A�sla el c�digo de construcci�n y representaci�n.
3. Proporciona un control m�s fino sobre el proceso de construcci�n.

## Ejemplo
- Una pizzer�a tiene diferentes l�neas de montaje, en cada una se fabrican diferentes pizzas:
	- Puede ser Light, de Mozzarella e Italiana.
- Para crear una pizza necesitamos hacer la masa, la salsa y los agregados.