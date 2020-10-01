using System;
using System.ComponentModel.DataAnnotations;

namespace PROJECTName.Domain.Shared
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string id) => Id = id;

        [Key]
        [MaxLength(10)]
        public string Id { get; private set; }

        public void GenerateId() => Id = Guid.NewGuid().ToString().Replace("-", "").Substring(1, 10);
    }
}
