using System.Net.Http.Json;
using FlashCardBuddyBlazor.Models;

namespace FlashCardBuddyBlazor.Services 
{
    public class UserService
    {
        private readonly HttpClient _httpclient;
        
        private readonly string url = "https://localhost:7244";

       public UserDTO activeUser = new UserDTO(); 
       public bool Isloggedin = false; 
        public UserService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task<List<UserDTO>> GetUsersAsync()
        {
            var result = await _httpclient.GetFromJsonAsync<List<UserDTO>>($"{url}/api/User");
            return result ?? new List<UserDTO>();
        }

        public async Task<bool> PostUserAsync(PostUserDTO user) 
        {
          var response = await _httpclient.PostAsJsonAsync($"{url}/api/User",user);
           return response.IsSuccessStatusCode;
        }

        public async Task<UserDTO> LoginAsync(string username, string password)
        {
            var result = await _httpclient.GetFromJsonAsync<UserDTO>($"{url}/api/User/Login?username={username}&password={password}");
            return result;
        }

    }
}