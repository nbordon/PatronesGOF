# Patrón Template Method

## Propósito
- Define en una operación el esqueleto de un algoritmo, delegando en las subclases algunos de sus pasos. Permite que las subclases redefinan ciertos pasos de un algoritmo sin cambiar la estructura.

## Aplicabilidad
- Para implementar las partes de un algoritmo que no cambia y dejar que sean las subclases quienes implementen el comportamiento que puede variar.
- Cuando el comportamiento repetido de varias subclases debería refactorizarse y ser localizado en una clase común para evitar código duplicado.
- Para controlar las extensiones de las subclases.

## Consecuencias
- Los métodos plantilla son una técnica fundamental de reutlización de código. Son particularmente importantes en las bibliotecas de clases, ya que son el modo de factorizar y extraer el comportamiento común de las clases de la biblioteca.
- Ventajas: Facilita el reuso de código, por eso es fundamental en muchos Frameworks.

## Ejemplo
- Una operación de p´restamo puede requerir diversos pasos para completarse.
	1. Verificar el balance bancario del cliente.
	2. Comprobar la puntuación crediticia del cliente en 3 empresas.
	3. Verificar otros préstamos del cliente.
	4. Revisar el stock de las acciones del cliente.
	5. Revisar ingresos potenciales del cliente en el futuro.