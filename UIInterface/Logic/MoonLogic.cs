using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        bool found = false;
        bool databaseFull = false;
        public double progress { get; set; }
        
        public void InitializeDatabase(Application application)
        {
            //Start from 1700 to 2100 (400 * 2 years)

            var id = 0;
            var years = 1;
            var moonService = application.Services.GetService<IMoonService>();
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
            var moons = moonService?.LoopThroughYears(years);
            
            
            if (moons != null && !databaseFull)
            {
                foreach (Moon moon in moons)
                {
                    
                    id++;
                    moon.ID = id;
                    moonPhaseRepository?.AddMoon(moon);
                }
               
            }
            databaseFull = moons.ToList().Count == years * 2;
            progress = moonService.moonProgress;
        }

        //Enter the Date find the next full moon from that entered date display how many days left until that fullmoon-> Make this async

        public bool CalculateMoon(Application application, int day, int month, int year)
        {
            int dayCount = 0;
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
            
            string fullMoon = "Full Moon";
            Moon? target = null;
            
            DateTime currentDate = new DateTime((year), (month), (day));
           
            Moon currentMoon = moonPhaseRepository.GetMoonByDate(currentDate);

            int counter = currentMoon.ID;

            int moonCount = moonPhaseRepository.GetAll().ToArray<Moon>().Length;
            

            

            while (counter < moonCount)
            {
                     target = moonPhaseRepository.GeMoonByID(counter);

               

                    counter++;
                    found = target.Phase == "Full Moon";
                    Console.WriteLine( "counter" + counter);
                    if (found)
                    {
                        break;
                    }
                   
                 

                
            }

            //Count up the number of days until the next fullmoon 
            if (target != null)
            {


                DateTime targetDate = new DateTime(int.Parse(target.Year), int.Parse(target.Month), int.Parse(target.Day));

              

                    Console.WriteLine(target.ToString());
                    dayCount = (targetDate.Subtract(currentDate).Days);
                    Console.WriteLine($"There are {dayCount} days until the next full moon from today.");
                    return true;
            }
            
               
            
 
               
                return false;
        }
        //On the UI(Mud Blazor) the user enters this into a text box that is read into a string then fed into the query

        //Remove all moons from Database on exit
        public void ClearDataBase(Application application)
        {
            var moonPhaseRepository = application.Services.GetService<IMoonPhaseRepository>();
           
            foreach( Moon moon in moonPhaseRepository.GetAll().ToList())
            {
                moonPhaseRepository.DeleteMoon(moon.ID);
            }
        }
        
    }
}
