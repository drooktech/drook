using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogDaycareTracker.Web.Models
{
    public class NewDog
    {
        public NewDog()
        {

        }

        public string DogName { get; set;}
        public string DogAge { get; set; }
        public string DogWeight { get; set; }
        public string WasAdded { get; set; }        
    }
}