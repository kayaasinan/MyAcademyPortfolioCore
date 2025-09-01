using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string MapUrl { get; set; }
    }
}
