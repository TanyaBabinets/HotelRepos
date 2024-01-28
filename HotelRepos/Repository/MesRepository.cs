using HotelRepos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelRepos.Repository
{
	//[Authorize]
	public class MesRepository : IMesRepository
    {

        private readonly UserContext _context;

        public MesRepository(UserContext context)
        { 
            _context = context;
        }
        public async Task<List<Messages>> AllMes()
        {
            var mes = await _context.Messages.Include(m => m.user).ToListAsync();
            return mes;

        }
        [HttpPost]
		//[Authorize]
		public async Task Create(Messages item)
        {
           
            await _context.Messages.AddAsync(item);
         
        }

       

        public async Task<Messages> GetMes(int id)
        {
            return await _context.Messages.FindAsync(id);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

       
    }
}
