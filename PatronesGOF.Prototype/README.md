# Patr�n Prototype

## Proposito
- Especifica los tipos de objetos a crear por medio de una instancia protot�pica, y crea nuevos objetos copiando o clonando dicho prototipo.

## Aplicabilidad
- Cuando el sistema deba ser independiente de c�mo se crean, componen y representan sus productos.
- Cuando las clases a instanciar sean especificadas en tiempo de ejecuci�n
- Para evitar construir una jerarqu�a de clases f�brica paralela a la jerarqu�a de clases de los productos.
- Cuando las instancias de una clase puedan tener uno de entre s�lo unos pocos estados diferentes.

### Conceptos para entender este patr�n
- Clonacion
	- Superficial: un cambio sobre el objeto asociado afecta al objeto original, porque los objetos relacionados son los mismos.
	- Profunda: se clona el objeto principal y sus relacionados.

## Consecuencias
- A�adir y eliminar productos en tiempo de ejecuci�n.
- Especificar nuevos objetos modificando valores.
- Especificar nuevos objetos variando la estructura.
- Reduce la herencia.
- Configurar din�micamente una aplicaci�n con clases.

## Ejemplo
- Juan se va a comprar un auto. Tiene muchas dudas, as� que va a analizar las siguientes opciones:
	- Fiat
		- Uno SRC Blanco
		- Palio Fire Negro
	- DS
		- DS 3 Chic Blanco
		- DS 4 Sport Negro
	- Alfa Romeo
		- 145 Blanco
		- 146 Negro
