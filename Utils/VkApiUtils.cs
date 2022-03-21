using System;

namespace VkApi.Utils
{
    public static class VkApiUtils
    {
        public static string CreatePost(string message)
        {
            var url = JsonReader.GetValueByKey("Resources/apisettings.json", "baseApiUrl");
            AddMethodName(ref url,"wall.post");
            AddToken(ref url,"bebf1614f1fc65a3f077f99925bbe2d1d4fe204b5eb2cbbedabd4a5f28d7768e798cf06c36b27f2859a9b");
            AddVersion(ref url,"5.131");
            AddParam(ref url,"owner_id","428349929");
            AddParam(ref url,"message",message);
            return ApiUtils.Post(url);
        }

        private static void AddParam(ref string url,string paramName,string paramValue)
        {
            url = url + "&" + paramName + "=" + paramValue;
        }

        private static void AddMethodName(ref string url,string methodName)
        {
            url = url.Replace("METHOD", methodName);
        }
        
        private static void AddToken(ref string url,string token)
        {
            url = url.Replace("TOKEN", token);
        }
        
        private static void AddVersion(ref string url,string version)
        {
            url = url.Replace("V", version);
        }
    }
}