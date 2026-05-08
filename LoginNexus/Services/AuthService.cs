using LoginNexus.Models;

namespace LoginNexus.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "daniel@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Daniel" },
        new User { Email = "karol@nexus.edu", Password = "123", Role = "Student", Name = "Karol" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}