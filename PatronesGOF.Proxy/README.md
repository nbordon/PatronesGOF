# Patr�n Proxy

## Prop�sito
- Proporciona un representante o sustituto de un objeto para controlar el acceso a �ste.
- Tambi�n conocido como Surrogate (sustituto)

## Aplicabilidad
Algunas situaciones comunes:
- Proxy remoto: representaci�n local de un objeto remoto.
- Proxy virtua: crear objetos por encargo.
- Proxy de protecci�n: controla el acceso al objeto original.
- Referencia inteligente: sustituto de un simple puntero que lleva a cabo operaciones adicionales cuando se accede a un objeto.

# Consecuencias:
- Un proxy remoto puede ocultar de hecho de que un objeto reside en un espacio de direcciones diferente.
- Un proxy virtual puede llevar a cabo optimizaciones tales como crear un objeto por encargo.
- Tanto los proxies de protecci�n, como las referencias inteligentes, permiten realizar tareas de mantenimiento adicionales cuando se accede a un objeto.

## Ejemplo
Tenemos un repositorio donde guardamos clientes, para acceder al repositorio implementamos un proxy para controlar la session y soliciar la instanciaci�n del repositorio a demanda.