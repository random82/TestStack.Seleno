using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace MvcMusicStore.FunctionalTests.Step3.Pages
{
    public class LogonPage : Page
    {
        public RegisterPage GoToRegisterPage()
        {
            return NavigateTo<RegisterPage>(By.LinkText("Register"));
        }
    }
}