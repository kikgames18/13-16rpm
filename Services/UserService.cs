using _13_16.Data;
using _13_16.Models;
using System.Collections.Generic;
using System.Linq;

namespace _13_16.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll() => _context.Users.ToList();

        public User Get(int id) => _context.Users.FirstOrDefault(u => u.Id == id);

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser == null) return null;

            existingUser.Name = user.Name;
            existingUser.Device = user.Device;
            existingUser.Problem = user.Problem;
            existingUser.ContactPhone = user.ContactPhone;
            _context.SaveChanges();
            return existingUser;
        }

        public bool Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;

            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }
    }
}
