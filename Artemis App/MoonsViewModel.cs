using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis;
using MoonData;
using MoonData.Domain;
using Utilities;
using Moon_Phase_App.Data;
using Microsoft.Extensions.DependencyInjection;
using Moon_Phase_App.Domain;
using Artemis.Logic;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Artemis_App
{

    /*
   public class ValidateDate
   {
       public string Month;
       public string Month;
       public string Year;

   }
    */

   public partial  class MoonsViewModel : ObservableObject
   {
        public MoonLogic moonLogic { get;set; }

        public string DateInput {  get; set; }

        public string DateToInputFromInputDay { get; set; }
        public string DateToInputFromInputYear { get; set; }

        public string DateToInputFromInputMonth { get; set; }

   
        public string Answer { get; set; }


       //Lazy Cheap String Validation for ValidateDate
        /*
       public bool Validate(int day,int month,int year)
       {


           if(day < 31 && month < 12 && year < 2101)
           {
               return true;
           }

           return false;
       }
        */
    //Calculate Moon ValidateDate using MoonLogic with input from UI
    public void CalculateMoons(Application app)
        {
            if (DateInput != null)
            {
             
                Answer = moonLogic.CalculateMoon(app, int.Parse(DateToInputFromInputYear), int.Parse(DateToInputFromInputMonth), int.Parse(DateToInputFromInputDay));

            }/*
             * try validation later
            if (Validate(month, year, day))
            {
               

             
            }
            */
        }


        public MoonsViewModel()
        {
          
            moonLogic = new MoonLogic();
        }



    }
}
