using Moon_Phase_App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonData.Domain
{
    public class Results : EntityBase
    {
        public string UserName { get; set; }

        public Moon moonPhase { get; set; }

        public Date moonDate { get; set; }



        public Results(Moon moonPhase, Date Date, string userName,int id)
        {
            this.moonPhase = moonPhase;
            UserName = userName;
            moonDate = Date;
            this.Id = id;
        }

        public override string ToString()
        {
            return $" Name of User {UserName}/ Phase of Moon: {moonPhase}/Date of Moon Result {moonDate}";
        }

    }
}
