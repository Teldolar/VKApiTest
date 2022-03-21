using System;
using System.Text.Json;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Configurations;
using Aquality.Selenium.Core.Waitings;
using NUnit.Framework;
using VkApi.Models;
using VkApi.Utils;

namespace VkApi
{
    public class VkApiTests : BaseTest
    {
        private readonly ITimeoutConfiguration _timeoutConfiguration = AqualityServices.Get<ITimeoutConfiguration>();
        private readonly IConditionalWait _wait = AqualityServices.ConditionalWait;
        
        private const string SettingsPath = "Resources\\settings.json";
        
        [Test]
        public void VkApiTest()
        {
            AqualityServices.Logger.Debug("Go to vk.com");
            Driver.GoTo(JsonReader.GetValueByKey(SettingsPath,"url"));
            _wait.WaitFor(VkUiUtils.IsLoginPageDisplayed,_timeoutConfiguration.PageLoad);
            VkUiUtils.Login(JsonReader.GetValueByKey(SettingsPath,"login"),JsonReader.GetValueByKey(SettingsPath,"password"));
            _wait.WaitFor(VkUiUtils.IsLeftMenuDisplayed,_timeoutConfiguration.PageLoad);
            VkUiUtils.GoToMyPage();
            var postId = JsonSerializer.Deserialize<PostJson>(VkApiUtils.CreatePost("test message")).Response.PostId;
            Assert.AreEqual("test message",VkUiUtils.GetPostText(postId)); ;
        }
    }
}