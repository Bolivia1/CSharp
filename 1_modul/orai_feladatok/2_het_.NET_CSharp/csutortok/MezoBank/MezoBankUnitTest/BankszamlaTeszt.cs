using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MezoBankLibrary;

namespace MezoBankUnitTest
{
    [TestClass]
    public class BankszamlaTeszt
    {

        [TestMethod]
        public void EgyenlegNoveles()
        {
            //Arrange  - előkészülés, felkészülés
            int expectedEgyenleg;
            int actualEgyenleg;
            Bankszamla szla;

            expectedEgyenleg = 120;
            szla = new Bankszamla("imi");

            //Act   - maga a tesztelés
            actualEgyenleg = szla.EgyenlegetNovel(expectedEgyenleg);

            //Assert - eredményvizsgálat
            Assert.AreEqual(expectedEgyenleg, actualEgyenleg); //deklarálás: arrange

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EgyenlegCsokkentes()
        {
            // Assert.Inconclusive();  //ez még nincs kész

            //Arrange  - előkészülés, felkészülés
            int kivettOsszeg = 200;
            int expectedEgyenleg = -200;
            int actualEgyenleg;
            Bankszamla szla;
            
            szla = new Bankszamla("imi");

            //Act   - maga a tesztelés
            actualEgyenleg = szla.EgyenlegetCsokkent(kivettOsszeg);

            //Assert - eredményvizsgálat
            Assert.AreEqual(expectedEgyenleg, actualEgyenleg); //deklarálás: arrange

        }
    }
}
