using Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Infraestructure
{
    public class CatApi : ICatService
    {

        private readonly HttpClient _httpClient;

        public CatApi(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
            _httpClient.DefaultRequestHeaders.Add("x-api-key", config.GetSection("AccessKey").ToString());
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
