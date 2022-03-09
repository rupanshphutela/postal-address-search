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
        public IActionResult GetCountries()
        {
            var addresses = _dataService.GetAllAddresssesData();
            if (addresses.Count() > 0)
            {
                var countries = addresses.Select(c => c.country).Distinct();
                return Ok(countries.ToList());
            }
            return NotFound();

        }

        [HttpGet("api/Country/{countryName}")]
        public IActionResult Country(string countryName) 
        {
            countryName = countryName.Trim();
            var result = new List<string>();
            var addresses = _dataService.GetAllAddresssesData();
            if (!string.IsNullOrEmpty(countryName) && addresses.Count()>0)
            {
                var countries = addresses.Select(c => c.country).Distinct().ToList(); 
                if (countries.Contains(countryName) || countryName.Equals("Any"))
                {
                    var address = countryName.Equals("Any") ? addresses.FirstOrDefault() :
                        addresses.Where(c => c.country == countryName).FirstOrDefault();

                    result = countryName.Equals("Any") ? typeof(Address).GetProperties()
                            .Select(x => new { property = x.Name, value = x.GetValue(address) })
                            .Select(r => r.property).ToList() :
                            typeof(Address).GetProperties()
                            .Select(x => new { property = x.Name, value = x.GetValue(address) })
                            .Where(x => x.value != null)
                            .Select(r => r.property).ToList();

                    result.Remove("country");
                    return Ok(result);
                }
                return NotFound();
            }
            return NotFound();            
        }

        [HttpPost("api/Search")]
        public IActionResult SearchAddresses([FromBody]Address address)
        {
            var data = _dataService.GetAllAddresssesData().ToList();
            List<Address> result = new List<Address>();

            foreach (Address a in data)
            {
                if (a.Equals(address))
                {
                    result.Add(a);
                }
            }
            if(result.Count()>0)
            {
                return Ok(result);
            }

            return NotFound();
        }

        public IActionResult Index()
        {
            var addresses = _dataService.GetAllAddresssesData();
            var countries = addresses.Select(c => c.country).Distinct();
            return View(addresses.FirstOrDefault());
        }



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
