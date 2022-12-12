using AutomationTestingRegistration.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestingRegistration.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement Address => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("#eid > input"));
        IWebElement Phone => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Gender => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(1) > input"));
        IWebElement Hobbies => driver.FindElement(By.CssSelector("#checkbox2"));
        IWebElement Language => driver.FindElement(By.CssSelector ("div[id='msdd']"));
        IWebElement SelectLanguage => driver.FindElement(By.XPath("//a[text()='English']"));
        IWebElement Password => driver.FindElement(By.CssSelector("#firstpassword"));
        IWebElement ConfirmPassword => driver.FindElement(By.CssSelector("#secondpassword"));
        IWebElement Submit => driver.FindElement(By.CssSelector("#submitbtn"));

        public void ClickSelectLanguage()
        {
            SelectLanguage.Click();
        }
        public void ClickLanguage()
        {
            Language.Click();
        }
        public void ClickSubmit()
        {
            Submit.Click();
        }

    
        public void TypeConfirmPassword()
        {
            ConfirmPassword.SendKeys("Gaby1234");
        }

        public void TypePassword()
        {
            Password.SendKeys("Dapo1234");
        }

        public void SelectHobbies()
        {
            Hobbies.Click();
        }

        public void SelectGender()
        {
            Gender.Click();
        }

        public void TypePhone()
        {
            Phone.SendKeys("07733676897");
        }

        public void TypeEmailAddress()
        {
            EmailAddress.SendKeys("dapo@yahoo.com");
        }

        public void TypeAddress()
        {
            Address.SendKeys("162, Merkland Lane, Aberdeen");
        }

        public void TypeLastName()
        {
            LastName.SendKeys("Morenigbade");
        }
        public void TypeFirstName()
        {
            FirstName.SendKeys("Adedapo");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
        }



    }
}