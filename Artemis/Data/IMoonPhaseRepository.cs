using MoonData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Phase_App.Data
{
    public interface IMoonPhaseRepository 
    {
        public Moon GeMoonByID(int id);
        public Moon GetMoonByDate(DateTime date);
        public void AddMoon(Moon moon);
        public void UpdateMoon(Moon moon);
        public void DeleteMoon(int id);
        public IEnumerable<Moon> GetAll();
    }
}








