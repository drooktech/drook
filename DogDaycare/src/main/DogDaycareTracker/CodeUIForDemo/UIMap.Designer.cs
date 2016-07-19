﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodeUIForDemo
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// AddDog
        /// </summary>
        public void AddDog()
        {
            #region Variable Declarations
            HtmlInputButton uIAddDogButton = this.UINewtabInternetExplorWindow.UIManageDogDogDaycareTDocument.UIAddDogButton;
            #endregion

            // Click 'Add Dog' button
            Mouse.Click(uIAddDogButton, new Point(62, 24));
        }
        
        /// <summary>
        /// AddNames - Use 'AddNamesParams' to pass parameters into this method.
        /// </summary>
        public void AddNames()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UINewtabInternetExplorWindow.UIItemWindow.UIItemEdit;
            BrowserWindow uINewtabInternetExplorWindow = this.UINewtabInternetExplorWindow;
            HtmlEdit uIDogNameEdit = this.UINewtabInternetExplorWindow.UIManageDogDogDaycareTDocument.UIDogNameEdit;
            HtmlEdit uIDogWeightEdit = this.UINewtabInternetExplorWindow.UIManageDogDogDaycareTDocument.UIDogWeightEdit;
            HtmlEdit uIDogAgeEdit = this.UINewtabInternetExplorWindow.UIManageDogDogDaycareTDocument.UIDogAgeEdit;
            #endregion

            // Go to web page 'about:Tabs' using new browser instance
            this.UINewtabInternetExplorWindow.LaunchUrl(new System.Uri(this.AddNamesParams.UINewtabInternetExplorWindowUrl));

            // Type 'd{Down}' in text box
            Keyboard.SendKeys(uIItemEdit, this.AddNamesParams.UIItemEditSendKeys, ModifierKeys.None);

            // Go to web page 'http://drookddc.azurewebsites.net/'
            uINewtabInternetExplorWindow.NavigateToUrl(new System.Uri(this.AddNamesParams.UINewtabInternetExplorWindowUrl1));

            // Type 'ruff' in 'DogName' text box
            uIDogNameEdit.Text = this.AddNamesParams.UIDogNameEditText;

            // Type '{Tab}' in 'DogName' text box
            Keyboard.SendKeys(uIDogNameEdit, this.AddNamesParams.UIDogNameEditSendKeys, ModifierKeys.None);

            // Type '100' in 'DogWeight' text box
            uIDogWeightEdit.Text = this.AddNamesParams.UIDogWeightEditText;

            // Type '{Tab}' in 'DogWeight' text box
            Keyboard.SendKeys(uIDogWeightEdit, this.AddNamesParams.UIDogWeightEditSendKeys, ModifierKeys.None);

            // Type '6' in 'DogAge' text box
            uIDogAgeEdit.Text = this.AddNamesParams.UIDogAgeEditText;
        }
        
        /// <summary>
        /// AssertDogWasAdded - Use 'AssertDogWasAddedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertDogWasAdded()
        {
            #region Variable Declarations
            HtmlDiv uIDogwasAddedPane = this.UINewtabInternetExplorWindow.UIManageDogDogDaycareTDocument.UIDogwasAddedPane;
            #endregion

            // Wait for 1 seconds for user delay between actions; Verify that the 'InnerText' property of 'Dog was Added!' pane equals 'Dog was Added! '
            Playback.Wait(1000);
            Assert.AreEqual(this.AssertDogWasAddedExpectedValues.UIDogwasAddedPaneInnerText, uIDogwasAddedPane.InnerText, "Dog Was Not added");
        }
        
        #region Properties
        public virtual AddNamesParams AddNamesParams
        {
            get
            {
                if ((this.mAddNamesParams == null))
                {
                    this.mAddNamesParams = new AddNamesParams();
                }
                return this.mAddNamesParams;
            }
        }
        
        public virtual AssertDogWasAddedExpectedValues AssertDogWasAddedExpectedValues
        {
            get
            {
                if ((this.mAssertDogWasAddedExpectedValues == null))
                {
                    this.mAssertDogWasAddedExpectedValues = new AssertDogWasAddedExpectedValues();
                }
                return this.mAssertDogWasAddedExpectedValues;
            }
        }
        
        public UINewtabInternetExplorWindow UINewtabInternetExplorWindow
        {
            get
            {
                if ((this.mUINewtabInternetExplorWindow == null))
                {
                    this.mUINewtabInternetExplorWindow = new UINewtabInternetExplorWindow();
                }
                return this.mUINewtabInternetExplorWindow;
            }
        }
        #endregion
        
        #region Fields
        private AddNamesParams mAddNamesParams;
        
        private AssertDogWasAddedExpectedValues mAssertDogWasAddedExpectedValues;
        
        private UINewtabInternetExplorWindow mUINewtabInternetExplorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AddNames'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AddNamesParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'about:Tabs' using new browser instance
        /// </summary>
        public string UINewtabInternetExplorWindowUrl = "about:Tabs";
        
        /// <summary>
        /// Type 'd{Down}' in text box
        /// </summary>
        public string UIItemEditSendKeys = "d{Down}";
        
        /// <summary>
        /// Go to web page 'http://drookddc.azurewebsites.net/'
        /// </summary>
        public string UINewtabInternetExplorWindowUrl1 = "http://drookddc.azurewebsites.net/";
        
        /// <summary>
        /// Type 'ruff' in 'DogName' text box
        /// </summary>
        public string UIDogNameEditText = "ruff";
        
        /// <summary>
        /// Type '{Tab}' in 'DogName' text box
        /// </summary>
        public string UIDogNameEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '100' in 'DogWeight' text box
        /// </summary>
        public string UIDogWeightEditText = "100";
        
        /// <summary>
        /// Type '{Tab}' in 'DogWeight' text box
        /// </summary>
        public string UIDogWeightEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '6' in 'DogAge' text box
        /// </summary>
        public string UIDogAgeEditText = "6";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertDogWasAdded'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AssertDogWasAddedExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Wait for 1 seconds for user delay between actions; Verify that the 'InnerText' property of 'Dog was Added!' pane equals 'Dog was Added! '
        /// </summary>
        public string UIDogwasAddedPaneInnerText = "Dog was Added! ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UINewtabInternetExplorWindow : BrowserWindow
    {
        
        public UINewtabInternetExplorWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "New tab";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("New tab");
            this.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIManageDogDogDaycareTDocument UIManageDogDogDaycareTDocument
        {
            get
            {
                if ((this.mUIManageDogDogDaycareTDocument == null))
                {
                    this.mUIManageDogDogDaycareTDocument = new UIManageDogDogDaycareTDocument(this);
                }
                return this.mUIManageDogDogDaycareTDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIManageDogDogDaycareTDocument mUIManageDogDogDaycareTDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Address and search using Bing";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Edit";
            this.WindowTitles.Add("New tab");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("New tab");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIManageDogDogDaycareTDocument : HtmlDocument
    {
        
        public UIManageDogDogDaycareTDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Manage Dog - Dog Daycare Tracker";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://drookddc.azurewebsites.net/";
            this.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIDogNameEdit
        {
            get
            {
                if ((this.mUIDogNameEdit == null))
                {
                    this.mUIDogNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIDogNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "DogName";
                    this.mUIDogNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "DogName";
                    this.mUIDogNameEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "DogName";
                    this.mUIDogNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIDogNameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIDogNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIDogNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"DogName\" class=\"form-control\" id=\"";
                    this.mUIDogNameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUIDogNameEdit.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
                    #endregion
                }
                return this.mUIDogNameEdit;
            }
        }
        
        public HtmlEdit UIDogWeightEdit
        {
            get
            {
                if ((this.mUIDogWeightEdit == null))
                {
                    this.mUIDogWeightEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIDogWeightEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "DogWeight";
                    this.mUIDogWeightEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "DogWeight";
                    this.mUIDogWeightEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "DogWeight";
                    this.mUIDogWeightEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIDogWeightEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIDogWeightEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIDogWeightEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"DogWeight\" class=\"form-control\" id";
                    this.mUIDogWeightEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUIDogWeightEdit.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
                    #endregion
                }
                return this.mUIDogWeightEdit;
            }
        }
        
        public HtmlEdit UIDogAgeEdit
        {
            get
            {
                if ((this.mUIDogAgeEdit == null))
                {
                    this.mUIDogAgeEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIDogAgeEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "DogAge";
                    this.mUIDogAgeEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "DogAge";
                    this.mUIDogAgeEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "DogAge";
                    this.mUIDogAgeEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIDogAgeEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIDogAgeEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIDogAgeEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"DogAge\" class=\"form-control\" id=\"D";
                    this.mUIDogAgeEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    this.mUIDogAgeEdit.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
                    #endregion
                }
                return this.mUIDogAgeEdit;
            }
        }
        
        public HtmlInputButton UIAddDogButton
        {
            get
            {
                if ((this.mUIAddDogButton == null))
                {
                    this.mUIAddDogButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIAddDogButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUIAddDogButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIAddDogButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Add Dog";
                    this.mUIAddDogButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIAddDogButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIAddDogButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUIAddDogButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" type=\"submit\" va";
                    this.mUIAddDogButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "4";
                    this.mUIAddDogButton.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
                    #endregion
                }
                return this.mUIAddDogButton;
            }
        }
        
        public HtmlDiv UIDogwasAddedPane
        {
            get
            {
                if ((this.mUIDogwasAddedPane == null))
                {
                    this.mUIDogwasAddedPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIDogwasAddedPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "dogwasaddeddiv2";
                    this.mUIDogwasAddedPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIDogwasAddedPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Dog was Added! ";
                    this.mUIDogwasAddedPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIDogwasAddedPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIDogwasAddedPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"dogwasaddeddiv2\"";
                    this.mUIDogwasAddedPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "15";
                    this.mUIDogwasAddedPane.WindowTitles.Add("Manage Dog - Dog Daycare Tracker");
                    #endregion
                }
                return this.mUIDogwasAddedPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIDogNameEdit;
        
        private HtmlEdit mUIDogWeightEdit;
        
        private HtmlEdit mUIDogAgeEdit;
        
        private HtmlInputButton mUIAddDogButton;
        
        private HtmlDiv mUIDogwasAddedPane;
        #endregion
    }
}