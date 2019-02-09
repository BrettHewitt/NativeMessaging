using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NativeMessaging
{
    public class ResponseConfirmation
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public JObject Data { get; set; }

        public ResponseConfirmation(JObject data)
        {
            Data = data;
            Message = "Confirmation of received data";
        }

        public ResponseConfirmation(string msg)
        {
            Message = msg;
        }

        public JObject GetJObject()
        {
            return JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeObject(this));
        }
    }
}
