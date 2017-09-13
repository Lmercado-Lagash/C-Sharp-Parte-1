using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primera linea del programa");

            var tester = new Tester();
            tester.Metodo1();

            //var x = 0;
            //var y = 12 / x;           //Arroja excepcion de una division por cero
            Console.WriteLine("Fin de programa"); //no alcanza a pasar por este write
        }
    }
}
