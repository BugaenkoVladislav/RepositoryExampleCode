using Microsoft.AspNetCore.Mvc;
using TestRepository.Dto;
using TestRepository.Entities;
using TestRepository.Mappers;

namespace TestRepository.Services;

public class UserService(UnitOfWork unitOfWork)
{
    private readonly UnitOfWork _unit = unitOfWork;
    public async  Task<User> GetUserById(long id)
    {
        return await _unit.UserRepository.GetEntityFromExpression(x => x.Id == id);
        
    }
    public async  Task<User> GetUserByLogin(string login)
    {
        return await _unit.UserRepository.GetEntityFromExpression(x => x.Email == login);
    }
    
    public async  Task CreateUser(UserDto userDto)
    {
        await _unit.UserRepository.CreateEntity(UserDtoMapper.ReturnUserFromDto(userDto));
        await _unit.SaveAsync();
    }
    
    public async  Task DeleteUserByLogin(string login)
    {
        await _unit.UserRepository.RemoveEntityFromExpression(x=>x.Email == login);
        await _unit.SaveAsync();
    }
    
    public async Task DeleteUserById(long id)
    {
        await _unit.UserRepository.RemoveEntityFromExpression(x=>x.Id == id);
        await _unit.SaveAsync();
    }
    
}