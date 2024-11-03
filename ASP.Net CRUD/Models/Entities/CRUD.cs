namespace ASP.Net_CRUD.Models.Entities
{
    public class CRUD
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Description { get; set; }
        
    }
}
