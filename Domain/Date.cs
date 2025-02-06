using Moon_Phase_App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoonData.Domain
{
    
    public class Date : EntityBase
    {
        public int Day, Month, Year;


        public Date(int Day, int Month, int Year,int id)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"D/ {Day}/Month/{Month}/Year{Year}";

        }

    }
}
