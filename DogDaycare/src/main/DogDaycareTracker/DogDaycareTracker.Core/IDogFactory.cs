using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareTracker.Core
{
    public interface IDogFactory
    {
        IDog GetDog(int dogId);
    }
}
