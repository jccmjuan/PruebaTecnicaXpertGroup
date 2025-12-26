using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICatService
    {
        Task<IEnumerable<dynamic>> GetBreedsAsync();
        Task<dynamic?> GetBreedByIdAsync(string breedId);
        Task<IEnumerable<dynamic>> SearchBreedsAsync(string query);
        Task<IEnumerable<dynamic>> GetImagesByBreedIdAsync(string breedId);
    }
}
