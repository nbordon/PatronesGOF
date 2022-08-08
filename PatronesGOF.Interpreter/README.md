# Patron Interpreter

## Prop�sito
- Dado un lenguaje, define una representaci�n de su gram�tica junto con un int�rprete que usa dicha representaci�n para interceptar sentencias del lenguaje.
- En el mundo real, los lenguajes estan formados por expresiones no terminales que contienen construcciones terminales dentro.

## Aplicabilidad
- Cuando hay un lenguaje que interpretar y se pueden representar las sentencias del lenguaje como �rboles sint�cticos abstractos (Instancia del Composite).
- Funciona cuando:
	- La gram�tica es simple.
	- La eficiencia no es una preocupaci�n cr�tica.

## Consecuencias
- + Es f�cil de cambiar y ampliar la gram�tica.
- + Tambi�n resulta f�cil de implementar la gram�tica
- - Las gram�ticas complejas son dif�ciles de mantener.
- - No es muy eficiente.
- - No cubre gram�ticas complejas.

## Ejemplo
- Supongamos que nuestro sistema tiene que sumar y/o restar n�meros del 0 al 9 en un formato textual del tipo "uno mas cinco menos cuatro" y nuestro sistema debe dar un resultado entero, en este caso 2.