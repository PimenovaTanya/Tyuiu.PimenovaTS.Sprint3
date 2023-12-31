﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PimenovaTS.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                s = s + ((Math.Pow(value, i) + 0.5) + Math.Cos(i));
            }
            return Math.Round(s, 3);
        }
    }
}
