using proje_base.Attribute;

using System.ComponentModel.DataAnnotations;


namespace proje_base.Request
{
    public class TokenRequest
    {
        [Required]
        [MaxLength(125)]
        [UserNameAttribute]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [PasswordAttribute]
        public string Password { get; set; }
    }
}
