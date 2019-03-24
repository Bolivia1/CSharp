using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace konstruktor_tesztelo
{
    [TestClass]     //test class attribútum: tesztelőkörnyezetnek szól; ebből tudja, melyek a tesztmetódusok => metaadat
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmberKonstruktor()
        {
            //Arrange
            Ember tesztEmber = new Ember("Oli");

            //Act
            string nev = tesztEmber.Neve;

            //Assert
            string vartNev = "Oli";
            Assert.AreEqual(vartNev, nev);
        }
    }
}
