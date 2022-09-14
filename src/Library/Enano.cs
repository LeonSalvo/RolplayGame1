using System;
using System.Collections.Generic;
namespace Roleplay
{
    public class Enano
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public List<Items> ListaItems {get;set;}

        public Enano(string nombre, string lore)
        {
            this.ListaItems = new List<Items>();
            this.Nombre = nombre;
            this.Descripcion = "Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
            this.Lore = lore;
            this.Vida = 120;
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
                Enano personaje = (Enano) personaje2;
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