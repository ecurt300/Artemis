using System.Xml.Linq;

namespace Moon_Phase_App.Domain
{

    public enum Phases
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

    public class Phase
    {
     

        public Phases phases { get; set; }

        public Phase(Phases phases)
        {
            this.phases = phases;
        }

        public Phase()
        {

        }

    }
}
