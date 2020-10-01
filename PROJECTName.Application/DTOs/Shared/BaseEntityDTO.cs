namespace PROJECTName.Application.DTOs.Shared
{
    public abstract class BaseEntityDTO
    {
        protected BaseEntityDTO(string id) => Id = id;

        public string Id { get; private set; }
    }
}
