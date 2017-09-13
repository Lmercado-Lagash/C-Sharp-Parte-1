using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var objetosAlmacenables = new List<Almacenable>();
            Nota miNota = new Nota();
            objetosAlmacenables.Add(miNota);
            DBEntrada miBDentrada = new DBEntrada();
            objetosAlmacenables.Add(miBDentrada);
            miNota = new Nota();
            objetosAlmacenables.Add(miNota);
            miNota = new Nota();
            objetosAlmacenables.Add(miNota);

            foreach (Almacenable almacenable in objetosAlmacenables)
            {
                almacenable.Escribir(null);
                Console.WriteLine(almacenable.Leer());
            }
        }
    }
}
