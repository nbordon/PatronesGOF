using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.Username = "pepito";
            usuario.Password = "123.lll";

            try
            {
                SessionManager.Login(usuario);
                SessionManager sm = SessionManager.GetInstace;
                SessionManager.Logout();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
