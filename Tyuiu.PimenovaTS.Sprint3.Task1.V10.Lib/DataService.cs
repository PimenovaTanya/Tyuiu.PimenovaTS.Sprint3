using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PimenovaTS.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double s = 0;
            while (startValue <= stopValue)
            {
                s = s + Math.Pow((1 / (startValue + Math.Pow(value,startValue))), startValue);
                startValue++;
            }
            return Math.Round(s, 3);
        }
    }
}
