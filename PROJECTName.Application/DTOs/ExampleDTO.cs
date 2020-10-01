using Newtonsoft.Json;
using PROJECTName.Application.DTOs.Shared;

namespace PROJECTName.Application.DTOs
{
    public class ExampleDTO : BaseEntityDTO
    {
        [JsonConstructor]
        public ExampleDTO(string property, string id) : base(id) => Property = property;

        public string Property { get; private set; }
    }
}
