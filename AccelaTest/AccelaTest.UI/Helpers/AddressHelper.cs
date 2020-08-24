using AccelaTest.Application.Services;
using AccelaTest.Data.Repository;
using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IRepository;
using AccelaTest.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccelaTest.UI.Helpers
{
    public static class AddressHelper
    {
        private static IAddressRepository _addressRepository = new AddressRepository();
        private static IAddressService _addressService = new AddressService(_addressRepository);

        public static IList<Address> GetAddressList(Guid id)
        {
            var addressList = _addressService.SelectByIdPerson(id);
            return addressList;
        }
    }
}
