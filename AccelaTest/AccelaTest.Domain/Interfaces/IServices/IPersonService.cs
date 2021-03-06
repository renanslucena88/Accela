﻿using AccelaTest.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace AccelaTest.Domain.Interfaces.IServices
{
    public interface IPersonService
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