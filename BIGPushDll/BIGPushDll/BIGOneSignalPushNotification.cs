using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace BIGPushDll
{
    public class BIGOneSignalPushNotification
    {
        public BIGOneSignalPushNotification()
        {

        }

        public async Task<bool> SendPushNotificationsAndroid(string messagePush, string userPush, string headingPush, string headColorPush,
            string contentColorPush, string imagePush) 
        {
            bool returnValue = false;

            try
            {
                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Const.REST_API_KEY);

                    var obj = new
                    {

                        included_segments = new string[] { userPush }, // new string[] { "Subscribed Users" } new[] { Static.EnumIncludeSegmentToString(includeSegment) }
                        app_id = Const.APP_ID,
                        headings =   new { en = headingPush, }, 
                        contents =   new { en = messagePush }, 
                        android_background_layout = new { image = imagePush, headings_color = headColorPush, contents_color = contentColorPush } //color solo quando ce immagine //headings_color = "FF0000FF", contents_color = "FF0000FF" 
                     };

                        var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                        var response =  await client.PostAsync("https://onesignal.com/api/v1/notifications", content);//post my content on OneSignal Url
                        var responseString = await response.Content.ReadAsStringAsync();
                        
                }

                returnValue = true;
            }
            catch (Exception ex)
            {
                returnValue = false;
                
            }

            return returnValue;
        }
    }

 }
