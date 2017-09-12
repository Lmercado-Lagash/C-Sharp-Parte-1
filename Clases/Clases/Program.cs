using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Empleado    //DEFINIR UNA CLASE
    {
        //private int edad; // ESTABLECER ATRIBUTOS        
        //public int Edad  // VARIABLE QUE RECONOCE UNA ENTRADA O SALIDA DEPENDIENDO DEL LLAMADO
        //{
        //    get { return edad; }
        //    set { edad = value; }
        //}

        //Lo anterior se puede resumir en la siguiente linea:

        public int Edad { get; set; }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // La forma anterior se puede escribir como: public string Nombre {get;set;}

            
        public int MiEdad() //DEFINICION DE METODOS
        {
            return Edad;
        }

        public void DefinirEdad(int algunaEdad)
        {
            Edad = algunaEdad;
        }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            Empleado Luis = new Empleado(); //CREAR UN NUEVO OBJETO TIPO EMPLEADO
            Luis.DefinirEdad(29);           //DEFINIR VALOR A UN ATRIBUTO ESPECIFICO DEL OBJETO
            int edad = Luis.MiEdad();       //LLAMAR A UN METODO DEL OBJETO Y ASIGNAR RETURN A UNA VARIABLE
            
            Console.WriteLine("La edad de Luis es {0} años", edad);


            Luis.Edad = 30;                //SE UTILIZA LA VARIABLE Edad COMO ENTRADA
            Console.WriteLine("La edad de Luis es {0} años", Luis.Edad); //SE UTILIZA LA VARIABLE Edad COMO SALIDA
        }
    }
}
