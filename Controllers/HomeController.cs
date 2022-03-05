using AddressManager_final.Interfaces;
using AddressManager_final.Models;
using AddressManager_final.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AddressManager_final.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IAddressDataService _dataService;

        public HomeController(ILogger<HomeController> logger, AddressDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        [HttpGet("api/Countries")]
        public List<string> GetCountries()
        {
            var addresses = _dataService.GetAllAddresssesData();
            var countries = addresses.Select(c => c.country).Distinct();
            return countries.ToList();
        }

        [HttpGet("api/Country/{countryName}")]
        public ActionResult Country(string countryName)
        {
            var address = _dataService.GetAllAddresssesData().Where(c => c.country == countryName).FirstOrDefault();
            var result = typeof(Address).GetProperties()
                .Select(x => new { property = x.Name, value = x.GetValue(address) })
                .Where(x => x.value != null)
                .ToList().Select(r => r.property);
            return View(result);
        }

        public IActionResult Index()
        {
            var addresses = _dataService.GetAllAddresssesData();
            var countries = addresses.Select(c => c.country).Distinct();
            return View(addresses.FirstOrDefault());
        }



        [HttpPost("test")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
