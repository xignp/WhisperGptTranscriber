using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;


namespace OpenAI_API_Example
{
    public class OpenAIAPI
    {
        // Transcribe an audio file using the Whisper-1 model
        public static async Task<string> TranscribeAudio(string filePath, string apiKey)
        {
            HttpClient client = new HttpClient();
            string apiUrl = "https://api.openai.com/v1/audio/transcriptions";

            using (var content = new MultipartFormDataContent())
            {
                string fileName = Path.GetFileName(filePath);
                var fileStream = File.OpenRead(filePath);
                var streamContent = new StreamContent(fileStream);
                streamContent.Headers.ContentType = new MediaTypeHeaderValue("audio/mp3");

                content.Add(streamContent, "file", fileName);
                content.Add(new StringContent("whisper-1"), "model");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var response = await client.PostAsync(apiUrl, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonDocument.Parse(responseBody);
                var transcription = jsonResponse.RootElement.GetProperty("text").GetString();
                return transcription ?? "";
            }
        }

        // Summarize the transcribed text using gpt-3.5-turbo model
        public static async Task<string> SummarizeText(string text, string apiKey)
        {
            HttpClient client = new HttpClient();
            string apiUrl = "https://api.openai.com/v1/chat/completions";

            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new {
                        role = "user",
                        content = $"Please summarize the following text: {text}"
                    }
                },
                temperature = 0
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var response = await client.PostAsync(apiUrl, jsonContent);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var jsonResponse = JsonDocument.Parse(responseBody);
            var summary = jsonResponse.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();

            return summary?.Trim() ?? "";
        }
    }
}
