using Patrones.Singleton.Ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User usuario1 = new User();
            usuario1.Name = "Nancy";
            
           
            try
            {
                SessionManager1.LogIn(usuario1);
                SessionManager1 SM = SessionManager1.GetInstance;
                SessionManager1.LogOut();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            
            }

           
        }
    }
}
