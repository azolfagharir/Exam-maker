using System.ComponentModel.DataAnnotations;

namespace QuizHub.Models.Users;

public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    [MaxLength(255)]
    public string Username { get; set; }
    [Required]
    [MaxLength(255)]
    public string Email { get; set; }
    [Required]
    [MaxLength(32)]
    public string Password { get; set; }


}