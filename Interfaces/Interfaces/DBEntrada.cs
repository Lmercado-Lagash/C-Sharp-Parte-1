using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DBEntrada : Almacenable
    {
        private ReturnStatus estado;
        public ReturnStatus Status
        {
         get
            {
                return estado;
            }
        
         set
            {
                estado = value;
            }

        }

        public void Escribir(object obj)
        {
            Console.WriteLine("Escribiendo objeto desde la base de datos...");
        }

        public string Leer()
        {
            return "Leyendo entradas desde la base de datos...";
        }
    }
}
