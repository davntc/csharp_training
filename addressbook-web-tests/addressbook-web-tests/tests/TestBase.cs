using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addressbook_web_tests;
using WebAddressbookTests;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
      //  protected IWebDriver driver;
      //  private StringBuilder verificationErrors;
      //  protected string baseURL;
        
       // protected LoginHelper loginHelper;
       // protected NavigationHelper navigator;
       // protected GroupHelper groupHelper;
       // protected ContactHelper contactHelper;

        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
           app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();              
        }
        
        
    }
}
