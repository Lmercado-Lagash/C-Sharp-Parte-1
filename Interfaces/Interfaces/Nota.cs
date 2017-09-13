using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Nota : Almacenable
    {
        public void Escribir(object obj)
        {
            Console.WriteLine("Escribiendo objeto en disco...");
        }

        public string Leer()
        {
            return "Leyendo nota desde disco...";
        }

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

        public void OtroMetodo()
        {
            Console.WriteLine("Algun otro metodo de Nota");
        }

    }
}
