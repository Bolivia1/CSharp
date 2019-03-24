using System;
using Bankszamla;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bankszamla_tesztelo
{
    [TestClass]
    public class BankszamlaTeszt
    {
        [TestMethod]
        public void Egyenlegnoveles_tesztelo()
        {
            //arrange
            int eredetiEgyenleg = 5000;
            int berakottOsszeg = 2000;
            int elvartUjEgyenleg = 7000;
            int valosUjEgyenleg;

            Bankszamla_letrehozo szamla = new Bankszamla_letrehozo("oli", eredetiEgyenleg);

            //act
            valosUjEgyenleg = szamla.EgyenlegNovelo(berakottOsszeg);

            //assert
            Assert.AreEqual(elvartUjEgyenleg, valosUjEgyenleg);
        }

        [TestMethod]
        public void Egyenlegcsokkentes_tesztelo1()

        {
            //arrange
            int eredetiEgyenleg = 5000;
            int kivettOsszeg = 2000;
            int elvartUjEgyenleg = 3000;
            int valosUjEgyenleg;

            Bankszamla_letrehozo szamla = new Bankszamla_letrehozo("oli", eredetiEgyenleg);

            //act
            valosUjEgyenleg = szamla.EgyenlegCsokkento(kivettOsszeg);

            //assert
            Assert.AreEqual(elvartUjEgyenleg, valosUjEgyenleg);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Egyenlegcsokkentes_tesztelo2()

        {
            //arrange
            int eredetiEgyenleg = 5000;
            int kivettOsszeg = 7000;
            int elvartUjEgyenleg = -2000;
            int valosUjEgyenleg;

            Bankszamla_letrehozo szamla = new Bankszamla_letrehozo("oli", eredetiEgyenleg);

            //act
            valosUjEgyenleg = szamla.EgyenlegCsokkento(kivettOsszeg);

            //assert
            Assert.AreEqual(elvartUjEgyenleg, valosUjEgyenleg);
        }
    }
}
