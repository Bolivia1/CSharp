using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_teszteles_feladat;

namespace UnitTestProject1
{
    [TestClass]
    public class GentlemanTest
    {
        [TestMethod]
        public void TestGentleman()
        {
            //Arrange
            Gentleman billyMack = new Gentleman();
            string name = "Billy Mack";
            string elvartKoszones = "Hello Billy Mack";

            //Act
            string koszon = billyMack.SayHello(name);

            //Assert            
            Assert.AreEqual(elvartKoszones, koszon); 

        }
    }
}
