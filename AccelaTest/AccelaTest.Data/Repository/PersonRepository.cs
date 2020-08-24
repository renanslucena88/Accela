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
    public class PersonRepository : IPersonRepository
    {
        private readonly AccelaDBContext context = AccelaDBContext.GetInstance;
        public EntityEntry<Person> Delete(Guid id)
        {
            return context.Set<Person>().Remove(Select(id));
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public EntityEntry<Person> Insert(Person obj)
        {
            return context.Set<Person>().Add(obj);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public Person Select(Guid id)
        {
            return context.Set<Person>().Find(id);
        }

        public IList<Person> SelectByFirstName(string firstName)
        {
            return context.Set<Person>().Where(x => x.FirstName == firstName).ToList();
        }

        public IList<Person> SelectByLastName(string lastName)
        {
            return context.Set<Person>().ToList();
        }

        public IList<Person> SelectAll()
        {
            return context.Set<Person>().ToList();
        }

        public Person Update(Person obj)
        {
            var objResult = context.Set<Person>().FirstOrDefault(x => x.Id == obj.Id);
            if (objResult != null)
            {
                context.Entry(objResult).State = EntityState.Detached;
            }
            context.Entry(obj).State = EntityState.Modified;
            return obj ;
        }

    }
}
