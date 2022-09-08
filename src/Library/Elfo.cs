using System;

namespace Library
{
    public class Elfo
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public int Vida{get;set;}
        public Elfo(string nombre, string descripcion, int vida)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Vida = vida;
        }
    }   
}