using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis;
using Microsoft.Extensions.DependencyInjection;
using Moon_Phase_App.Domain;
using MoonData.Domain;
namespace Artemis.Logic
{
    public class MoonLogic
    {
        public  Application application;
        
        public void AddMoonToDbSet(int ID, string Year, string Month, string Day, string phase)
        {
            Moon moon = new Moon(ID,Year,Month,Day,phase);
          
            var moonService = application.Services.GetRequiredService<IMoonService>();
            

        }

        public MoonLogic() 
        {

            var services = new ServiceCollection();
            application = new Application(services);
            

        }
    
    
    }
}
