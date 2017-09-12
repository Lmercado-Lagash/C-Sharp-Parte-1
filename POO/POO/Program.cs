using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var nuevoAlmacen = new Almacen("Almacen_1", 101);
            var miItem = nuevoAlmacen.EncontrarYDevolverItem(101);
            Console.WriteLine("Mi nuevo item es: "+ miItem.NombreItem);

        }
    }
}
