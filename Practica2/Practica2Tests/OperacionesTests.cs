using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Tests
{
    [TestClass()]
    public class OperacionesTests
    {
        [TestMethod()]
        public void DividiendoTest()
        {
            //arrage
            int dividendo = 10;
            int divisor = 5;
            int ResultadoEsperado = 2;
            Operaciones operaciones = new Operaciones();
            //act
            int resultado = operaciones.Dividiendo(dividendo, divisor);
            //assert
            Assert.AreEqual(ResultadoEsperado, resultado);
        }




    }
}
  

   
