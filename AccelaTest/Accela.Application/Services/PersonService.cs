using AccelaTest.Config;
using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IRepository;
using AccelaTest.Domain.Interfaces.IServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AccelaTest.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;
        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }
        public PersonService(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                throw new ArgumentException("Firstname cannot be null or empty");
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                throw new ArgumentException("Lastname cannot be null or empty");
            }
        }

        public EntityEntry<Person> Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public void Dispose()
        {
             _repository.Dispose();
        }

        public EntityEntry<Person> Insert(Person obj)
        {
            return _repository.Insert(obj);
        }

        public void SaveChanges()
        {
             _repository.SaveChanges();
        }

        public Person Select(Guid id)
        {
            return _repository.Select(id);
        }

        public IList<Person> SelectAll()
        {
            return _repository.SelectAll();
        }

        public IList<Person> SelectByFirstName(string firstName)
        {
            return _repository.SelectByFirstName(firstName);
        }

        public IList<Person> SelectByLastName(string lastName)
        {
            return _repository.SelectByLastName(lastName);
        }

        public Person Update(Person obj)
        {
            return _repository.Update(obj);
        }
    }
}
