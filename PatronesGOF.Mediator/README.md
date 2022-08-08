# Patrón Mediator

## Propósito
- Define un objeto que encapsula cómo interactúan una serie de objetos. Promueve un bajo acoplamiento al evitar que los objetos se refieran unos a otros explícitamente, y permite variar la interacción entre ellos de forma independiente.

## Aplicabilidad
- Un conjunto de objetos se comunican de forma bien definida, pero compleja. Las interdependencias resultantes no están estructuradas y son difíciles de comprender.
- Es difícil reutilizar un objeto, ya que éste se refiere a otros muchos objetos, con los que se comunica.
- Un comportamiento que está distribuido entre varias clases debería poder ser adaptado sin necesidad de una gran cantidad de subclases.

## Consecuencias
- Reduce la herencia.
- Desacopla a los Colegas (Colleagues).
- Simplifica los protocolos de los objetos.
- Abstrae cómo cooperan lo objetos.
- Centraliza el control.

## Ejemplo
- Vamos a plantear un esquema de colaboración a traves de un canal de chat. Tenemos un canal de chat que permitirá registrar usuarios, que luego podran enviar mensajes. Nuestro chat tomara el rol de Mediator.