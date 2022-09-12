using System;
using System.Collections.Generic;
namespace Magos
{
    public class Mago
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public List<object> ListaItems;
        public Mago(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediente el estudio de la asignatura, y mediante elementos que la potencian.";
            this.Lore = lore;
            this.Vida = 90;
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
