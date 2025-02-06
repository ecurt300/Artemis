using Moon_Phase_App.Domain;
using System.Xml.Linq;

namespace MoonData.Domain
{

    public enum Phase
    {
        NewMoon,
        WaxingCrescent,
        FirstQuarter,
        WaxingGibbous,
        FullMoon,
        WaningGibbous,
        ThirdQuarter,
        WaningCrescent,

        WolfMoon,
        SnowMoon,
        WormMoon,
        PinkMoon,
        BuckMoon,
        ColdMoon

    }

    public class Moon : EntityBase
    {
     

        public Phase MoonPhases { get; set; }

        public Date MoonDate { get; set; }

        public Moon(Phase phases, Date moonDate,int id)
        {
            this.MoonPhases = phases;
            MoonDate = moonDate;
            this.Id = id;
        }

        public Moon()
        {

        }
        public override string ToString()
        {
            return $"{MoonPhases} MoonPhase/{MoonDate} Date";
        }
    }
}
