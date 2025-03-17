using static System.Net.Mime.MediaTypeNames;
using Artemis;
using MoonData;
using System.Linq;
using MoonData.Domain;
using Moon_Phase_App.Data;

using Moon_Phase_App.Domain;
using Artemis.Logic;
namespace ArtemisBlazorApp.Components.Pages
{
    public partial class Home
    {
        public static void Main(string[] args)
        {

            IServiceCollection services = new ServiceCollection();
            Artemis.Application application = new Artemis.Application(services);
            MoonLogic moonLogic = new MoonLogic();
            moonLogic.InitializeDatabase(application);
            bool update = true;
            while (update)
            {


                update = !moonLogic.CalculateMoon(application, 22, 8, 1700);

            }
            
            moonLogic.ClearDataBase(application);


        }



    }
}
