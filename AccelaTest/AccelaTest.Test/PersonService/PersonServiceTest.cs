using AccelaTest.Test.Builder;
using AccelaTest.Test.Util;
using System;
using Xunit;
using Xunit.Abstractions;

namespace AccelaTest.Test.PersonService
{
    public class PersonServiceTest : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private Guid _guid;

        public PersonServiceTest(ITestOutputHelper output)
        {
            _guid = Guid.NewGuid();
            _output = output;
            _output.WriteLine("Executing");
        }

        public void Dispose()
        {
            _output.WriteLine("Executed");
        }

        //[Theory(DisplayName = "Id Cannot Be NullOrEmpty")]
        //[InlineData(null)]
        //[InlineData("")]
        //public void IdCannotBeInvalid(Guid id)
        //{
        //    Assert.Throws<ArgumentException>(() => PersonServiceBuilder.New().WithId(id).Build());
        //}

        [Theory(DisplayName = "First Name Cannot Be NullOrEmpty")]
        [InlineData(null)]
        [InlineData("")]
        public void FirstNameCannotBeNullOrEmpty(string firstName)
        {
            Assert.Throws<ArgumentException>(() => PersonServiceBuilder.New().WithFirstName(firstName).Build()).MessageExt("Firstname cannot be null or empty");
        }

        [Theory(DisplayName = "Last Name Cannot Be NullOrEmpty")]
        [InlineData(null)]
        [InlineData("")]
        public void LastNameCannotBeNullOrEmpty(string lastName)
        {
            Assert.Throws<ArgumentException>(() => PersonServiceBuilder.New().WithLastName(lastName).Build()).MessageExt("Lastname cannot be null or empty");
        }
    }
}