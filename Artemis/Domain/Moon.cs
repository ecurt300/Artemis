using Moon_Phase_App.Domain;
using System.Xml.Linq;
using Newtonsoft;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace MoonData.Domain
{

   
    [Serializable]
    [PrimaryKey(nameof(ID))]
    
    public class Moon
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
        [JsonProperty("year")]
       
        public string? Year { get; set; }

        [JsonProperty("month")]
       
        public string? Month { get; set; }

        [JsonProperty("phase")]
        public string? Phase { get; set; }

        [JsonProperty("day")]
       
        public string? Day { get; set; }

        public Moon(int ID, string Year, string Month, string Day,string phase)
        {
            this.ID = ID;
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Phase = phase;
        }
        public override string ToString()
        {
            return $"Year {Year}/Month {Month}/Phase {Phase}/Day {Day}";
        }
    }
}
