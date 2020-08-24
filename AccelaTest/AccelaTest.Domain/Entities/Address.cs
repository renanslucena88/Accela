using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccelaTest.Domain.Entities
{
    /*
     5. Edit Address (street, city, state, postalCode)
    6. Delete Address (id)
    */
    public class Address : BaseEntity
    {
        [Required]
        public Guid IdPerson { get; set; }
        public Person Person { get; set; }
        [Required]
        [Display(Name = "Street")]
        public string Street { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

    }
}
