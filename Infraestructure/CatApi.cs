using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Infraestructure
{
    public class CatApi : ICatService
    {

        private readonly HttpClient _httpClient;
        private const string ApiKey = "live_JBT0Ah0Nt12iyl2IpjQVLDWjcLk0GQwf4zI9wBMfmfejKmcC31mOJp4yJz5TsOUP";

        public CatApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
            _httpClient.DefaultRequestHeaders.Add("x-api-key", ApiKey);
        }

        public async Task<IEnumerable<dynamic>> GetBreedsAsync()
            => await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>("breeds");

        public async Task<dynamic?> GetBreedByIdAsync(string breedId)
            => await _httpClient.GetFromJsonAsync<dynamic>($"breeds/{breedId}");

        public async Task<IEnumerable<dynamic>> SearchBreedsAsync(string query)
            => await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>($"breeds/search?q={query}");

        public async Task<IEnumerable<dynamic>> GetImagesByBreedIdAsync(string breedId)
            => await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>($"images/search?breed_ids={breedId}&limit=5");

    }
}
