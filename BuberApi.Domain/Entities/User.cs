namespace BuberApi.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string  Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}