namespace backend.Models
{
    public class RegisterUserRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
