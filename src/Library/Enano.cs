using System;

namespace Library
{
    public class Enano
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public Enano(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
            this.Lore = lore;
            this.Vida = 120;
        }
    }   
}