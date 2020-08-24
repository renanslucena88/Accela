using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IRepository;
using AccelaTest.Domain.Interfaces.IServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelaTest.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;
        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public EntityEntry<Address> Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public EntityEntry<Address> Insert(Address obj)
        {
            return _repository.Insert(obj);
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public Address Select(Guid id)
        {
            return _repository.Select(id);
        }

        public IList<Address> SelectAll()
        {
            return _repository.SelectAll();
        }

        public IList<Address> SelectByIdPerson(Guid id)
        {
            return _repository.SelectByIdPerson(id);
        }

        public Address Update(Address obj)
        {
            return _repository.Update(obj);
        }
    }
}
