using TestRepository.Entities;
using TestRepository.Interfaces;
using TestRepository.Reposories;

namespace TestRepository;

public class UnitOfWork
{
    public IRepository<User> UserRepository { get; }
    // Добавьте здесь другие репозитории

    public UnitOfWork(UserRepository userRepository)
    {
        UserRepository = userRepository;
    }
}