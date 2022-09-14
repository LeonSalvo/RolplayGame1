using System;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Enano enano = new Enano("hola","si");
            Elfo elfo = new Elfo("hola","si");
            Mago mago = new Mago("Jesus", "si");

            Console.WriteLine(elfo.Atacar(enano));

        }
    }
}
