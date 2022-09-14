using NUnit.Framework;

namespace Roleplay
{


    public class ExampleTest
    {

        [Test]
        public void TestAtacarEnano()
        {
            Enano EnanoAtacante = new Enano("atacante","");
            Enano EnanoAtacado = new Enano("atacado","");
            EnanoAtacante.Atacar(EnanoAtacado);
            Assert.AreEqual(EnanoAtacado.Vida, 115);
        }
        [Test]
        public void TestAtacarElfo()
        {
            Elfo ElfoAtacante = new Elfo("atacante","");
            Elfo ElfoAtacado = new Elfo("atacado","");
            ElfoAtacante.Atacar(ElfoAtacado);
            Assert.AreEqual(ElfoAtacado.Vida, 75);
        }
        [Test]
        public void TestAtacarMago()
        {
            Mago MagoAtacante = new Mago("atacante","");
            Mago MagoAtacado = new Mago("atacado","");
            MagoAtacante.Atacar(MagoAtacado);
            Assert.AreEqual(MagoAtacado.Vida, 85);
        }

    }


}