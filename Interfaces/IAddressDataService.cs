using AddressManager_final.Models;
using System.Collections.Generic;


namespace AddressManager_final.Interfaces
{
    interface IAddressDataService
    {
        public IEnumerable<Address> GetAllAddresssesData();
    }
}
