using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Tester
    {
        public void Metodo1()
        {
            Console.WriteLine("Comienza Metodo 1");
            Metodo2();
            Console.WriteLine("Termina Metodo 1");
        }

        public void Metodo2()
        {
            Console.WriteLine("Comienza Metodo 2");
            Metodo3();
            Console.WriteLine("Termina Metodo 2");
        }

        public void Metodo3()
        {
            Console.WriteLine("Comienza Metodo 3");
            try
            {
                var x = 0;
                var y = 12 / x; 
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion detectada: {0}", e.Message);
            }
          
            Console.WriteLine("Termina Metodo 3");
        }
    }
}
