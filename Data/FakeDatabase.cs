using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Moon_Phase_App;
using Moon_Phase_App.Domain;
namespace Moon_Phase_App.Data
{

    /*
     * This stores the entities in a "Database" a dictionary to test and sort the moon data and test the business logic.
     * 
     */
    class FakeDatabase
    {
        private SortedDictionary<Phases, Phase>? MoonPhases;

        //private SortedDictionary<Phases, Results>? SearchResults;

        //Add some semblence to database structure. Like Add and remove update(CRUD) for blocking out the logic.
        //Needs to be generic! There is repeatable code so it will be generic and needs to be generic even for the regular Database
        public void AddPhaseToMoonPhases(Phase phase)
        {

            Phase? phaseToCheck = new Phase();
            if (!MoonPhases.TryGetValue(phase.phases, out phaseToCheck))
            {
                MoonPhases.Add(phase.phases, phase);
            }
        }

        public void UpdateMoonPhase(Phase phaseToAdd)
        {
            Phase? phaseToCheck = new Phase();
            if (MoonPhases.TryGetValue(phaseToAdd.phases, out phaseToCheck))
            {
                MoonPhases[phaseToAdd.phases] = phaseToAdd;

            }
        }
        public void RemovePhaseFromMoonPhases(Phase phase)
        {

            {
                Phase? phaseToCheck = new Phase();
                if (MoonPhases.TryGetValue(phase.phases, out phaseToCheck))
                {
                    MoonPhases.Remove(phase.phases,out phaseToCheck);
                }

            }


        }
        public FakeDatabase()
        {
            MoonPhases = new SortedDictionary<Phases, Phase>();
        }
    }
}
