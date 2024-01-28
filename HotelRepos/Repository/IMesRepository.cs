
using HotelRepos.Models;
using Microsoft.AspNetCore.Mvc;
namespace HotelRepos.Repository;


public interface IMesRepository
{
    Task<List<Messages>> AllMes();
    Task<Messages> GetMes(int id);
    Task Create(Messages item);
    
   
    Task Save();
}
