# Patron Adapter

## Propósito
- Convierte la interfaz de un clase en otra interfaz que es la que esperan los clientes. Permite que cooperen las clases que de otra forma no podrían por tener interfaces incompatibles.
- Tambien conocido como Wrapper (Envoltorio).

## Aplicabilidad
- Se requiere usar una clase existente y su interfaz no concuerda con la que necesita.
- Se quiere crear una clase reutilizable que coopere con clases no relacionadas o que no han sido previstas.
- (Solo objetos) Es necesario usar varias subclases existentes pero no resulta prácticoadaptar su interfaz heredando de cada una de ellas.

## Consecuencias
- Adapta una clase Adaptee a Target, pero se refiere únicamente a una clase Adaptee concreta.
- Permite que un Adapter redefina parte del comportamiento del Adaptee, por ser un Adapter una subclase de Adaptee (solo si hay herencia múltiple).
- Introduce un solo objeto, y no se necesita ningún puntero adicional para obtener el objeto adaptado.

## Ejemplo
- Estamos desarrollando un sistema que transforma en autónomo un vehículo estándar. Para eso implementa una Clase que gestiona el comportamiento del motor y su itegracion con el mundo. Funciona a la perfección en motores a explosión. El problema surge con la nueva tecnología de motores eléctricos.
- El motor eléctrico deberá estar conectado para poder activar, y activo para poder mover.