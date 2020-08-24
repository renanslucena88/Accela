using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccelaTest.Domain.Entities
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; }
    }
}
