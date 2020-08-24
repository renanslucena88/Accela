using AccelaTest.Application.Services;
using AccelaTest.Data.Repository;
using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IRepository;
using AccelaTest.Domain.Interfaces.IServices;
using System;

namespace AccelaTest.UI.Helpers
{
    public static class PersonHelper
    {
        private static IPersonRepository _personRepository = new PersonRepository();
        private static IPersonService _personService = new PersonService(_personRepository);

        public static string GetFirstName(Guid id)
        {
            var personName = _personService.Select(id).FirstName;
            return personName;
        }

        public static Person GetPerson(Guid id)
        {
            var personName = _personService.Select(id);
            return personName;
        }
    }
}