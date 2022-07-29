# Patrón Proxy

## Propósito
- Proporciona un representante o sustituto de un objeto para controlar el acceso a éste.
- También conocido como Surrogate (sustituto)

## Aplicabilidad
Algunas situaciones comunes:
- Proxy remoto: representación local de un objeto remoto.
- Proxy virtua: crear objetos por encargo.
- Proxy de protección: controla el acceso al objeto original.
- Referencia inteligente: sustituto de un simple puntero que lleva a cabo operaciones adicionales cuando se accede a un objeto.

# Consecuencias:
- Un proxy remoto puede ocultar de hecho de que un objeto reside en un espacio de direcciones diferente.
- Un proxy virtual puede llevar a cabo optimizaciones tales como crear un objeto por encargo.
- Tanto los proxies de protección, como las referencias inteligentes, permiten realizar tareas de mantenimiento adicionales cuando se accede a un objeto.

## Ejemplo
Tenemos un repositorio donde guardamos clientes, para acceder al repositorio implementamos un proxy para controlar la session y soliciar la instanciación del repositorio a demanda.