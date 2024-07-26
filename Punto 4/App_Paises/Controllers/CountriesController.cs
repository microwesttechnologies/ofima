using App_Paises.Models;
using App_Paises.Interfaces;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Extensions;

namespace App_Paises.Controllers
{    public class CountriesController : Controller
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IActionResult> Index(string searchKeyword, int page = 1)
        {
            var countries = await _countryService.GetCountriesAsync();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                countries = countries.Where(c => c.Names.Common.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            var pageSize = 10;
            var pagedCountries = countries.ToPagedList(page, pageSize);

            ViewBag.SearchKeyword = searchKeyword;

            return View(pagedCountries);
        }
    }
}
