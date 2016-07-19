using DogDaycareTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogDaycareTracker.Core.Fakes;

namespace DogDayCareTracker.Common.Tests
{
    public class FakeDogFactory : IDogFactory
    {
        public IDog GetDog(int dogId)
        {
            StubIDog stubDob = new StubIDog();
            stubDob.HasAlreadyBeenVerifiedGet = () => { return true; };
            stubDob.WeightGet = () => 50;

            return stubDob;
        }






















    }
}
