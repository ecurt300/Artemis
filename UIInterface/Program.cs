// See https://aka.ms/new-console-template for more information
using Artemis;
using MoonData.Data;
using MoonData.Domain;
using Utilities;
using MoonSearch;
bool canQuite = false;
MoonFakeDatabase moonFakeDatabase = new MoonFakeDatabase();
   /*
   * Quick Values such for some nonsense dates for testing
   * 
   */
moonFakeDatabase.AddToFakeDatabase(new Moon(Phase.WolfMoon, new Date(27, 10, 1948, 1), 0));
moonFakeDatabase.AddToFakeDatabase(new Moon(Phase.WormMoon, new Date(27, 10, 1999, 2), 1));
moonFakeDatabase.AddToFakeDatabase(new Moon(Phase.BuckMoon, new Date(27, 10, 2000, 3), 2));
while (!canQuite)
{
    MoonQuery.Instance().FindMoonAndDisplayResults(moonFakeDatabase,new Moon(Phase.WormMoon,new Date(27,10,1999,2),1),Phase.BuckMoon);
   
    CLIUI.Instance().WriteInput("Hello Artemis");
    CLIUI.Instance().WriteInput("Press 1 to quite");
    
   // Console.WriteLine(moonFakeDatabase.ToString());

   
    canQuite = CLIUI.Instance().ContextChoose();
    
    
  
    
}

