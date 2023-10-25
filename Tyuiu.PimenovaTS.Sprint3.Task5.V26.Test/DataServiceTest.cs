using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint3.Task5.V26.Lib;

namespace Tyuiu.PimenovaTS.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 90116.622;

            Assert.AreEqual(wait, res);
        }
    }
}
