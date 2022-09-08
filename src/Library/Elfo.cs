using System;

namespace Library
{
    public class Elfo
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public Elfo(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los elfos son criaturas supernaturales que también poseen características mágicas, y en general son conocidos por ayudar a los demás.";
            this.Lore = lore;
            this.Vida = 80;
        }
    }   
}