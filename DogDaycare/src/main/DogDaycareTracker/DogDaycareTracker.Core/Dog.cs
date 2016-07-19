using System;

namespace DogDaycareTracker.Core
{
    public class Dog : IDog
    {
        private int dogId;

        public Dog(int dogId)
        {
            this.dogId = dogId;            
        }

        public bool HasAlreadyBeenVerified { get; set; }

        public int Weight
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}