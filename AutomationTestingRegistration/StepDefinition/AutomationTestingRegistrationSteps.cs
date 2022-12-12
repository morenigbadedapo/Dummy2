using AutomationTestingRegistration.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AutomationTestingRegistration.StepDefinition
{
    [Binding]
    public class AutomationTestingRegistrationSteps
    {
        RegistrationPage registrationPage;

        public AutomationTestingRegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }


        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationPage.NavigateToWebsite();
        }


        [Given(@"I type in First Name")]
        public void GivenITypeInFirstName()
        {
            registrationPage.TypeFirstName();
        }
        
        [Given(@"I type in Last Name")]
        public void GivenITypeInLastName()
        {
            registrationPage.TypeLastName();
        }
        
        [Given(@"I type in Address")]
        public void GivenITypeInAddress()
        {
            registrationPage.TypeAddress();
        }
        
        [Given(@"I type in Email Address")]
        public void GivenITypeInEmailAddress()
        {
            registrationPage.TypeEmailAddress();
        }
        
        [Given(@"I type in Phone")]
        public void GivenITypeInPhone()
        {
            registrationPage.TypePhone();
        }
        
        [Given(@"I select Gender")]
        public void GivenISelectGender()
        {
            registrationPage.SelectGender();
        }
        
        [Given(@"I select  Hobbies")]
        public void GivenISelectHobbies()
        {
            registrationPage.SelectHobbies();
        }

        [Given(@"I select Languages")]
        public void GivenISelectLanguages()
        {
            registrationPage.ClickLanguage();
            registrationPage.ClickSelectLanguage();
        }

        [Given(@"I type in Password")]
        public void GivenITypeInPassword()
        {
            registrationPage.TypePassword();
        }
        
        [Given(@"I type in Confirm Password")]
        public void GivenITypeInConfirmPassword()
        {
            registrationPage.TypeConfirmPassword();
        }
        
        [When(@"I click  on Submit")]
        public void WhenIClickOnSubmit()
        {
            registrationPage.ClickSubmit();
        }
        [Then(@"I should be able to Sign Up")]
        public void ThenIShouldBeAbleToSignUp()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
