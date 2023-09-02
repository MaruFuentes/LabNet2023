using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic.Tests
{
    [TestClass()]
    public class SuppliersLogicTests
    {
        [TestMethod()]
        public void GettAllTest()
        {
            SuppliersLogic suppliersLogic = new SuppliersLogic();

            var Listado = suppliersLogic.GettAll();
            Assert.IsNotNull(Listado);

        }
    }
}