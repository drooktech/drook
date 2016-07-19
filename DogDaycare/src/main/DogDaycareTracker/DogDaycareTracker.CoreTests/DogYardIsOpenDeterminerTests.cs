using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogDaycareTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.QualityTools.Testing.Fakes;
using System.Fakes;

namespace DogDaycareTracker.Core.Tests
{
    [TestClass()]
    public class DogYardIsOpenDeterminerTests
    {
        [TestMethod()]
        [TestCategory("Shims")]
        [Ignore]
        public void IsDogYardOpenTest_NoShims_ExceptionOnHolidays()
        {
            //Arrange 
            DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

            //Act
            var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

            //Asert
            Assert.AreEqual(isDogYardOpen, true);
        }

        [TestMethod()]
        [TestCategory("Shims")]
        [Ignore]
        public void IsDogYardOpenTest_Shims_TodayIsAHolidays()
        {
            using (ShimsContext.Create())
            {
                //Arrange 
                Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return false; };
                DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

                //Act
                var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

                //Asert
                Assert.AreEqual(isDogYardOpen, true);
            }
        }



















        //[TestMethod()]
        //[TestCategory("Shims")]
        //public void IsDogYardOpenTest_Shims_TodayIsAHoliday_ResultIsFalse()
        //{
        //    using (ShimsContext.Create())
        //    {
        //        //Arrange
        //        Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return true; };

        //        DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

        //        //Act
        //        var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

        //        //Asert
        //        Assert.AreEqual(isDogYardOpen, false);
        //    }
        //}

        [TestMethod()]
        [TestCategory("Shims")]
        public void IsDogYardOpenTest_ShimHoliday_ShimYardCont_ResultIsFalse()
        {
            using (ShimsContext.Create())
            {
                //Arrange
                Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return false; };

                Fakes.ShimDogYardComtaminated.AllInstances.IsDogYardComtaminated = (DogYardComtaminated) => true;

                DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

                //Act
                var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

                //Asert
                Assert.AreEqual(isDogYardOpen, false);
            }
        }

        [TestMethod()]
        [TestCategory("Shims")]
        public void IsDogYardOpenTest_ShimHoliday_ShimYardCont_ShimDates_ItsSunday_ResultIsFalse()
        {
            using (ShimsContext.Create())
            {
                DateTime sunday = new DateTime(2016, 3, 20);

                Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return false; };
                DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

                Fakes.ShimDogYardComtaminated.AllInstances.IsDogYardComtaminated = (DogYardComtaminated) => false;


                ShimDateTime.TodayGet = () => sunday;

                var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

                Assert.AreEqual(isDogYardOpen, false, "It's Sunday, Yard should be closed");
            }
        }

        [TestMethod()]
        [TestCategory("Shims")]
        public void IsDogYardOpenTest_ShimHoliday_ShimYardCont_ShimDates_ItsSaturday_5am_ResultIsFalse()
        {
            using (ShimsContext.Create())
            {
                DateTime saturdayAt5am = new DateTime(2016, 3, 19, 5, 0, 0);

                Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return false; };
                DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

                Fakes.ShimDogYardComtaminated.AllInstances.IsDogYardComtaminated = (DogYardComtaminated) => false;

                ShimDateTime.TodayGet = () => saturdayAt5am;
                ShimDateTime.NowGet = () => saturdayAt5am;

                var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

                Assert.AreEqual(isDogYardOpen, false, "It's Saturday at 5am, Yard should be closed");
            }
        }

        //[TestMethod()]
        //public void IsDogYardOpenTest_ShimHoliday_ShimYardCont_ShimDates_ItsSaturday_501pm_ResultIsFalse()
        //{
        //    using (ShimsContext.Create())
        //    {
        //        DateTime saturdayAt501pm = new DateTime(2016, 3, 19, 17, 0, 1);

        //        Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return false; };
        //        DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

        //        Fakes.ShimDogYardComtaminated.AllInstances.IsDogYardComtaminated = (DogYardComtaminated) => false;

        //        ShimDateTime.TodayGet = () => saturdayAt501pm;
        //        ShimDateTime.NowGet = () => saturdayAt501pm;

        //        var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

        //        Assert.AreEqual(isDogYardOpen, false, "It's Saturday at 5:01pm, Yard should be closed");
        //    }
        //}

        //[TestMethod()]
        //public void IsDogYardOpenTest_ShimHoliday_ShimYardCont_ShimDates_ItsSaturday_6am_ResultIsTrue()
        //{
        //    using (ShimsContext.Create())
        //    {
        //        DateTime saturdayAt6am = new DateTime(2016, 3, 19, 6, 0, 0);

        //        Fakes.ShimHolidays.IsTodayADogDayCareHoliday = () => { return false; };
        //        DogYardIsOpenDeterminer dogYardIsOpen = new DogYardIsOpenDeterminer();

        //        Fakes.ShimDogYardComtaminated.AllInstances.IsDogYardComtaminated = (DogYardComtaminated) => false;

        //        ShimDateTime.TodayGet = () => saturdayAt6am;
        //        ShimDateTime.NowGet = () => saturdayAt6am;

        //        var isDogYardOpen = dogYardIsOpen.IsDogYardOpen();

        //        Assert.AreEqual(isDogYardOpen, true, "It's Saturday at 6am, Yard should be open");
        //    }
        //}
    }
}