using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ShareSkillsSteps
    {
        [Given(@"Seller has clicked on  Share Skill")]
        public void GivenSellerHasClickedOnShareSkill()
        {
            Driver.TurnOnWait();
            IWebElement shareskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a"));
            shareskill.Click();


        }
        
        [Given(@"Seller has added title")]
        public void GivenSellerHasAddedTitle()
        {
            Driver.TurnOnWait();
            IWebElement addtitle = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            addtitle.SendKeys("Goods are material items that you can purchase");

        }
        
        [Given(@"Seller can only write (.*) characters on title")]
        public void GivenSellerCanOnlyWriteCharactersOnTitle(int p0)
        {
            
        }
        
        [Given(@"Seller has added  description")]
        public void GivenSellerHasAddedDescription()
        {
            Driver.TurnOnWait();
            IWebElement adddesc = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            adddesc.SendKeys("Travel and books");
        }
        
        [Given(@"Seller can only write (.*) characters on description")]
        public void GivenSellerCanOnlyWriteCharactersOnDescription(int p0)
        {
            
        }
        
        [Given(@"Seller has chosen category")]
        public void GivenSellerHasChosenCategory()
        {
            Driver.TurnOnWait();
            IWebElement categ = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categ.Click();
            IWebElement choosecate = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select/option[7]"));
            choosecate.Click();

           
        }
        
        [Given(@"Seller has chosen subcategory")]
        public void GivenSellerHasChosenSubcategory()
        {
            Driver.TurnOnWait();
            IWebElement subcatg = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subcatg.Click();
            IWebElement catgnm = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
            catgnm.Click();
        }
        
        [Given(@"Seller has added tag")]
        public void GivenSellerHasAddedTag()
        {
            Driver.TurnOnWait();
            IWebElement tag = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
            tag.SendKeys("phtos");
            tag.SendKeys(Keys.Enter);
        }
        
        [Given(@"Seller has chosen service type")]
        public void GivenSellerHasChosenServiceType()
        {
            Driver.TurnOnWait();
            IWebElement sertype = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/label"));
            sertype.Click();

        }
        
        [Given(@"Seller has chosen location type")]
        public void GivenSellerHasChosenLocationType()
        {
            Driver.TurnOnWait();
            IWebElement sertype = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/label"));
            sertype.Click();

        }

        [Given(@"Seller has selected start date and end date")]
        public void GivenSellerHasSelectedStartDateAndEndDate()
        {
            Driver.TurnOnWait();
            IWebElement sdate = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            sdate.Click();
            sdate.SendKeys("10102021");
        }
        
        [Given(@"Seller has specified start and end times for each avaiable day")]
        public void GivenSellerHasSpecifiedStartAndEndTimesForEachAvaiableDay()
        {
            Driver.TurnOnWait();
            IWebElement aday1 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            aday1.Click();
            IWebElement time1 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            time1.SendKeys("0800AM");
            IWebElement etime1 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            etime1.SendKeys("1200PM");

            IWebElement aday2 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
            aday2.Click();
            IWebElement time2 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
            time2.SendKeys("0900AM");
            IWebElement etime2 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));
            etime2.SendKeys("0200PM");

        }

        [Given(@"Seller has chosen skill trend")]
        public void GivenSellerHasChosenSkillTrend()
        {
            Driver.TurnOnWait();
            IWebElement skilltrend = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skilltrend.Click();
        }
        
        [Given(@"Seller has added skill exchange")]
        public void GivenSellerHasAddedSkillExchange()
        {
            Driver.TurnOnWait();
            IWebElement skillex = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillex.SendKeys("Javascript");
            skillex.SendKeys(Keys.Enter);
        }
        
        [Given(@"Seller has uploaded work samples")]
        public void GivenSellerHasUploadedWorkSamples()
        {
           
        }
        
        [Given(@"Seller has chosen enable or disable services")]
        public void GivenSellerHasChosenEnableOrDisableServices()
        {
            Driver.TurnOnWait();
            IWebElement aservices = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            aservices.Click();
        }
        
        [Given(@"Seller must be on Manage Listings tab")]
        public void GivenSellerMustBeOnManageListingsTab()
        {
            Driver.TurnOnWait();
            IWebElement mlisting = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[3]"));
            mlisting.Click();

            
        }
        
        [Given(@"Seller has clicked on  Manage Listings")]
        public void GivenSellerHasClickedOnManageListings()
        {
            Driver.TurnOnWait();
            IWebElement mlisting = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[3]"));
            mlisting.Click();

        }

        [Given(@"Seller has click on edit Share Skill")]
        public void GivenSellerHasClickOnEditShareSkill()
        {
            Driver.TurnOnWait();
            IWebElement eshareskill = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
            eshareskill.Click();
            
        }
        
        [Given(@"Seller has edited title")]
        public void GivenSellerHasEditedTitle()
        {
            Driver.TurnOnWait();
            IWebElement etitle = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            etitle.Clear();
            etitle.SendKeys("Goods are material items that you can buy");

        }

        [Given(@"Seller has edited  description")]
        public void GivenSellerHasEditedDescription()
        {
            Driver.TurnOnWait();
            IWebElement edesc = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            edesc.Clear();
            edesc.SendKeys("Reading and Listening");
        }
        
        [Given(@"Seller has chosen new category")]
        public void GivenSellerHasChosenNewCategory()
        {
            Driver.TurnOnWait();
            IWebElement ecateg = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select"));
            ecateg.Click();
            IWebElement echoosecate = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]"));
            echoosecate.Click();
        }
        
        [Given(@"Seller has chosen new subcategory")]
        public void GivenSellerHasChosenNewSubcategory()
        {
            Driver.TurnOnWait();
            IWebElement esubcatg = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            esubcatg.Click();
            IWebElement ecatgnm = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
            ecatgnm.Click();
        }
        
        [Given(@"Seller has edited tag")]
        public void GivenSellerHasEditedTag()
        {
            Driver.TurnOnWait();
            IWebElement etag = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
            etag.Clear();
            etag.SendKeys("videos");
            etag.SendKeys(Keys.Enter);
        }
        
        [Given(@"Seller has chosen new service type")]
        public void GivenSellerHasChosenNewServiceType()
        {
            Driver.TurnOnWait();
            IWebElement esertype = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/label"));
            esertype.Click();
        }
        
        [Given(@"Seller has chosen  new location type")]
        public void GivenSellerHasChosenNewLocationType()
        {
            Driver.TurnOnWait();
            IWebElement esertype = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            esertype.Click();

        }

        [Given(@"Seller has selected  new start date and end date")]
        public void GivenSellerHasSelectedNewStartDateAndEndDate()
        {
            Driver.TurnOnWait();
            IWebElement esdate = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            esdate.Click();
            esdate.Clear();
            esdate.SendKeys("09092021");
        }
        
        [Given(@"Seller has specified new start and end times for each avaiable day")]
        public void GivenSellerHasSpecifiedNewStartAndEndTimesForEachAvaiableDay()
        {
            Driver.TurnOnWait();
            
            IWebElement etime1 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            
            etime1.SendKeys("1000AM");
            IWebElement entime1 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            
            entime1.SendKeys("0300PM");

            
            IWebElement etime2 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
            
            etime2.SendKeys("1000AM");
            IWebElement entime2 = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));
            entime2.SendKeys("0400PM");
        }
        
        [Given(@"Seller has chosen  new skill trend")]
        public void GivenSellerHasChosenNewSkillTrend()
        {
            Driver.TurnOnWait();
            IWebElement eskilltrend = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            eskilltrend.Click();
            

        }
        
        [Given(@"Seller has edited skill exchange")]
        public void GivenSellerHasEditedSkillExchange()
        {
            Driver.TurnOnWait();
            IWebElement phour = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/input"));
            phour.SendKeys("9");
        }
        
        [Given(@"Seller has uploaded new work samples")]
        public void GivenSellerHasUploadedNewWorkSamples()
        {
            
        }
        
        [Given(@"Seller has edited enable or disable services")]
        public void GivenSellerHasEditedEnableOrDisableServices()
        {
            Driver.TurnOnWait();
            IWebElement easervices = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            easervices.Click();
        }
        
        [Given(@"seller clicked on delete button")]
        public void GivenSellerClickedOnDeleteButton()
        {
            Driver.TurnOnWait();
            IWebElement dbtn = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"));
            dbtn.Click();
        }
        
        [When(@"seller clicks on Save button")]
        public void WhenSellerClicksOnSaveButton()
        {
            Driver.TurnOnWait();
            IWebElement sbtn = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[11]/div/input[1]"));
            sbtn.Click();
        }
        
        [When(@"Seller  clicks on toggle button below active")]
        public void WhenSellerClicksOnToggleButtonBelowActive()
        {
            Driver.TurnOnWait();
            IWebElement tbtn = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[7]/div/input"));
            tbtn.Click();
        }
        
        [When(@"Seller  clicks on yes")]
        public void WhenSellerClicksOnYes()
        {
            Driver.TurnOnWait();
            IWebElement ydel = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            ydel.Click();

        }
        
        [Then(@"Seller's share skill must be saved and visible")]
        public void ThenSellerSShareSkillMustBeSavedAndVisible()
        {
            Driver.TurnOnWait();
            IWebElement actualdes = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
            Assert.That(actualdes.Text == "Travel and books", "actual description and expected description did not match");
        }

        [Then(@"Seller's udated share skill must be saved and visible")]
        public void ThenSellerSUdatedShareSkillMustBeSavedAndVisible()
        {
            Driver.TurnOnWait();
            IWebElement upddes = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
            Assert.That(upddes.Text == "Reading and Listening", "actual description and expected description did not match");
        
    }

        [Then(@"Seller can must be able to change status of their service")]
        public void ThenSellerCanMustBeAbleToChangeStatusOfTheirService()
        {
            
        }
        
        [Then(@"Seller's  Share Skill must be deleted")]
        public void ThenSellerSShareSkillMustBeDeleted()
        {
           
           IWebElement dskill = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/h3"));

            Assert.That(dskill.Text == "You do not have any service listings!", "skill fail to delete");
        }
    }
}
