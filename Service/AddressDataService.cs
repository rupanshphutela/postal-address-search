using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AddressManager_final.Service
{
    public class AddressDataService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public AddressDataService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string GetAddressJsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Addresses.json"); }
        }
    }
}
