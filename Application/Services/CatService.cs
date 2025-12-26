using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class CatService(ICatService _catService)
    {
        public async Task<IEnumerable<dynamic>> GetAllBreeds() => await _catService.GetBreedsAsync();

        public async Task<dynamic?> GetBreed(string id) => await _catService.GetBreedByIdAsync(id);

        public async Task<IEnumerable<dynamic>> Search(string query) => await _catService.SearchBreedsAsync(query);
    }
}
