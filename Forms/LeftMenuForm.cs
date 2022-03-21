using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace VkApi.Forms
{
    public class LeftMenuForm : Form
    {
        private ILink MyPageLink => ElementFactory.GetLink(Locator, Name);

        public LeftMenuForm() : base(By.XPath("//*[@id='l_pr']/a"), "MyPage")
        {
        }

        public void GoToMyPage()
        {
            MyPageLink.Click();
        }
    }
}