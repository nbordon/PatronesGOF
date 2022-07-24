# Patrón Factory Method

## Propósito
- Define una interfaz para crear un objeto, pero deja que sean las subclases quienes decidan qué clase instancia.
- Permite a una clase delegar en sus subclases la creación de objetos.

## Aplicabilidad
- Una clase no puede prever la clase de objetos que debe crear.
- Define una interfaz para crear objetos, pero deja que sean las subclases quienes decidan qué clases instanciar; permite que una clase delegue en sus subclases la creación.
- Las clases delegan las responsabilidades en una de entre varias clases auxiliares, y queremos localizar qué subclase auxiliar concreta es la que delega.

## Consecuencias
- Proporciona enganches para las subclases (flexibilidad).
- Conecta jerarquías de clases paralelas.

## Ejemplo
En el ejemplo aplicamos el patrón Factory Method, donde tenemos 2 tipos de pizas y 2 pizzerias. Las pizzerias fabrican las pizzas a nivel global.