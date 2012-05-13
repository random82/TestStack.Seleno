using OpenQA.Selenium;
using SampleWebApp.Models;
using SeleniumExtensions;

namespace SampleWebApp.FunctionalTests
{
    public class RegisterPage : UiComponent<RegisterModel>
    {
        public HomePage Register(RegisterModel model)
        {
            FillWith(model);
            return NavigateTo<HomePage>(By.Id("register"));
        }
    }
}