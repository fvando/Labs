using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace TestProject01
{
    [TestClass]
    public class Cls01Testes
    {

        csT.Cls01 OMacTeste = new csT.Cls01();

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TMInputElementsnull()
        {
            throw new Exception("This test fails!");
       
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TMInputArraynotnull()
        {
            throw new ArgumentNullException("Array não pode ser nulo!");
        }


        [TestMethod]
        public void TMInputcase1()
        {
            Assert.AreEqual(OMacTeste.TMInputArray(new int[] {1,2}, 9), "", "Não existe elementos representando o k");
        }


        [TestMethod]
        public void TMInputcase2()
        {
            Assert.AreEqual(OMacTeste.TMInputArray(new int[] { 3, 3, 2 }, 9), "", "Não existe elementos representando o k");
        }

        [TestMethod]
        public void TMInputcase3()
        {
            Assert.AreEqual(OMacTeste.TMInputArray(new int[] { 3, 2 }, 9), "", "Não existe elementos representando o k");
        }

        [TestMethod]
        public void TMInputcase4()
        {
            Assert.AreEqual(OMacTeste.TMInputArray(new int[] {1, -3, 5, 11, -2, 4, 7 }, 9), "(11,-2),(5,4)", "");
        }

        [TestMethod]
        public void TMInputcase6()
        {
            Assert.AreEqual(OMacTeste.TMInputArray(new int[] { 0 }, 9), "", "");
        }

        [TestMethod]
        public void TMInputcase7()
        {
            Assert.AreEqual(OMacTeste.TMInputArray(new int[] { 0 }, 0), "", "");
        }

    }
}
