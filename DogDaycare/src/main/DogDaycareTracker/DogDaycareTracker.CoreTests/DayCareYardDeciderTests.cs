using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace DogDaycareTracker.Core.Tests
{
    [TestClass()]
    public class DayCareYardDeciderTests
    {
        [TestMethod()]
        [TestCategory("Regular")]
        public void WhichYardCanDogPlayInTest_IntegrationTest_DogIsSmall_ReturnTrue()
        {
            //Arrange
            int weightOfDog = 20;

            //Create concrete objects of the Dog 
            IDog dog = new Dog(weightOfDog);

            //Create concrete objects of the DogSizeDecider
            IDogSizeDecider dogSizeDogDecider = new DogSizeDecider();

            //Instantiate the object to be tested with the associated concrete interdependencies     
            DayCareYardDecider dayCareYardDecider = new DayCareYardDecider(dog, dogSizeDogDecider);

            //Act
            DogYard dogYard = dayCareYardDecider.WhichYardCanDogPlayIn();

            //Assert
            Assert.AreEqual(DogYard.SmallYard, dogYard, "The dog yard size does not match");
        }











        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        [TestCategory("Regular")]
        public void WhichYardCanDogPlayInTest_ConcreteObjects_DogIsSmall_CatchException()
        {
            //Arrange
            int weightOfDog = 20;

            //Create concrete objects of the Dog 
            IDog dog = new Dog(weightOfDog);

            //Create concrete objects of the DogSizeDecider
            IDogSizeDecider dogSizeDogDecider = new DogSizeDecider();

            //Instantiate the object to be tested with the associated concrete interdependencies     
            DayCareYardDecider dayCareYardDecider = new DayCareYardDecider(dog, dogSizeDogDecider);

            //Act
            DogYard dogYard = dayCareYardDecider.WhichYardCanDogPlayIn();

            //Assert
            Assert.AreEqual(DogYard.SmallYard, dogYard, "The dog yard size does not match");
        }
    }
}