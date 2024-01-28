using HotelRepos.Models;
namespace HotelRepos.Repository
{ 

    public interface IUserRepository
    {
        Task<List<Users>> GetUserList();
        Task<Users> GetUser(int id);
        Task Create(Users item);
     
        Task Save();
    }
}