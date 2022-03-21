using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace VkApi.Forms
{
    public class TopMenuForm : Form
    {
        private ILink HomeLink => ElementFactory.GetLink(Locator, Name);
        
        public TopMenuForm() : base(By.XPath("//a[@class='TopHomeLink']"), "HomeLink")
        {
        }
    }
}