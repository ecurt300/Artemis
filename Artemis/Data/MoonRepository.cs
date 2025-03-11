using Moon_Phase_App.Data;
using Moon_Phase_App.Domain;

using MoonData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemis
{
    
   public class MoonPhaseRepository : IMoonPhaseRepository
    {


        private readonly MoonContext moonContext = new MoonContext();
        /*
       public MoonPhaseRepository(MoonContext moonContext)
       {
            this.moonContext = moonContext;
       }
       */
        public void AddMoon(Moon moon)
        {
            if (!moonContext.Set<Moon>().Contains(moon))
            {
                moonContext.Add(moon);
                moonContext.SaveChanges();
            }
           
        }

        public void DeleteMoon(int id)
        {
            var moonTodelete = (from moon in moonContext.Set<Moon>() where moon.ID == id select moon).First();
         
            if (moonTodelete != null)
            {
                moonContext.Set<Moon>().Remove(moonTodelete);
                
            }
            moonContext.SaveChanges();
        }

        public Moon? GeMoonByID(int id)
        {
            return (from moon in moonContext.Set<Moon>() where moon.ID == id select moon).First();
        }

        public IEnumerable<Moon> GetAll()
        {
            return moonContext.Set<Moon>().ToList();
        }

        public Moon GetMoonByDate(DateTime date)
        {
            string? day = $"{date.Date.Day}";
            string? month = $"{date.Date.Month}";
            string? year = $"{date.Date.Year}";

            var moonQuery = (from moon in moonContext.Set<Moon>() where moon.Year == year where moon.Month == month where moon.Year == year select new { moon }  );
            

            return moonQuery.First().moon;
        }

        public void UpdateMoon(Moon moon)
        {
            moonContext.Set<Moon>().Update(moon);
            moonContext.SaveChanges();
        }

    
    }
}
