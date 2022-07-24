using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Singleton
{
    public class SessionManager
    {
        // Atributos
        private static object _lock = new object();
        private static SessionManager _session;
        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        // Constructores
        private SessionManager() { }

        // Propiedades
        public static SessionManager GetInstace
        {
            get
            {
                if (_session == null) throw new Exception("Sesion no iniciada");
                return _session;
            }
        }

        // Métodos
        public static void Login(Usuario usuario)
        {
            lock (_lock)
            {
                if(_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }
        }

    }
}
