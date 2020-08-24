using AccelaTest.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelaTest.Domain.Interfaces.IRepository
{
    public interface IPersonRepository
    {
        EntityEntry<Person> Insert(Person obj);
        EntityEntry<Person> Delete(Guid id);
        Person Select(Guid id);
        IList<Person> SelectByFirstName(string firstName);
        IList<Person> SelectByLastName(string lastName);
        IList<Person> SelectAll();
        Person Update(Person obj);
        void Dispose();
        void SaveChanges();

    }
}
