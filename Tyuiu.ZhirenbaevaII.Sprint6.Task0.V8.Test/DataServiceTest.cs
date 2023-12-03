using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint6.Task0.V8.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint6.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 6.425;
            Assert.AreEqual(wait, res);
        }
    }
}
