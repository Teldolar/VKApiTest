using System.Reflection.Emit;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace VkApi.Forms
{
    public class MyPageForm : Form
    {
        private ILabel Post(string userId,int postNumber) =>
            ElementFactory.GetLabel(By.XPath($"//*[@id='wpt{userId}_{postNumber}']"), "Post");
        
        public MyPageForm() : base(By.XPath("//*[@id='profile_photo_link']"), "profilePhoto")
        {
        }

        public string GetPostText(string userId, int postNumber)
        {
            return Post(userId, postNumber).Text;
        }
    }
}