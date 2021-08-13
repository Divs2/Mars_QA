using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Education
 
    {
        public static void AddEducation()
        {
            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();
            Driver.TurnOnWait();
            IWebElement eduadd = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            eduadd.Click();
            Driver.TurnOnWait();
            IWebElement clgadd = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            clgadd.SendKeys("K.S");
            Driver.TurnOnWait();
            IWebElement clgcountry = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            clgcountry.Click();
            Driver.TurnOnWait();
            IWebElement countryname = Driver.driver.FindElement(By.XPath(" /html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            countryname.Click();
            Driver.TurnOnWait();
            IWebElement degreetitle = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            degreetitle.Click();
            Driver.TurnOnWait();
            IWebElement titlenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]"));
            titlenm.Click();
            Driver.TurnOnWait();
            IWebElement degreenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreenm.SendKeys("bachler's in informtion technology");
            Driver.TurnOnWait();
            IWebElement yearofgradution = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearofgradution.Click();
            Driver.TurnOnWait();
            IWebElement year = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[3]"));
            year.Click();
            Driver.TurnOnWait();
            IWebElement addedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addedu.Click();
        }
        //Validating Add languges
        public static void validateaddedu()
        {
            Driver.TurnOnWait();
            IWebElement actualedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(actualedu.Text == "K.S", "actual colledge and expected colledge did not match");

        }

        public static void EditEducation()
        {
            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();
            IWebElement editedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            editedu.Click();
            IWebElement eclg = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            eclg.Clear();
            eclg.SendKeys("B.K");
            IWebElement ecountry = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            ecountry.Click();
            IWebElement ecountryn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select/option[102]"));
            ecountryn.Click();
            Driver.TurnOnWait();
            IWebElement edegreetitle = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            edegreetitle.Click();
            Driver.TurnOnWait();
            IWebElement etitlenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[8]"));
            etitlenm.Click();
            Driver.TurnOnWait();
            IWebElement edegreenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            edegreenm.Clear();
            edegreenm.SendKeys("Master of Science");
            Driver.TurnOnWait();
            IWebElement eyearofgradution = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            eyearofgradution.Click();
            Driver.TurnOnWait();
            IWebElement eyear = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[4]"));
            eyear.Click();
            IWebElement updbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updbtn.Click();
        }
        //Validate edit Languge
        public static void validateeditedu()
        {
            Driver.TurnOnWait();
            IWebElement updedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(updedu.Text == "B.K", "actual colledge and expected colledge did not match");

        }

        public static void DeleteEducation()
        {
            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();
            IWebElement deletebtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deletebtn.Click();

        }
        //Validate delete language
        public static void validatedeleteedu()
        {
            Driver.TurnOnWait();
            List<IWebElement> elementList = new List<IWebElement>();
            elementList.AddRange(Driver.driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")));
            Assert.That(elementList.Count > 0, "Test fail");
        }

        
    }
}
