using System.Net.Http.Json;
using FlashCardBuddyBlazor.Models;


namespace FlashCardBuddyBlazor.Services
{
    public class FlashcardService
    {
        private readonly HttpClient _httpclient;
        
        private readonly string url = "https://localhost:7244";

        public string stackChoice = "";

        public FlashcardService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task<List<Flashcard>> GetAllFlashCardsAsync(int id)
        {
            var result = await _httpclient.GetFromJsonAsync<List<Flashcard>>($"{url}/api/Flashcard/All?userId={id}");
            return result ?? [];
        }

        public async Task<List<Flashcard>> GetStackFlashCardsAsync(int id, string stack)
        {
            var result = await _httpclient.GetFromJsonAsync<List<Flashcard>>($"{url}/api/Flashcard/{stack}?userId={id}");
            return result ?? [];
        }

        public async Task<List<Flashcard>> GetSpecificFlashCardAsync(int id)
        {
            var result = await _httpclient.GetFromJsonAsync<List<Flashcard>>($"{url}/api/Flashcard?flashcardid={id}");
            return result ?? [];
        }
    }
}