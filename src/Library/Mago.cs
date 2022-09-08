using System;

namespace Magos
{
    public class Mago
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public int Vida{get;set;}
        public Mago(string nombre, string descripcion, int vida)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Vida = vida;
        }
    }   
}