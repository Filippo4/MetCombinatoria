using EquazioniLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace Calcolicombinatori.Test
{
    [TestClass]
    public class CalcoliTest
    {

        [TestMethod]
        public void TestFattoriale1()
        {
            double risp = CalcoliCombinatori.Fattoriale(0);
            Assert.AreEqual(risp, 1);
        }
        [TestMethod]
        public void TestFattoriale2()
        {
            double risp = CalcoliCombinatori.Fattoriale(1);
            Assert.AreEqual(risp, 1);
        }
        [TestMethod]
        public void TestFattoriale3()
        {
            double risp = CalcoliCombinatori.Fattoriale(5);
            Assert.AreEqual(risp, 120);
        }
        [TestMethod]
        public void TestFattoriale4()
        {
            double risp = CalcoliCombinatori.Fattoriale(10);
            Assert.AreEqual(risp, 3628800);
        }
        [TestMethod]
        public void TestFattoriale6()
        {
            string numero = "30414093201713378043612608166064768844377641568960512000000000000";
            stringToParse = numero;
            BigInteger number1 = new BigInteger(numero);
            double risp = CalcoliCombinatori.Fattoriale(50);
            Assert.AreEqual(risp, number1);
        }
}
}
