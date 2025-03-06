using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonData.Domain;
using Newtonsoft.Json;
namespace Moon_Phase_App.Data
{
    public class MoonList
    {
        [JsonProperty("phasedata")]
        public IEnumerable<Moon>? moons = new List<Moon>();
    
    }
}
