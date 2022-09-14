using System;
namespace Roleplay
{
    public class Elfo
    {
        public string Nombre {get;set;}
        public string Descripcion {get;}
        public string Lore {get;set;}
        public int Vida{get;set;}
        public Items Arma{get;set;}
        public Items Armadura{get;set;}

        public Elfo(string nombre, string lore)
        {
            this.Nombre = nombre;
            this.Descripcion = "Los elfos son criaturas supernaturales que también poseen características mágicas, y en general son conocidos por ayudar a los demás.";
            this.Lore = lore;
            this.Vida = 80;
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
                return "si";
            }
            else
            if (personaje2.GetType().IsInstanceOfType(comprobadorElfo))                
            {
                Elfo personaje = (Elfo) personaje2;
                personaje.Vida -= this.Arma.ValorObjeto + personaje.Armadura.ValorObjeto; 
                return "si";
            }
            else
            if (personaje2.GetType().IsInstanceOfType(comprobadorMago))                
            {
                Mago personaje = (Mago) personaje2;
                personaje.Vida -= this.Arma.ValorObjeto + personaje.Armadura.ValorObjeto; 
                return "si";
            }
            else
            {
                return "Hubo un error en las clases";
            }
        }
    }   
}