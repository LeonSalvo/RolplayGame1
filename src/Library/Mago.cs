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
        public Items Arma{get;set;}
        public Items Armadura{get;set;}

        public Mago(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediente el estudio de la asignatura, y mediante elementos que la potencian.";
            this.Lore = lore;
            this.Vida = 90;
            this.Arma = new Items("Puños", 10);
            this.Armadura = new Items("Sin armadura", 5);
        }

        public string Atacar(object personaje2)
        {
            Enano comprobadorEnano = new Enano("comprobador","");
            Elfo comprobadorElfo = new Elfo("comprobador","");
            Mago comprobadorMago = new Mago("comprobador","");


            if (personaje2.GetType().IsInstanceOfType(comprobadorEnano))
            {
                Enano personaje = (Enano) personaje2;
                personaje.Vida -= this.Arma.ValorObjeto + personaje.Armadura.ValorObjeto; 
                return $"{this.Nombre} atacó a {personaje}, realizando {this.Arma.ValorObjeto - personaje.Armadura.ValorObjeto}";
            }
            else
            if (personaje2.GetType().IsInstanceOfType(comprobadorElfo))                
            {
                Elfo personaje = (Elfo) personaje2;
                personaje.Vida -= this.Arma.ValorObjeto + personaje.Armadura.ValorObjeto; 
                return $"{this.Nombre} atacó a {personaje}, realizando {this.Arma.ValorObjeto - personaje.Armadura.ValorObjeto}";
            }
            else
            if (personaje2.GetType().IsInstanceOfType(comprobadorMago))                
            {
                Mago personaje = (Mago) personaje2;
                personaje.Vida -= this.Arma.ValorObjeto + personaje.Armadura.ValorObjeto; 
                return $"{this.Nombre} atacó a {personaje}, realizando {this.Arma.ValorObjeto - personaje.Armadura.ValorObjeto}";
            }
            else
            {
                return "Hubo un error en las clases";
            }

        }
    }
} 
