using Microsoft.EntityFrameworkCore;
using TestRepository.Entities;
using TestRepository.Interfaces;
using TestRepository.Reposories;

namespace TestRepository;

public class UnitOfWork
{
    private DbContext _db;
    public IRepository<User> UserRepository { get; }
    // Добавьте здесь другие репозитории

    public UnitOfWork(UserRepository userRepository, MyDbContext db)
    {
        UserRepository = userRepository;
    }

    public async Task SaveAsync()
    {
        await _db.SaveChangesAsync();
    }
    public async Task DisposeAsync()
    {
        await _db.DisposeAsync();
    }

}