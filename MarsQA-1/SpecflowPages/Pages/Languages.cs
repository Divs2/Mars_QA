using NUnit.Framework;
using OpenQA.Selenium;
using MarsQA_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MarsQA_1.Pages

{
    public class Languages
    {
        public static void AddLanguges()
        {

            //Add Languge
            //Click languges

            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();


            //Click AddNew Button
            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();

            //Add languges
            IWebElement addlanguge = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge.SendKeys("English");


            //Add languge level
            IWebElement langugelevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugelevel.Click();

            IWebElement basicl = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basicl.Click();

            //add and save languges
            IWebElement savelang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang.Click();
            

            // Check if record is present
            IWebElement actuallang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(actuallang.Text == "English", "actual languge and expected languge did not match");


            IWebElement addnewbutton1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton1.Click();


            IWebElement addlanguge1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge1.SendKeys("Gujarati");


            IWebElement langugelevel1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugelevel1.Click();

            IWebElement basicl1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basicl1.Click();


            IWebElement savelang1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang1.Click();
            Driver.driver.Navigate().Refresh();

            IWebElement addnewbuton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbuton.Click();


            IWebElement addlangug = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlangug.SendKeys("Hindi");


            IWebElement langugeleve = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugeleve.Click();

            IWebElement basic = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basic.Click();


            IWebElement savelan = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelan.Click();
            Driver.driver.Navigate().Refresh();

            IWebElement addnewbutto = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutto.Click();


            IWebElement addlangu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlangu.SendKeys("Panjabi");


            IWebElement langugele = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugele.Click();

            IWebElement basi = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basi.Click();


            IWebElement savela = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savela.Click();
            Driver.driver.Navigate().Refresh();
        }


        // Edit Languges
        public static void EditLanguges()
        {
            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();

            IWebElement editbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editbtn.Click();

            IWebElement elanguage = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            elanguage.Clear();
            elanguage.SendKeys("Chinese");

            IWebElement updbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updbtn.Click();

            Driver.driver.Navigate().Refresh();
            IWebElement uptlang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            Assert.That(uptlang.Text == "Chinese", "actual languge and expected languge did not match");

        }

        public static void Deletelanguges()
        {
            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();
            IWebElement deletebtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
            deletebtn.Click();
            IWebElement lang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            Assert.That(lang.Text != "English", "languge fail to delete");
        }


    }

}
