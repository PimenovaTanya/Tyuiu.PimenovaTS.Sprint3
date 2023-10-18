using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PimenovaTS.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string t = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    t += c;
                }
            }
            int number = Int32.Parse(t);
            return number;
        }
    }
}
