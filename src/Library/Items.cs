using System;
// hola, pude :)
namespace Roleplay
{
    public class Items
    {
        public string Descripcion {get;}
        public int ValorObjeto {get;set;}

        public Items(string descripcion, int valorObjeto)
        {
            this.Descripcion = descripcion;
            this.ValorObjeto = valorObjeto;
        }
    }
}