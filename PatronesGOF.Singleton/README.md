# Patron Singleton

## Proposito
- Garantiza que una clase sólo tenga una instancia y proporciona un punto de acceso global a ella.

## Aplicabilidad
- Debe haber exactamente una instancia de una clase, y ésta deber ser accesible a los clientes desde un punto de acceso conocido.
- La única instancia debería ser extensible mediante herencia, y los clientes deberían ser capaces de usar una instancia extendida sin modificar su código.

## Consecuencias
1. Acceso controlado a la única instancia.
2. Espacio de nombres reducido (mejor que las variables globales).
3. Permite el refinamiento de las operaciones y la representación.
4. Permite un número variable de instancias (ej. Pooling).
5. Mas flexible que operaciones de clase.

## Ejemplo
En el ejemplo vemos la aplicación de patrón Singleton mediante un acceso controlado a una única instancia de una sesión de usuario.