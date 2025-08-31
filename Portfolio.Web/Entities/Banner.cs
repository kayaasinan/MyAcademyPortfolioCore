using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Banner
    {
        public int BannerId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string CoverImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Title { get; set; }
    }
}
