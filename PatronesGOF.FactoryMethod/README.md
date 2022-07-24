# Patr�n Factory Method

## Prop�sito
- Define una interfaz para crear un objeto, pero deja que sean las subclases quienes decidan qu� clase instancia.
- Permite a una clase delegar en sus subclases la creaci�n de objetos.

## Aplicabilidad
- Una clase no puede prever la clase de objetos que debe crear.
- Define una interfaz para crear objetos, pero deja que sean las subclases quienes decidan qu� clases instanciar; permite que una clase delegue en sus subclases la creaci�n.
- Las clases delegan las responsabilidades en una de entre varias clases auxiliares, y queremos localizar qu� subclase auxiliar concreta es la que delega.

## Consecuencias
- Proporciona enganches para las subclases (flexibilidad).
- Conecta jerarqu�as de clases paralelas.

## Ejemplo
En el ejemplo aplicamos el patr�n Factory Method, donde tenemos 2 tipos de pizas y 2 pizzerias. Las pizzerias fabrican las pizzas a nivel global.