using MoonData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Phase_App.Domain
{
    public interface IMoonService
    {

        public Task<IEnumerable<Moon>> GetMoonData(int year);
        public IEnumerable<Moon> LoopThroughYears(int numOfYears);
    }
}
