using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareTracker.Core
{
    public class DogSizeDecider : IDogSizeDecider
    {
        public DogSize DecideTheDogSzie(int theDogSize)
        {
            DogSize dogSize = DogSize.NoSize;

            if (theDogSize >= 0 && theDogSize < 10)
            {
                dogSize = DogSize.Tiny;
            }
            else if (theDogSize >= 10 && theDogSize < 40)
            {
                dogSize = DogSize.Small;
            }
            else if (theDogSize >= 40 && theDogSize < 70)
            {
                dogSize = DogSize.Medium;
            }
            else if (theDogSize >= 70 && theDogSize < 90)
            {
                dogSize = DogSize.Large;
            }
            else if (theDogSize >= 90)
            {
                dogSize = DogSize.SuperLarge;
            }
            else if (theDogSize >= 1000)
            {
                dogSize = DogSize.SuperLarge;
            }

            return dogSize;
        }
    }   
}


    
