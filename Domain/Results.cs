using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Phase_App.Domain
{
    public class Results
    {
        public string UserName { get; set; }

        public Phase moonPhase { get; set; }

        public Date moonDate { get; set; }



        public Results(Phase moonPhase, Date Date, string userName)
        {
            this.moonPhase = moonPhase;
            UserName = userName;
            moonDate = Date;
        }

        public override string ToString()
        {
            return $" Name of User {UserName}/ Phase of Moon: {moonPhase}/Date of Moon Result {moonDate}";
        }

    }
}
