using proje_base.Attribute;
using System.ComponentModel.DataAnnotations;


namespace proje_base.Request
{
    public class UpdatePasswordRequest
    {
        [Required]
        [PasswordAttribute]
        public string OldPassword { get; set; }

        [Required]
        [PasswordAttribute]
        public string NewPassword { get; set; }
    }
}
