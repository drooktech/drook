using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogDaycareTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareTracker.Core.Tests
{
    [TestClass()]
    public class DayCareYardDeciderTestsStubs
    {
        [TestMethod()]
        [TestCategory("Stubs")]
        public void WhichYardCanDogPlayInTest_FakeTheWeight_DogIsSmall_ReturnTrue()
        {
            //Arrange
            int weightOfDog = 20;

            //Create STUB objects of the IDog
            var stubDog = new Fakes.StubIDog();

            //Inject the weight of the dog to round at the test
            stubDog.WeightGet = () => weightOfDog;

            //Create concrete IDogSizeDecider
            IDogSizeDecider dogSizeDogDecider = new DogSizeDecider();

            //Instantiate the object to be tested with the associated STUB interdependencies     
            DayCareYardDecider dayCareYardDecider = new DayCareYardDecider(stubDog, dogSizeDogDecider);

            //Act
            DogYard dogYard = dayCareYardDecider.WhichYardCanDogPlayIn();

            //Assert
            Assert.AreEqual(DogYard.SmallYard, dogYard, "The dog yard size does not match");
        }





















        [TestMethod()]
        [TestCategory("Stubs")]
        public void WhichYardCanDogPlayInTest_FakesWeightAndSize_DogIsSmall_ReturnTrue()
        {
            //Arrange
            int weightOfDog = 20;

            //Create STUB objects of the IDog
            var stubDog = new Fakes.StubIDog();

            //Inject the weight of the dog to round at the test
            stubDog.WeightGet = () => weightOfDog;

            //Create STUB IDogSizeDecider
            var dogSizeDogDecider = new Fakes.StubIDogSizeDecider();

            //Return the DogSize.Small instead of calling the actual method
            dogSizeDogDecider.DecideTheDogSzieInt32 = (theDogSize) => DogSize.Small;

            //Instantiate the object to be tested with the associated STUB interdependencies     
            DayCareYardDecider dayCareYardDecider = new DayCareYardDecider(stubDog, dogSizeDogDecider);

            //Act
            DogYard dogYard = dayCareYardDecider.WhichYardCanDogPlayIn();

            //Assert
            Assert.AreEqual(DogYard.SmallYard, dogYard, "The dog yard size does not match");
        }

        //[TestMethod()]
        //public void WhichYardCanDogPlayInTest_FakesTestWithStubs_DogIsMedium()
        //{
        //    var dogSizeDogDecider = new Fakes.StubIDogSizeDecider();
        //    dogSizeDogDecider.DecideTheDogSzieInt32 = (theDogSize) => DogSize.Medium;

        //    IDog stubDog = new Fakes.StubIDog();

        //    DayCareYardDecider dayCareYardDecider = new DayCareYardDecider(stubDog, dogSizeDogDecider);

        //    DogYard dogYard = dayCareYardDecider.WhichYardCanDogPlayIn();

        //    Assert.AreEqual(DogYard.LargeYard, dogYard);
        //}
    }
}