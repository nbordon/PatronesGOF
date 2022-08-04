# Patron Builder

## Propósito
- Separa la construcción de un objeto complejo de su representación, de forma que el mismo proceso de construcción pueda crear diferentes representaciones.

## Aplicabilidad
- El algoritmo para crear un objeto complejo debería ser independiente de las partes de que se compone dicho objeto y de cómo se ensamblan.
- El proceso de construcción debe permitir diferentes representaciones del objeto que está siendo construido.

## Consecuencias
1. Permite variar la representación interna de un producto.
2. Aísla el código de construcción y representación.
3. Proporciona un control más fino sobre el proceso de construcción.

## Ejemplo
- Una pizzería tiene diferentes líneas de montaje, en cada una se fabrican diferentes pizzas:
	- Puede ser Light, de Mozzarella e Italiana.
- Para crear una pizza necesitamos hacer la masa, la salsa y los agregados.