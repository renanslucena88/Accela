using AccelaTest.Data.Context;
using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccelaTest.Data.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AccelaDBContext context = AccelaDBContext.GetInstance;
        public EntityEntry<Address> Delete(Guid id)
        {
            return context.Set<Address>().Remove(Select(id));
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public EntityEntry<Address> Insert(Address obj)
        {
            return context.Set<Address>().Add(obj);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public Address Select(Guid id)
        {
            return context.Set<Address>().Find(id);
        }

        public IList<Address> SelectAll()
        {
            return context.Set<Address>().ToList();
        }

        public IList<Address> SelectByIdPerson(Guid id)
        {
            return context.Set<Address>().Where(x => x.IdPerson == id).ToList();
        }

        public Address Update(Address obj)
        {
            var objResult = context.Set<Address>().FirstOrDefault(x => x.Id == obj.Id);
            if (objResult != null)
            {
                context.Entry(objResult).State = EntityState.Detached;
            }
            context.Entry(obj).State = EntityState.Modified;
            return obj;
        }
    }
}
