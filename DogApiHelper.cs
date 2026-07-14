using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DogPep
{
    class DogApiHelper
    {
        HttpClient client = new HttpClient();

        public async Task<string> GetDogFact()
        {
            try
            {
                var resp = await client.GetAsync("https://dogapi.dog/api/v2/facts");
                resp.EnsureSuccessStatusCode();
                string text = await resp.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(text))
                {
                    return doc.RootElement.GetProperty("data")[0].GetProperty("attributes").GetProperty("body").GetString();
                }
            }
            catch (Exception ex)
            {
                return "Ошибка: " + ex.Message;
            }
        }

        public async Task<string> GetDogImage()
        {
            try
            {
                var resp = await client.GetAsync("https://dog.ceo/api/breeds/image/random");
                resp.EnsureSuccessStatusCode();
                string text = await resp.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(text))
                {
                    return doc.RootElement.GetProperty("message").GetString();
                }
            }
            catch
            {
                return "";
            }
        }
    }
}