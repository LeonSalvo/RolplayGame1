using System;
using System.Collections.Generic;

namespace Library
{
    public class Elfo
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public List<object> ListaItems;
        public Elfo(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los elfos son criaturas supernaturales que también poseen características mágicas, y en general son conocidos por ayudar a los demás.";
            this.Lore = lore;
            this.Vida = 80;
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