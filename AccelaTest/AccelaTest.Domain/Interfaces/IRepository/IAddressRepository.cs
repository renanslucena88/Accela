using AccelaTest.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace AccelaTest.Domain.Interfaces.IRepository
{
    public interface IAddressRepository
    {
        EntityEntry<Address> Insert(Address obj);

        EntityEntry<Address> Delete(Guid id);

        Address Select(Guid id);

        IList<Address> SelectByIdPerson(Guid id);

        IList<Address> SelectAll();

        Address Update(Address obj);

        void Dispose();

        void SaveChanges();
    }
}