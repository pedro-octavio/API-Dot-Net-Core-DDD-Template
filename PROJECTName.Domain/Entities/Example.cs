using PROJECTName.Domain.Shared;
using System.ComponentModel.DataAnnotations;

namespace PROJECTName.Domain.Entities
{
    public class Example : BaseEntity
    {
        public Example(string property, string id) : base(id) => Property = property;

        [Required]
        [MaxLength(45)]
        public string Property { get; private set; }
    }
}
