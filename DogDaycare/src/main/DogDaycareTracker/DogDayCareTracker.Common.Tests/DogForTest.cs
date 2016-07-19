using DogDaycareTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDayCareTracker.Common.Tests
{
    public class DogForTest : IDog
    {
        public bool HasAlreadyBeenVerified { get; set; }

        public int Weight { get; set; }
    }
}
