using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PesrikovDD.Sprit1.Task2.V17.Lib;
namespace Tyuiu.PesrikovDD.Sprit1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(4, res);
        }
    }
}