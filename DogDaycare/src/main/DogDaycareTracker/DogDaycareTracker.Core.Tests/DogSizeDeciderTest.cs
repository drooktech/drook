// <copyright file="DogSizeDeciderTest.cs">Copyright ©  2016</copyright>

using System;
using DogDaycareTracker.Core;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DogDaycareTracker.Core.Tests
{
    [TestClass]
    [PexClass(typeof(DogSizeDecider))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DogSizeDeciderTest
    {

        [PexMethod]
        public DogSize DecideTheDogSzie([PexAssumeUnderTest]DogSizeDecider target, int theDogSize)
        {
            DogSize result = target.DecideTheDogSzie(theDogSize);
            return result;
            // TODO: add assertions to method DogSizeDeciderTest.DecideTheDogSzie(DogSizeDecider, Int32)
        }
    }
}
