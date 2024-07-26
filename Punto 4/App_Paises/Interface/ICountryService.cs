using App_Paises.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace App_Paises.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryModel>> GetCountriesAsync();
    }

    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CountryModel>> GetCountriesAsync()
        {
            var response = await _httpClient.GetStringAsync("https://restcountries.com/v3.1/all");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<CountryModel>>(response, options);

        }
    }
}
