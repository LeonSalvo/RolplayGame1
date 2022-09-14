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
        public Items Arma{get;set;}
        public Items Armadura{get;set;}

        public Enano(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
            this.Lore = lore;
            this.Vida = 120;
        }

        public string Atacar(object personaje2)
        {
            var personajeType = personaje2.GetType();
            Enano comprobadorEnano = new Enano("comprobador","");
            if (personajeType.IsInstanceOfType(comprobadorEnano))
            {
                this.AtacarEnano(personaje2);
                return "si";
            }
            else
            {
                return "no";
            }
        }

        public void AtacarEnano(Enano personaje2)
        {
            personaje2.Vida -= this.Arma.ValorObjeto + personaje2.Armadura.ValorObjeto;
        }
    }
}   