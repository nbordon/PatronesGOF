# Patron Composite

## Prop�sito
- Compone objetos en estructuras de �rbol para representar jerarqu�as de parte-todo.
- Permite que los clientes traten de manera uniforme a los objetos individuales y a los compuestos.

## Aplicabilidad
- Quiera representar jerarqu�as de objetos todo-parte.
- Quiere que los clientes sean capaces de obviar las diferencias entre composiciones de objetos y los objetos individuales. Los clientes tratar�n a todos los objetos de la estructura compuesta de manera uniforme.

## Consecuencias
- Define jerarqu�as de clases formadas por objetos primitivos y compuestos.
- Simplifica al cliente. El cliente trata las estructuras uniformemente.
- Facilita a�adir nuevos tipos de componentes.
- Puede hacer un que un dise�o sea demasiado general.

## Ejemplo
- Vamos a simular un sistema de archivos. Tendremos dos componentes, por un lado los archivos y por otro los directorios, que pueden contener otros directorios o archivos. Se necesita obtener el tama�o tanto de los archivos como de los directorios.