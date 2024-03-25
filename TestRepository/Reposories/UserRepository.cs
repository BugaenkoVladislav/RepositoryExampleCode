using Microsoft.EntityFrameworkCore;
using TestRepository.Entities;

namespace TestRepository.Reposories;

public class UserRepository(MyDbContext db):BaseRepository<User>(db)
{
  private MyDbContext _db = db;
}