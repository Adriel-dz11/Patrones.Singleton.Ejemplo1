using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.Ejemplo1
{
    public class SessionManager1
    {
        //Elementos del inicio de sesión
        private static SessionManager1 session;
        public User Usuario { get; set; }
     
        public DateTime FechaInicio { get; set; }
        
        
        //Función para obtener/devolver Instancias
        public static SessionManager1 GetInstance
        {
            get
            {
                if (session == null) throw new Exception("Aún no se ha iniciado sesión");
                return session;
                
            }

        }

       

        private SessionManager1()
        {
        }

        
        //Métodos
        public static object _lock = new object();
        public static void LogIn(User pusuario)
        {
            lock (_lock)
            {
                              
                    
                if (session == null){
                session = new SessionManager1();
                session.Usuario = pusuario;
                session.FechaInicio = DateTime.Now;
                
            
                }
                else
                {
                    throw new Exception("Sesión iniciada");
                    
                 }
            }
        }
        public static void LogOut()
        {
            if (session != null)
            {
                session = null;
                Console.WriteLine("Cerrar Sesión");
            }
        
                
           
        }
    }
}
