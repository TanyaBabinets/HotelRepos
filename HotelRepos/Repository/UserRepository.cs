using Microsoft.EntityFrameworkCore;
using HotelRepos.Models;

namespace HotelRepos.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task Create(Users item)
        {
            await _context.Users.AddAsync(item);
        }


        public async Task<Users> GetUser(int id)
        {
        return await _context.Users.FindAsync(id);
           }




        public async Task<List<Users>> GetUserList()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

      
    }
}
