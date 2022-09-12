using System;
using System.Collections.Generic;
namespace Library
{
    public class Enano
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public List<object> ListaItems;

        public Enano(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
            this.Lore = lore;
            this.Vida = 120;
        }

        public List<object> listaItems
        {
            get
            {
                return this.ListaItems;
            }
            set
            {
                if (this.ListaItems.Count <= 5 )
                {
                    this.ListaItems.Add(value);
                }
                else
                {
                    Console.WriteLine("Inventario lleno");
                }           
            }
        }   
    }
}   