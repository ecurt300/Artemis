using Moon_Phase_App.Data;
using MoonData.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Phase_App.Domain
{
    
    public class MoonsService : IMoonService
    {
       
        public async Task<IEnumerable<Moon>> GetMoonData(int year)
        {
            
            List<Moon> moons = new List<Moon>();
            int yearToQuery = int.Parse(year.ToString());
            var url = $"https://aa.usno.navy.mil/api/moon/phases/year?year={yearToQuery}";
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    var phaseList = JsonConvert.DeserializeObject<MoonList>(jsonString);

                    if (phaseList != null)
                    {
                        moons.AddRange(phaseList.moons);
                        
                    }
                   

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return moons;
        }

      

        public IEnumerable<Moon> LoopThroughYears(int numOfYears)
        {
            int currentMoonIndex = 0;
            double moonPercentage = 0;
            List<Moon> ListOFMoonList = new List<Moon>();
            for (int i = 0; i < numOfYears; i++)
            {
              
                ListOFMoonList.AddRange(GetMoonData(1700 + i).Result);
                currentMoonIndex++;
                moonPercentage = ((double)currentMoonIndex / (double)numOfYears) * 100;
                Console.WriteLine(moonPercentage);
            }
         
            return ListOFMoonList;
        }
    }
    

}
