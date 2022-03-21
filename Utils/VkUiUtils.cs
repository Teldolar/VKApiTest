using Aquality.Selenium.Browsers;
using VkApi.Forms;

namespace VkApi.Utils
{
    public static class VkUiUtils
    {
        private static readonly LoginForm LoginForm = new();
        private static readonly LeftMenuForm LeftMenuForm = new();
        private static readonly TopMenuForm TopMenuForm = new();
        private static readonly MyPageForm MyPageForm = new();
        
        public static void Login(string login,string password)
        {
            AqualityServices.Logger.Debug("Login");
            LoginForm.Login(login,password);
        }

        public static void GoToMyPage()
        {
            AqualityServices.Logger.Debug("GoToMyPage");
            LeftMenuForm.GoToMyPage();
        }

        public static string GetPostText(int postNumber)
        {
            return MyPageForm.GetPostText("428349929",postNumber);
        }

        public static bool IsLoginPageDisplayed()
        {
            AqualityServices.Logger.Debug("Check that login form is displayed");
            return LoginForm.State.IsDisplayed;
        }
        
        public static bool IsLeftMenuDisplayed()
        {
            AqualityServices.Logger.Debug("Check that left menu is displayed");
            return LeftMenuForm.State.IsDisplayed;
        }
        
        public static bool IsTopMenuDisplayed()
        {
            AqualityServices.Logger.Debug("Check that top menu is displayed");
            return TopMenuForm.State.IsDisplayed;
        }
    }
}