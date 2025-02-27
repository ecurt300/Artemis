
using Artemis;
using MoonData;
using System.Linq;
using MoonData.Domain;
using Utilities;
using Moon_Phase_App.Data;
using Microsoft.Extensions.DependencyInjection;
using Moon_Phase_App.Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        bool canQuite = false;

        /*
        * Quick Values such for some nonsense dates for testing
        * I am going to grab all moon data from the database then put it into a sorted dictionary and conduct the query using that dictionary.
        * Some cleaning of the code needs to be involved. I need to rename fake database to moonData. moonData grabs the data from the moon data and adds it to
        * the moon sorted dictionary then lets you do the moon query
        * 
        * Minor Steps:
        *    Reorganize fakeDatabase to MoonData 
        *    Fill the Database with Moons from the U.S. Naval Observatory and parse them to fit the structure
        *    Make a basic Console UI to running the functionalities of the app as defined in the Design Doc on Github.
        *    After this is replace console UI with mudblazor App-Yikes
        */







        MoonContext context = new MoonContext();


        using var moonDB = new MoonContext();
  

        // Console.WriteLine(moonFakeDatabase.ToString());
        var services = new ServiceCollection();
        Application application = new Application(services);
        var moonService = application.Services.GetRequiredService<IMoonService>();
        //Loop through all moons from 1700 to 2100 this is 400 years
        //var moons = moonService.LoopThroughYears(400);

   
        
  
        while (true)
        {
            foreach (var moon in moonDB.moons)
            {
               
                Console.WriteLine(moon.ToString());
            }

            Console.ReadKey();

        }
    }
}