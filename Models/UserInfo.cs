using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

    [Required(ErrorMessage ="İsim alanı boş")]
     public string? Name { get; set; }   


    [Required(ErrorMessage ="Telefon alanı boş")]
     public string? Phone { get; set; }   

    
    [Required(ErrorMessage ="E-mail zorunlu")]
    [EmailAddress(ErrorMessage ="Hatali E-mail")]
     public string? Email { get; set; }   

    [Required(ErrorMessage ="Seçim yapınız")]
     public bool? WillAttend { get; set; }   
    }
}