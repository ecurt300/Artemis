using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis;
using Microsoft.Extensions.DependencyInjection;
using Moon_Phase_App.Data;
using Moon_Phase_App.Domain;
using MoonData.Domain;
using static System.Net.Mime.MediaTypeNames;
namespace Artemis.Logic
{
    public class MoonLogic
    {
      
        //Add Moons To Database on Run
       
        public void InitializeDatabase(Application application)
        {
            //Start from 1700 to 2100 (400 years)
           
           
            var years = 400;
            var moonService = application.Services.GetService<IMoonService>();
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
            var moons = moonService?.LoopThroughYears(years);
            if (moons != null)
            {
                foreach (Moon moon in moons)
                {
                    moonPhaseRepository?.AddMoon(moon);
                }
            }
        }

        //Enter the Date find the next full moon from that entered date display how many days left until that fullmoon-> Make this async

        public void CalculateMoon(Application application,string day,string month,string year)
        {
            int dayCount = 0;
            string fullMoon = "Full Moon";
            DateTime currentDate = new DateTime(int.Parse(year),int.Parse(month),int.Parse(year));
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
            int counter = moonPhaseRepository.GetMoonByDate(currentDate);
            int moonCount = moonPhaseRepository.GetAll().ToArray<Moon>().Length;
            bool found = false;
            Moon? target = null;
            while (counter <= moonCount || found)
            {
                target = moonPhaseRepository.GeMoonByID(counter);
                found = target.Phase == fullMoon;
                counter++;
            }
            //Count up the number of days until the next fullmoon 
            if (target != null) {

                DateTime targetDate = new DateTime(int.Parse(target.Year), int.Parse(target.Month), int.Parse(target.Day));

                dayCount = Math.Abs( targetDate.Subtract(currentDate).Days);
            }
            Console.WriteLine($"There are {dayCount} days until the next full moon from today.");
        }
        //On the UI(Mud Blazor) the user enters this into a text box that is read into a string then fed into the query

        //Remove all moons from Database on exit
        public void ClearDataBase(Application application)
        {
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
            for(int i = 0;i < moonPhaseRepository.GetAll().Count();i++)
            {
                moonPhaseRepository?.DeleteMoon(i);
            }
        }
        
    }
}
