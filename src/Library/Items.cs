using System;

namespace Library
{
    public class Items
    {
        public string Descripcion {get;set;}
        public int Daño {get;set;}
        public int Armadura {get;set;}

        public Items(string descripcion, int daño, int armadura)
        {
            this.Descripcion = descripcion;
            this.Daño = daño;
            this.Armadura = armadura;
        }
    }
}