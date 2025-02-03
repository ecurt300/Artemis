using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Moon_Phase_App.Domain
{
    public class Date
    {
        public int Day, Month, Year;


        public Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }

        public override string ToString()
        {
            return $"D/ {Day}/Month/{Month}/Year{Year} ";

        }

    }
}
