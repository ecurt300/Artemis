using Moon_Phase_App.Domain;
using MoonData.Data;
using MoonData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemis
{
    public class MoonFakeDatabase : FakeDatabase<Moon>
    {
    
        //A single update method

        public void UpdateFakeDatabase(Moon moon)
        {
            
            {
                EntityBase? EntityToCheck = new Moon();
                if (Entities.TryGetValue(moon.Id, out EntityToCheck))
                {
                    Entities.Remove(moon.Id, out EntityToCheck);
                }

            }
        }
        public override string ToString()
        {
           
            string moonData = "";

            foreach (int id in Entities.Keys)
            {
                moonData += $"{Entities[id].ToString()}\n";
            }
            return moonData;
        }

    }
}
