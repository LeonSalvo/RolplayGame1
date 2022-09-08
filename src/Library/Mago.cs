using System;

namespace Magos
{
    public class Mago
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public Mago(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediente el estudio de la asignatura, y mediante elementos que la potencian.";
            this.Lore = lore;
            this.Vida = 90;
        }
    }   
}