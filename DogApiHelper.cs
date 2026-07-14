using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DogApp
{
    public class DogApiHelper
    {
        // Клиент для запросов. Не самый идеальный вариант объявлять его так, но для лабы пойдет.
        private HttpClient client = new HttpClient();

        public async Task<string> GetDogFactAsync()
        {
            try
            {
                // Эндпоинт 1: получаем факт
                string url = "https://dogapi.dog/api/v2/facts";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Парсим JSON. Немного топорно через JsonDocument, но работает
                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    var root = doc.RootElement;
                    var data = root.GetProperty("data")[0];
                    var attributes = data.GetProperty("attributes");
                    return attributes.GetProperty("body").GetString();
                }
            }
            catch (Exception ex)
            {
                return "Ошибка при получении данных: " + ex.Message;
            }
        }
    }
}