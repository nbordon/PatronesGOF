# Patron Singleton

## Proposito
- Garantiza que una clase s�lo tenga una instancia y proporciona un punto de acceso global a ella.

## Aplicabilidad
- Debe haber exactamente una instancia de una clase, y �sta deber ser accesible a los clientes desde un punto de acceso conocido.
- La �nica instancia deber�a ser extensible mediante herencia, y los clientes deber�an ser capaces de usar una instancia extendida sin modificar su c�digo.

## Consecuencias
1. Acceso controlado a la �nica instancia.
2. Espacio de nombres reducido (mejor que las variables globales).
3. Permite el refinamiento de las operaciones y la representaci�n.
4. Permite un n�mero variable de instancias (ej. Pooling).
5. Mas flexible que operaciones de clase.

## Ejemplo
En el ejemplo vemos la aplicaci�n de patr�n Singleton mediante un acceso controlado a una �nica instancia de una sesi�n de usuario.