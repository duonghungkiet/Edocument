namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? LoginName { get; set; }
        public string? SapCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
