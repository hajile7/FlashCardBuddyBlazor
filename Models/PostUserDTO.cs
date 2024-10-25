using System.ComponentModel.DataAnnotations;

namespace FlashCardBuddyBlazor.Models
{
    public class PostUserDTO
{
   [Required(ErrorMessage = "Username is Required.")]
    public string Username { get; set;} = string.Empty;

    [Required(ErrorMessage = "Password is Required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    
    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; } = string.Empty;
   
    [Required(ErrorMessage = "First Name is Required.")]
     [StringLength(25, ErrorMessage = "First Name may not exceed 25 characters")]
    public string Firstname { get; set;} = string.Empty;

    [Required(ErrorMessage = "Last Name is Required.")]
     [StringLength(25, ErrorMessage = "Last Name may not exceed 25 characters")]
    public string Lastname { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is Required.")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = string.Empty;
}
}