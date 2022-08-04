# Patron Adapter

## Prop�sito
- Convierte la interfaz de un clase en otra interfaz que es la que esperan los clientes. Permite que cooperen las clases que de otra forma no podr�an por tener interfaces incompatibles.
- Tambien conocido como Wrapper (Envoltorio).

## Aplicabilidad
- Se requiere usar una clase existente y su interfaz no concuerda con la que necesita.
- Se quiere crear una clase reutilizable que coopere con clases no relacionadas o que no han sido previstas.
- (Solo objetos) Es necesario usar varias subclases existentes pero no resulta pr�cticoadaptar su interfaz heredando de cada una de ellas.

## Consecuencias
- Adapta una clase Adaptee a Target, pero se refiere �nicamente a una clase Adaptee concreta.
- Permite que un Adapter redefina parte del comportamiento del Adaptee, por ser un Adapter una subclase de Adaptee (solo si hay herencia m�ltiple).
- Introduce un solo objeto, y no se necesita ning�n puntero adicional para obtener el objeto adaptado.

## Ejemplo
- Estamos desarrollando un sistema que transforma en aut�nomo un veh�culo est�ndar. Para eso implementa una Clase que gestiona el comportamiento del motor y su itegracion con el mundo. Funciona a la perfecci�n en motores a explosi�n. El problema surge con la nueva tecnolog�a de motores el�ctricos.
- El motor el�ctrico deber� estar conectado para poder activar, y activo para poder mover.