using Artemis;
using MoonData.Data;
using MoonData.Domain;
using Utilities;
namespace MoonSearch
{
    /*
     * MoonSearch is where the meat of the program lives. This is where the moondatabase is queried based on the calculated date found from the index of the date entered in
     * Basically counts up from the current id until the that specific moon is found then it displays the number of days until that next moonphase.
     * A dictionary of moons are filled from a list created from filling moonphase data from moon database. TODO: Should use date and time of .net library since we need 
     * leap year calculation 
     */
    public class MoonQuery
    {



        //Quick and Dirty Singleton


        private static MoonQuery? instance { get; set; }

        public static MoonQuery Instance()
        {
            if (instance == null)
            {
                instance = new MoonQuery();
            }
            return instance;
        }

        private int CountDaysAfterYears(Date date,Date prevDate)
        {
            int yearDiff = date.Year - prevDate.Year;
            int dayInc = 0;
            if (date.Year > prevDate.Year)
            {

                dayInc += yearDiff * 360;
            }
            return dayInc;
        }

        private int CountDaysAfterMonths(Date date, Date prevDate)
        {
            int monthDiff = date.Month - prevDate.Month;
            int dayInc = 0;
            if (date.Month > prevDate.Month)
            {

                dayInc += monthDiff * 12;
            }
            return dayInc;
        }
        private int CountDaysAfterDays(Date date, Date prevDate)
        {
            int daysDiff = date.Day - prevDate.Day;
            int dayInc = 0;
            if (date.Month > prevDate.Month)
            {

                dayInc += daysDiff;
            }
            return dayInc;
        }
        public void FindMoonAndDisplayResults(MoonFakeDatabase database, Moon currentMoon, Phase targetPhase)
        {
            int results = FindMoon(database,currentMoon,targetPhase);
            CLIUI.Instance().WriteInput($"The Moon Phase of {targetPhase} is {results} many days from now ");
        }

        private int FindMoon(MoonFakeDatabase database, Moon currentMoon, Phase targetPhase)
        {
           
      
            foreach (int key in database.Entities.Keys)
            {
                
                if (database.PeakMoon(key).MoonPhases == targetPhase)
                {
                    int year = CountDaysAfterYears(database.PeakMoon(key).MoonDate, currentMoon.MoonDate);
                    int month = CountDaysAfterMonths(database.PeakMoon(key).MoonDate, currentMoon.MoonDate); ;
                    int day = CountDaysAfterDays(database.PeakMoon(key).MoonDate, currentMoon.MoonDate);

                  
                    return year + month + day;

                }
            }
            return 0;
        }
    }
}

