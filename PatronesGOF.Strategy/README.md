# Patr�n Strategy

## Proposito
- Define una familia de algoritmos, encapsula cada uno de ellos y los hace intercambiables. Permite que un algoritmo var�e independientemente de los clientes que lo usan.
- Tambi�n conocido como Policy (Pol�tica).

## Aplicabilidad
- Muchas clases relacionadas difieren s�lo en su comportamiento. Permite configurar una clase con un determinado comportamiento de entre muchos posibles.
- Se necesitan distintas variantes de un algoritmo.
- Un algoritmo usa datos que los clientes no deber�an conocer.
- Unca clase define muchos comportamientos, y �stos se representan como m�ltiples sentencias condicionales en sus operaciones.

## Consecuencias
- Familias de algoritmos relacionados.
- Una alternativa m�s flexible a la herencia de Contexto.
- Las estrategias eliminan las sentencias condicionales.
- Una elecci�n de implementaciones.
- Los clientes deben conocer las diferentes Estrategias.
- Mayor n�mero de objetos, uno por cada algoritmo y estado.

## Ejemplo
- Simularemos un videojuego donde tenemos un jugador que va a disparar diferentes armas. Las armas las puede recoger del contexto. El jugador posee una referencia a un arma las cuales pueden ser de diferentes tipos. Estas armas tendran un comportamiento diferente en el mensaje Disparar.
