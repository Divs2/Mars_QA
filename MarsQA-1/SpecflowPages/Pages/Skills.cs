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
    class Skills
    {
        public static void AddSkills()
        {
            IWebElement CreateSkills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkills.Click();

            Driver.TurnOnWait();
            IWebElement Addskills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Addskills.Click();

            Driver.TurnOnWait();
            IWebElement skillname = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillname.SendKeys("Drawing");

            Driver.TurnOnWait();
            IWebElement skilllevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skilllevel.Click();

           IWebElement skilllevelnm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skilllevelnm.Click();
            IWebElement addbtns = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addbtns.Click();
            Driver.TurnOnWait();
            IWebElement actualskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(actualskill.Text == "Drawing", "actual Skill and expected Skill did not match");

        }

        public static void EditSkills()
        {
            IWebElement CreateSkills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkills.Click();

            Driver.TurnOnWait();
            IWebElement editSbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editSbtn.Click();

            IWebElement eskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            eskill.Clear();
            eskill.SendKeys("Painting");

            Driver.TurnOnWait();

            IWebElement updbtns = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updbtns.Click();

            Driver.driver.Navigate().Refresh();
            IWebElement CreateSills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

           CreateSills.Click();
            
            Driver.TurnOnWait();
           IWebElement upskillnm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
          
            Assert.That(upskillnm.Text == "Painting","actual colledge and expected colledge did not match");


        }

        public static void DeleteSkill()
        {

            IWebElement CreateSkills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkills.Click();
            IWebElement deleteskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteskill.Click();
            Driver.TurnOnWait();
            List<IWebElement> elementList = new List<IWebElement>();
            elementList.AddRange(Driver.driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")));
            Assert.That(elementList.Count > 0, "Test fail");
        }

    }
}
