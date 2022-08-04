# Patron Composite

## Propósito
- Compone objetos en estructuras de árbol para representar jerarquías de parte-todo.
- Permite que los clientes traten de manera uniforme a los objetos individuales y a los compuestos.

## Aplicabilidad
- Quiera representar jerarquías de objetos todo-parte.
- Quiere que los clientes sean capaces de obviar las diferencias entre composiciones de objetos y los objetos individuales. Los clientes tratarán a todos los objetos de la estructura compuesta de manera uniforme.

## Consecuencias
- Define jerarquías de clases formadas por objetos primitivos y compuestos.
- Simplifica al cliente. El cliente trata las estructuras uniformemente.
- Facilita añadir nuevos tipos de componentes.
- Puede hacer un que un diseño sea demasiado general.

## Ejemplo
- Vamos a simular un sistema de archivos. Tendremos dos componentes, por un lado los archivos y por otro los directorios, que pueden contener otros directorios o archivos. Se necesita obtener el tamaño tanto de los archivos como de los directorios.