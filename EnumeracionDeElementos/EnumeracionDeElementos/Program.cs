using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionDeElementos
{
    class Program
    {

        enum Color
        {
            Amarillo, Rojo, Azul, Verde
        }


        static void Main(string[] args)
        {
            Color favorito = Color.Rojo;

            switch (favorito)
                {
                case Color.Verde:
                    Console.WriteLine("Mi color favorito es el Verde");
                    break;

                case Color.Rojo:
                    Console.WriteLine("Mi color favorito es el Rojo");
                    break;

            }

        }


    }
}

