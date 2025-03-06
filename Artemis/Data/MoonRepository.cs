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
    
   public class MoonPhaseRepository :IMoonPhaseRepository
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
                moonContext.Set<Moon>().Add(moon);
                moonContext.SaveChanges();
            }
           
        }

        public void DeleteMoon(int id)
        {
            var moon = moonContext.Set<Moon>().Find(id);
            if (moon != null)
            {
                moonContext.Set<Moon>().Remove(moon);
                moonContext.SaveChanges();
            }
        }

        public Moon? GeMoonByID(int id)
        {
            return moonContext.Set<Moon>().Find(id);
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
            Moon moon = (Moon)moonContext.Set<Moon>().Where(m=> m.Day == day).Where(m=> m.Month == month).Where(m => m.Year == year).FirstOrDefault();
            return moon;
        }

        public void UpdateMoon(Moon moon)
        {
            moonContext.Set<Moon>().Update(moon);
            moonContext.SaveChanges();
        }

    
    }
}
