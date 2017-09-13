using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchYMas
{
    class Program
    {
        static void Main(string[] args)
        {

            // ***************EJEMPLO DE INCREMENTO ANTES O DESPUES DE LA VARIABLE ******************

            //for (int i=0; i<10; i++)
            //    {
            //        Console.Write("Feliz Cumple ");
            //    }
            //Console.WriteLine("\nTaDaaaaa");

            //int edad = 29;
            //int edadNueva = edad++;

            //Console.WriteLine("Edad es: {0}, EdadNueva es: {1}", edad, edadNueva);

            //edadNueva = ++edad;

            //Console.WriteLine("Edad es: {0}, EdadNueva es: {1}", edad, edadNueva);



            // ***************** EJEMPLO DE CORTES DE CICLO "CONTINUE" Y "BREAK" ******************

            //int i = 0;
            //for (; ;)
            //{
            //    ++i;
            //    if (i == 5)
            //        {
            //            continue;
            //        }
            //    Console.Write("Feliz CUMPLE {0} ", i);

            //    if (i > 10)
            //    {
            //        break;
            //    }


            //}


            // *************** EJEMPLO DEL USO DE LA FUNCION MOD *******************

            //for (int i=0; i< 2000; i++)

            //{
            //    if(i % 100 == 0)
            //    {
            //        Console.Write("FELIZ CUMPLEAÑOS! {0}", i);
            //    }
            //}


            // ************** EJEMPLO DEL USO DE SWITCH ****************

            int opcion;

            Console.Write("Ingrese opcion de 1 a 6: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Opcion 1\n");
                    break;
                case 2:
                    Console.Write("Opcion 2\n");
                    break;
                case 3:
                    Console.Write("Opcion 3\n");
                    break;
                case 4:
                    Console.Write("Opcion 4\n");
                    break;
                case 5:
                    Console.Write("Escogiste un valor alto\n");
                    break;
                case 6:
                    Console.Write("Escogiste el valor más alto\n");
                    break;

            }






        }

    
    }
}
