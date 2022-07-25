# Patr�n Abstract Factory

## Prop�sito
- Proporciona una interfaz para crear familias de objetos relacionados o que dependen entre si, sin especificar sus clases concretas.
- Debemos crear diferentes objetos, todos pertenecientes a la misma familia.
- Tambien conocido como: Kit

## Aplicabilidad
- Un sistema debe ser independiente de c�mo se crean, componen y representan sus productos.
- Un sistema de ser configurado como una familia de entre varias.
- Una familia de objetos producto relacionados esta dise�ada para ser usada conjuntamente (es una restricci�n).
- proporcionar una biblioteca de productos, revelando solo sus interfaces y no sus implementaciones.

## Consecuencias
1. A�sla las clases concretas.
2. Facilita el intercambio de familias de productos.
3. Promueve la consistencia entre productos.
4. Es dif�cil agregar nuevos tipos de productos.

## Ejemplo

### La pizzer�a Italo/Argentina
En el siguiente ejemplo se implementa el patr�n Abstract Factory
1. Esta pizzer�a solo vende pizzas y empanadas nativas. Poca variedad por el momento, pero esperan con el tiempo crecer en cantidad de productos.
2. Pizzas: de cancha en Argentina, napolitana en Italia.
3. Empanadas: de carne en Argentina, de capresse en Italia.