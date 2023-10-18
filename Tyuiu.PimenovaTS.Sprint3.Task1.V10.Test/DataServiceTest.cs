using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint3.Task1.V10.Lib;

namespace Tyuiu.PimenovaTS.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 17;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 1.168;

            Assert.AreEqual(wait, res);
        }
    }
}
