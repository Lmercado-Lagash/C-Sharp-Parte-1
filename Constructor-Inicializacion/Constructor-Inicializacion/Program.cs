using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inicializacion
{
    class Empleado
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NumeroTelefonico { get; set; }

        public void Bono(double bonoPorcentaje)
        {
            Salario += Salario * bonoPorcentaje;
        }

        public Empleado(int edad, string nombre, double salario, DateTime fechainicio, string numerotelefonico)
        {
            Edad = edad;
            Nombre = nombre;
            Salario = salario;
            FechaInicio = fechainicio;
            NumeroTelefonico = numerotelefonico;
        }

        public Empleado()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado Luis = new Empleado()
            {
                Edad = 29,
                Nombre = "Luis",
                Salario = 900000,
                FechaInicio = new DateTime(2017, 09, 11),
                NumeroTelefonico = "984312695"
            };
            
            Console.WriteLine("La edad de {0} es: {1}, comenzo a trabajar el {2} con un sueldo de ${3}", Luis.Nombre, Luis.Edad, Luis.FechaInicio, Luis.Salario);
            Luis.Bono(0.05);
            Console.WriteLine("La edad de {0} es: {1}, comenzo a trabajar el {2} con un sueldo de ${3}", Luis.Nombre, Luis.Edad, Luis.FechaInicio, Luis.Salario);

            Empleado Daniela = new Empleado(27, "Daniela", 980000, new DateTime(2017, 1, 3), "566745234");

            Console.WriteLine("La edad de {0} es: {1}, comenzo a trabajar el {2} con un sueldo de ${3}", Daniela.Nombre, Daniela.Edad, Daniela.FechaInicio, Daniela.Salario);





        }

    }
}