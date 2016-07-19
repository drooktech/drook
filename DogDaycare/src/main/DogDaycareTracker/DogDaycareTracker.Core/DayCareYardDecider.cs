using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareTracker.Core
{
    public class DayCareYardDecider
    {
        public IDogSizeDecider _dogDecider;
        public IDog _dog;

        public DayCareYardDecider(IDog dog, IDogSizeDecider dogSizeDecider)
        {
            _dog = dog;
            _dogDecider = dogSizeDecider;
        }

        public DogYard WhichYardCanDogPlayIn()
        {
            int dogWeight = _dog.Weight;

            if(dogWeight <= 0)
            {
                return DogYard.NoYardAvailable;
            }

            DogSize dogSize = _dogDecider.DecideTheDogSzie(dogWeight);

            switch(dogSize)
            {
                case DogSize.Tiny:
                case DogSize.Small:
                    return DogYard.SmallYard;
                case DogSize.Medium:
                case DogSize.Large:
                    return DogYard.LargeYard;
                case DogSize.SuperLarge:
                    return DogYard.NoYardAvailable;
                default:
                    return DogYard.NoYardAvailable;
            }
        }       
    }
}
