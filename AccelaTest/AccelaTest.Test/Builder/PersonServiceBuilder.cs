using AccelaTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AccelaTest.Application.Services;

namespace AccelaTest.Test.Builder
{
    public class PersonServiceBuilder
    {
        private Guid _id = Guid.NewGuid() ;
        private static string _firstName = "Renan";
        private static string _lastName = "Lucena";

        public static PersonServiceBuilder New()
        {
            return new PersonServiceBuilder();
        }

        public PersonServiceBuilder WithId(Guid id)
        {
            _id = id;
            return this;
        }
        public  PersonServiceBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public  PersonServiceBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public Application.Services.PersonService Build()
        {
            return new Application.Services.PersonService(new Person
            {
                Id = _id,
                FirstName = _firstName,
                LastName = _lastName
            });
        }

    }
}
