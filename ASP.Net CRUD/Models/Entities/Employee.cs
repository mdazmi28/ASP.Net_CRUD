namespace ASP.Net_CRUD.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string  Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; } //here with the ? mark we can say the phone number is nullable.
        public required decimal Salary { get; set; }

    }
}
