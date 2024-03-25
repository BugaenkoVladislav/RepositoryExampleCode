using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TestRepository.Entities;
[Index("Email",IsUnique = true)]
public class User
{
    [Key]
    [Required]
    public long Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}