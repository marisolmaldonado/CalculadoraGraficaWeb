using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver = new ChromeDriver();
        public CalculatorStepDefinitions()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

        }
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]

        public void GivenTheFirstNumberIs(int number)
        {
            driver.Navigate().GoToUrl("https://localhost:44325/calculadora/index");

             driver.FindElement(By.Name("primerNumero")).SendKeys(number.ToString());
           
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            driver.FindElement(By.Name("segundoNumero")).SendKeys(number.ToString());
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            driver.FindElement(By.Name("calcular")).Click();
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int esperado)
        {
            var respuesta = driver.FindElement(By.Name("respuesta")).Text;
            Assert.AreEqual(esperado, respuesta);
        }
    }
}
