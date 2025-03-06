using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
using Moon_Phase_App.Domain;
using Moon_Phase_App.Data;
namespace Artemis
{
    public class Application
    {
        public IServiceProvider Services { get; set; }

        public Application(IServiceCollection serviceCollection)
        {
            ConfigureServices(serviceCollection);
            Services = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMoonService,MoonsService>();
            serviceCollection.AddTransient<IMoonPhaseRepository, MoonPhaseRepository>();
        }

    }
}
