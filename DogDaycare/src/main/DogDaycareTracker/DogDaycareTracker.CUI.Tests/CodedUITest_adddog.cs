using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace DogDaycareTracker.CUI.Tests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest_adddog
    {
        public CodedUITest_adddog()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.TestCase", "https://drook.visualstudio.com/;DogDaycare", "79", DataAccessMethod.Sequential)]
        [TestMethod]
        public void AddNewDogTestMethod_AddSuccessful()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Navigatetopage();
            this.UIMap.DogNamedognameParams.UIDogNameEditText = TestContext.DataRow["dogname"].ToString();
            this.UIMap.DogNamedogname();
            this.UIMap.EnterweightweightParams.UIDogWeightEditText = TestContext.DataRow["weight"].ToString();
            this.UIMap.Enterweightweight();
            this.UIMap.EnterageageParams.UIDogAgeEditText = TestContext.DataRow["age"].ToString();
            this.UIMap.Enterageage();
            this.UIMap.Clickadddog();
            this.UIMap.DogWasAdded();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
