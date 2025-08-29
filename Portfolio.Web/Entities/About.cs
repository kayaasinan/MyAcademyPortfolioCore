using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string WebSite { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string City { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Graduation { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public bool IsAvailable { get; set; }
    }
}
