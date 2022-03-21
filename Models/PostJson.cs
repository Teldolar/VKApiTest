using System.Text.Json.Serialization;

namespace VkApi.Models
{
    public class PostJson
    {
        [JsonPropertyName("response")] 
        public Response Response { get; set; }
    }

    public class Response
    {
        [JsonPropertyName("post_id")] 
        public int PostId { get; set; }
    }
}