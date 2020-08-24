using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccelaTest.Domain.Entities
{
    public class Person : BaseEntity
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public ICollection<Address> Address { get; set; }
    }
}