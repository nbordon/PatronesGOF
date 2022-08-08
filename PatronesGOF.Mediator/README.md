# Patr�n Mediator

## Prop�sito
- Define un objeto que encapsula c�mo interact�an una serie de objetos. Promueve un bajo acoplamiento al evitar que los objetos se refieran unos a otros expl�citamente, y permite variar la interacci�n entre ellos de forma independiente.

## Aplicabilidad
- Un conjunto de objetos se comunican de forma bien definida, pero compleja. Las interdependencias resultantes no est�n estructuradas y son dif�ciles de comprender.
- Es dif�cil reutilizar un objeto, ya que �ste se refiere a otros muchos objetos, con los que se comunica.
- Un comportamiento que est� distribuido entre varias clases deber�a poder ser adaptado sin necesidad de una gran cantidad de subclases.

## Consecuencias
- Reduce la herencia.
- Desacopla a los Colegas (Colleagues).
- Simplifica los protocolos de los objetos.
- Abstrae c�mo cooperan lo objetos.
- Centraliza el control.

## Ejemplo
- Vamos a plantear un esquema de colaboraci�n a traves de un canal de chat. Tenemos un canal de chat que permitir� registrar usuarios, que luego podran enviar mensajes. Nuestro chat tomara el rol de Mediator.