using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ImageService(ICatService _catService)
    {
        public async Task<IEnumerable<dynamic>> GetImagesByBreed(string breedId)
        => await _catService.GetImagesByBreedIdAsync(breedId);
    }
}
