using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareTracker.Core
{
   
    public class DogCanPalyInYardVerifier : PalyInYardVerifier
    {
        public bool DogIsVerifiedToPlayInYard(Dog dog)
        {                       
            if (dog.HasAlreadyBeenVerified)
            {
                return true;
            }

            if(dog.Weight <= 150)
            {
                return true;
            }

            return false;
        }
        
        public bool DogIsVerifiedToPlayInYardByID(int dogId)
        {
            var dog = _dogFactory.GetDog(dogId);

            if (dog.HasAlreadyBeenVerified)
            {
                return true;
            }

            if (dog.Weight <= 150)
            {
                return true;
            }

            return false;
        }
    }
}
