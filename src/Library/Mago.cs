using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Mago
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public List<Items> ListaItems;

        public Mago(string nombre, string lore)
        {
            this.ListaItems = new List<Items>();
            this.Nombre = nombre;
            this.Descripcion = "Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediente el estudio de la asignatura, y mediante elementos que la potencian.";
            this.Lore = lore;
            this.Vida = 90;
            this.ListaItems.Add(new Items("Puños", 10, 0));
            this.ListaItems.Add(new Items("Sin armadura", 0, 5));

        }

        public void Atacar(object personaje2)
        {
            Enano comprobadorEnano = new Enano("comprobador","");
            Elfo comprobadorElfo = new Elfo("comprobador","");
            Mago comprobadorMago = new Mago("comprobador","");


            if (personaje2.GetType().IsInstanceOfType(comprobadorEnano))
            {
                int SumaDaño = 0;
                int SumaArmadura = 0;
                Enano personaje = (Enano) personaje2;
                foreach (Items item in this.ListaItems)
                {
                    SumaDaño += item.Daño;
                }
                foreach (Items item in personaje.ListaItems)
                {
                    SumaArmadura += item.Armadura;
                }
                int SumaTotal = SumaDaño - SumaArmadura;
                personaje.Vida -= SumaTotal;

            }
            else
            if (personaje2.GetType().IsInstanceOfType(comprobadorElfo))                
            {
                Elfo personaje = (Elfo) personaje2;
                int SumaDaño = 0;
                int SumaArmadura = 0;
                foreach (Items item in this.ListaItems)
                {
                    SumaDaño += item.Daño;
                }
                foreach (Items item in personaje.ListaItems)
                {
                    SumaArmadura += item.Armadura;
                }
                int SumaTotal = SumaDaño - SumaArmadura;
                personaje.Vida -= SumaTotal;
            }
            else
            if (personaje2.GetType().IsInstanceOfType(comprobadorMago))                
            {
                Mago personaje = (Mago) personaje2;
                int SumaDaño = 0;
                int SumaArmadura = 0;
                foreach (Items item in this.ListaItems)
                {
                    SumaDaño += item.Daño;
                }
                foreach (Items item in personaje.ListaItems)
                {
                    SumaArmadura += item.Armadura;
                }
                int SumaTotal = SumaDaño - SumaArmadura;
                personaje.Vida -= SumaTotal;
            }

        }
    }
} 
