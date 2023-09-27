using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PesrikovDD.Sprit1.Task1.V24.Lib;

namespace Tyuiu.PesrikovDD.Sprit1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
    }
}