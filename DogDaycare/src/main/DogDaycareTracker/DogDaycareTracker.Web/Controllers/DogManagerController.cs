using DogDaycareTracker.Core;
using DogDaycareTracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogDaycareTracker.Web.Controllers
{
    public class DogManagerController : Controller
    {
        // GET: DogManager
        public ActionResult Index()
        {
            NewDog newDog = new NewDog();
            //newDog.DogName = "DaveDidIt";
            return View(newDog);
        }

        [HttpPost]
        public ActionResult Index(NewDog newDog)
        {
            NewDog theNewDog = new NewDog();
            theNewDog.DogName = newDog.DogName;
            theNewDog.DogWeight = newDog.DogWeight;
            theNewDog.DogAge = newDog.DogAge;
            theNewDog.WasAdded = "Dog was Added";

            IDogSizeDecider dogSizeDecider = new DogSizeDecider();
            var dogSize = dogSizeDecider.DecideTheDogSzie(Convert.ToInt32(theNewDog.DogWeight));
            if (dogSize == DogSize.Tiny)
            {
                return View("DogNotAdded", theNewDog);
            }


            return View("DogAdded", theNewDog);
        }
    }
}