using System;
using System.ComponentModel.DataAnnotations;

namespace AccelaTest.Domain.Entities
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; }
    }
}