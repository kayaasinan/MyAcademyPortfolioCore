using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string LastName{ get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Password { get; set; }
    }
}
