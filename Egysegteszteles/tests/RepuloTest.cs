using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszteles.tests
{
    [TestFixture]
    class RepuloTest
    {
        Repulo repulo;

        [SetUp]
        public void SetUp()
        {
            repulo = new Repulo(32);
        }
        [TearDown]
        public void TearDown()
        {
            //....
        }

        [TestCase]
        public void UjRepulonMindenHelySzabad()
        {
            Assert.AreEqual(32, repulo.SzabadHelyek, "A férőhelyek száma hibás!");

            var repulo2 = new Repulo(86);
            Assert.AreEqual(32, repulo.SzabadHelyek, "A férőhelyek száma hibás!");
        }
        [TestCase]
        public void HelyfoglalasUtanAHelyekSzamaCsokken()
        {
            repulo.lefoglal();
            Assert.AreEqual(31, repulo.SzabadHelyek, "Hibás számítás a maradék férőhelyeknél!");
        }
        [TestCase]
        public void RepuloTeli()
        {
            Assert.IsFalse(repulo.teli, "Üres repülő teli van");
            for (int i = 0; i < 32; i++)
            {
                repulo.lefoglal();
            }
            Assert.IsTrue(repulo.teli, "Teli repulo megsincs tele");
        }
        [TestCase]
        public void teliRepuloreNeLehessenHelyetFoglalni()
        {
            for (int i = 0; i < 32; i++)
            {
                repulo.lefoglal();
            }

            bool sikerult=repulo.lefoglal();
            Assert.AreEqual(0, repulo.SzabadHelyek);
            Assert.IsTrue(repulo.teli);
            Assert.IsFalse(sikerult);
        }

        void NegativRepuloLetrehozas()
        {
            var rep = new Repulo(-2);
        }

        [TestCase]
        public void AHelyekSzamaNemLehetNegativ()
        {
            Assert.Throws<ArgumentException>(NegativRepuloLetrehozas);
            //alternatív mód->lambda függvény
            Assert.Throws<ArgumentException>(() => {
                var rep = new Repulo(-2);
            });
        }

    }
}
