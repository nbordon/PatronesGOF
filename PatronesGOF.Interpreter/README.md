# Patron Interpreter

## Propósito
- Dado un lenguaje, define una representación de su gramática junto con un intérprete que usa dicha representación para interceptar sentencias del lenguaje.
- En el mundo real, los lenguajes estan formados por expresiones no terminales que contienen construcciones terminales dentro.

## Aplicabilidad
- Cuando hay un lenguaje que interpretar y se pueden representar las sentencias del lenguaje como árboles sintácticos abstractos (Instancia del Composite).
- Funciona cuando:
	- La gramática es simple.
	- La eficiencia no es una preocupación crítica.

## Consecuencias
- + Es fácil de cambiar y ampliar la gramática.
- + También resulta fácil de implementar la gramática
- - Las gramáticas complejas son difíciles de mantener.
- - No es muy eficiente.
- - No cubre gramáticas complejas.

## Ejemplo
- Supongamos que nuestro sistema tiene que sumar y/o restar números del 0 al 9 en un formato textual del tipo "uno mas cinco menos cuatro" y nuestro sistema debe dar un resultado entero, en este caso 2.