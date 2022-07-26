# Patrón Prototype

## Proposito
- Especifica los tipos de objetos a crear por medio de una instancia prototípica, y crea nuevos objetos copiando o clonando dicho prototipo.

## Aplicabilidad
- Cuando el sistema deba ser independiente de cómo se crean, componen y representan sus productos.
- Cuando las clases a instanciar sean especificadas en tiempo de ejecución
- Para evitar construir una jerarquía de clases fábrica paralela a la jerarquía de clases de los productos.
- Cuando las instancias de una clase puedan tener uno de entre sólo unos pocos estados diferentes.

### Conceptos para entender este patrón
- Clonacion
	- Superficial: un cambio sobre el objeto asociado afecta al objeto original, porque los objetos relacionados son los mismos.
	- Profunda: se clona el objeto principal y sus relacionados.

## Consecuencias
- Añadir y eliminar productos en tiempo de ejecución.
- Especificar nuevos objetos modificando valores.
- Especificar nuevos objetos variando la estructura.
- Reduce la herencia.
- Configurar dinámicamente una aplicación con clases.

## Ejemplo
- Juan se va a comprar un auto. Tiene muchas dudas, así que va a analizar las siguientes opciones:
	- Fiat
		- Uno SRC Blanco
		- Palio Fire Negro
	- DS
		- DS 3 Chic Blanco
		- DS 4 Sport Negro
	- Alfa Romeo
		- 145 Blanco
		- 146 Negro
