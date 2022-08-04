# Patrón Strategy

## Proposito
- Define una familia de algoritmos, encapsula cada uno de ellos y los hace intercambiables. Permite que un algoritmo varíe independientemente de los clientes que lo usan.
- También conocido como Policy (Política).

## Aplicabilidad
- Muchas clases relacionadas difieren sólo en su comportamiento. Permite configurar una clase con un determinado comportamiento de entre muchos posibles.
- Se necesitan distintas variantes de un algoritmo.
- Un algoritmo usa datos que los clientes no deberían conocer.
- Unca clase define muchos comportamientos, y éstos se representan como múltiples sentencias condicionales en sus operaciones.

## Consecuencias
- Familias de algoritmos relacionados.
- Una alternativa más flexible a la herencia de Contexto.
- Las estrategias eliminan las sentencias condicionales.
- Una elección de implementaciones.
- Los clientes deben conocer las diferentes Estrategias.
- Mayor número de objetos, uno por cada algoritmo y estado.

## Ejemplo
- Simularemos un videojuego donde tenemos un jugador que va a disparar diferentes armas. Las armas las puede recoger del contexto. El jugador posee una referencia a un arma las cuales pueden ser de diferentes tipos. Estas armas tendran un comportamiento diferente en el mensaje Disparar.
