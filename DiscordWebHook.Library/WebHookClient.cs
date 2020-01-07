using DiscordWebHook.Library.Models;
using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DiscordWebHook.Library
{
    public class WebHookClient
    {
        public string WebHookURL { get; set; }

        public WebHookClient() { }

        public WebHookClient(string webHookURL)
        {
            WebHookURL = webHookURL;
        }

        // Post message
        public async Task<int> PostMessage(WebHookMessage message)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string payload = JsonSerializer.Serialize(message);

                using (HttpResponseMessage httpResponse = 
                    await httpClient.PostAsync(WebHookURL, new StringContent(payload, Encoding.UTF8, "application/json")))
                {
                    return (int)httpResponse.StatusCode;
                }
            }
        }

        // Post file
        public async Task<int> PostFile(string fileName)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (MultipartFormDataContent dataContent = new MultipartFormDataContent("CB-" + DateTime.Now.Ticks.ToString("x")))
                {
                    dataContent.Headers.ContentType.MediaType = "multipart/form-data";

                    FileInfo file = new FileInfo(fileName);

                    dataContent.Add(new StreamContent(file.OpenRead()), file.Name, file.Name);

                    using (HttpResponseMessage httpResponse = await httpClient.PostAsync(WebHookURL, dataContent))
                    {
                        return (int)httpResponse.StatusCode;
                    }
                }
            }
        }

        // Post file with payload
        public async Task<int> PostFile(string fileName, WebHookMessage message)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (MultipartFormDataContent dataContent = new MultipartFormDataContent("CB-" + DateTime.Now.Ticks.ToString("x")))
                {
                    dataContent.Headers.ContentType.MediaType = "multipart/form-data";

                    FileInfo file = new FileInfo(fileName);
                    string payload = JsonSerializer.Serialize(message);

                    dataContent.Add(new StreamContent(file.OpenRead()), file.Name, file.Name);
                    dataContent.Add(new StringContent(payload, Encoding.UTF8, "application/json"), "payload_json");

                    using (HttpResponseMessage httpResponse = await httpClient.PostAsync(WebHookURL, dataContent))
                    {
                        return (int)httpResponse.StatusCode;
                    }
                }
            }
        }

        // Convert DateTime to ISO8601 format.
        public static string DateTimeToISO8601(int year, int month, int day, int hour, int minute, int second)
        {
            return new DateTime(year, month, day, hour, minute, second, 0, DateTimeKind.Local)
                .ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
        }
    }
}
