using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogDaycareTracker.Core;
// <copyright file="DogSizeDeciderTest.DecideTheDogSzie.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace DogDaycareTracker.Core.Tests
{
    public partial class DogSizeDeciderTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(DogSizeDeciderTest))]
        public void DecideTheDogSzie497()
        {
            DogSize i;
            DogSizeDecider s0 = new DogSizeDecider();
            i = this.DecideTheDogSzie(s0, 0);
            Assert.AreEqual<DogSize>(DogSize.Tiny, i);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(DogSizeDeciderTest))]
        public void DecideTheDogSzie802()
        {
            DogSize i;
            DogSizeDecider s0 = new DogSizeDecider();
            i = this.DecideTheDogSzie(s0, 10);
            Assert.AreEqual<DogSize>(DogSize.Small, i);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(DogSizeDeciderTest))]
        public void DecideTheDogSzie999()
        {
            DogSize i;
            DogSizeDecider s0 = new DogSizeDecider();
            i = this.DecideTheDogSzie(s0, 42);
            Assert.AreEqual<DogSize>(DogSize.Medium, i);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(DogSizeDeciderTest))]
        public void DecideTheDogSzie62()
        {
            DogSize i;
            DogSizeDecider s0 = new DogSizeDecider();
            i = this.DecideTheDogSzie(s0, 110);
            Assert.AreEqual<DogSize>(DogSize.SuperLarge, i);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(DogSizeDeciderTest))]
        public void DecideTheDogSzie129()
        {
            DogSize i;
            DogSizeDecider s0 = new DogSizeDecider();
            i = this.DecideTheDogSzie(s0, int.MinValue);
            Assert.AreEqual<DogSize>(DogSize.NoSize, i);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(DogSizeDeciderTest))]
        public void DecideTheDogSzie873()
        {
            DogSize i;
            DogSizeDecider s0 = new DogSizeDecider();
            i = this.DecideTheDogSzie(s0, 70);
            Assert.AreEqual<DogSize>(DogSize.Large, i);
            Assert.IsNotNull((object)s0);
        }
    }
}
