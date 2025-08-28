using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Password { get; set; }
    }
}
