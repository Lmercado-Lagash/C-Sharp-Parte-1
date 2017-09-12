using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Almacen
    {
        public int ID { get; set; }
        public string NombreAlmacen { get; set; }

        public Almacen(string Nombre, int ID)
        {
            NombreAlmacen  = Nombre;
            this.ID = ID;
        }

        public Item EncontrarYDevolverItem(int itemID)
        {
            Item returnItem = new Item() { ID = 101, NombreItem = "Microsoft Office" };
            return returnItem;
        }
    }
}
