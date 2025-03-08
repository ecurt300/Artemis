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

            var id = 0;
            var years = 5;
            var moonService = application.Services.GetService<IMoonService>();
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
            var moons = moonService?.LoopThroughYears(years);
            Console.WriteLine(moons.ToArray().Length);
            if (moons != null)
            {
                foreach (Moon moon in moons)
                {
                    
                    id++;
                    moon.ID = id;
                    moonPhaseRepository?.AddMoon(moon);
                }
            }
        }

        //Enter the Date find the next full moon from that entered date display how many days left until that fullmoon-> Make this async

        public void CalculateMoon(Application application, int day, int month, int year)
        {
            int dayCount = 0;
            string fullMoon = "Full Moon";
            Moon? target = null;
            DateTime currentDate = new DateTime((year), (month), (day));
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
           
                int counter = moonPhaseRepository.GetMoonByDate(currentDate).ID;
             
                int moonCount = moonPhaseRepository.GetAll().ToArray<Moon>().Length;
                bool found = false;
              
               

                while (counter <= moonCount || found)
                {
                    target = moonPhaseRepository.GeMoonByID(counter);

                    found = target.Phase == fullMoon;
                    
                counter++;
                if (counter == moonCount)
                {
                    break;
                }
                  
                }

                //Count up the number of days until the next fullmoon 
                if (target != null)
                {

                    DateTime targetDate = new DateTime(int.Parse(target.Year), int.Parse(target.Month), int.Parse(target.Day));

                    dayCount = Math.Abs(targetDate.Subtract(currentDate).Days);
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
