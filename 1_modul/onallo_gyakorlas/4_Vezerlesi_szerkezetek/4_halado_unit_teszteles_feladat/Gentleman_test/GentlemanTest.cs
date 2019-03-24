using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Halado_unit_teszteles_feladat;

namespace Gentleman_test
{
    [TestClass]
    public class GentlemanTest
    {
        [TestMethod]
        public void koszontesTesztelo1()

        {
            //Arrange
            Gentleman oli = new Gentleman();
            string elvartUdvozles = "Hello Oli";
            string valodiUdvozles = null;


            //Act
            valodiUdvozles = oli.SayHello("Oli");

            //Assert
            Assert.AreEqual(elvartUdvozles, valodiUdvozles);
        }

        [TestMethod]
        public void koszontesTesztelo2()

        {
            //Arrange
            Gentleman oli = new Gentleman();
            string elvartUdvozles = "Hello Anonymus";
            string valodiUdvozles = null;


            //Act
            valodiUdvozles = oli.SayHello(null);

            //Assert
            Assert.AreEqual(elvartUdvozles, valodiUdvozles);
        }
    }
}
