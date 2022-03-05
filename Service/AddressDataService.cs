using AddressManager_final.Interfaces;
using AddressManager_final.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressManager_final.Service
{
    public class AddressDataService: IAddressDataService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AddressDataService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        private string AddressJsonFileName
        {
            get { return Path.Combine(_webHostEnvironment.WebRootPath, "data", "Addresses.json"); }
        }

        public IEnumerable<Address> GetAllAddresssesData()
        {
            using (var jsonFileReader = File.OpenText(AddressJsonFileName))
            {
                return JsonSerializer.Deserialize<Address[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
