using TestRepository.Dto;
using TestRepository.Entities;

namespace TestRepository.Mappers;

public class UserDtoMapper
{
    public static User ReturnUserFromDto(UserDto userDto)
    {
        return new User()
        {
            Email = userDto.Email,
            Password = userDto.Password,
            FirstName = userDto.FirstName,
            LastName = userDto.LastName
        };
    }
}