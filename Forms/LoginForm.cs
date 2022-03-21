using System.Buffers.Text;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Html5;

namespace VkApi.Forms
{
    public class LoginForm : Form
    {
        private IButton LoginButton => ElementFactory.GetButton(Locator, Name);
        private static ITextBox LoginTextBox => ElementFactory.GetTextBox(By.XPath("//*[@id='index_email']"), "LoginTextBox");
        private static ITextBox PasswordTextBox => ElementFactory.GetTextBox(By.XPath("//*[@id='index_pass']"), "PasswordTextBox");
        
        public LoginForm() : base(By.XPath("//*[@id='index_login_button']"), "LoginButton")
        {
        }

        public void Login(string login, string password)
        {
            LoginTextBox.SendKeys(login);
            PasswordTextBox.SendKeys(password);
            LoginButton.Click();
        }
    }
}