using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Moon_Phase_App.Domain;
using MoonData;
using MoonData.Domain;
namespace MoonData.Data
{

    /*
     * This stores the entities in a "Database" a dictionary to test and sort the moon data and test the business logic.
     * 
     */
    public class FakeDatabase<T> where T : EntityBase
    {
       public SortedDictionary<int, EntityBase>? Entities;

        //private SortedDictionary<Phase, Results>? SearchResults;

        //Add some semblence to database structure. Like Add and remove update(CRUD) for blocking out the logic.
        //Needs to be generic! There is repeatable code so it will be generic and needs to be generic even for the regular Database
        public void AddToFakeDatabase(T entity)
        {

            EntityBase? EntityToCheck = new EntityBase();
            if (!Entities.TryGetValue(entity.Id, out EntityToCheck))
            {
                Entities.Add(entity.Id,entity);
            }
        }

        
        public void RemoveFromFakeDatabase(T entity)
        {

            {
                EntityBase? EntityToCheck = new EntityBase();
                if (Entities.TryGetValue(entity.Id, out EntityToCheck))
                {
                    Entities.Remove(entity.Id, out EntityToCheck);
                }

            }


        }
        public FakeDatabase()
        {
            Entities  = new SortedDictionary<int,EntityBase>();
        }
    }
}
