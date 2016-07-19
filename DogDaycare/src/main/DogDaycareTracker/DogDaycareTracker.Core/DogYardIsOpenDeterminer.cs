using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareTracker.Core
{
    public class DogYardIsOpenDeterminer
    {
        public bool IsDogYardOpen()
        {
            //call to a custom legacy static method we can't change to interface due to business value
            if(Holidays.IsTodayADogDayCareHoliday())
            {
                return false;
            }

            //call to a legacy direct interal class
            DogYardComtaminated dogYardComtaminated = new DogYardComtaminated();
            if (dogYardComtaminated.IsDogYardComtaminated())
            {
                return false;
            }

            //calls to System.DateTime
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            //calls to System.DateTime
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                DateTime todayAt6am = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
                DateTime todayAt5pm = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
                if (DateTime.Now < todayAt6am || DateTime.Now > todayAt5pm)
                {
                    return false;
                }

                return true;
            }

            //calls to System.DateTime
            DateTime todayAt5am = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
            DateTime todayAt9pm = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);

            //calls to System.DateTime
            if (DateTime.Now < todayAt5am || DateTime.Now > todayAt9pm)
            {
                return false;
            }
            
            return true;
        }
    }
}
