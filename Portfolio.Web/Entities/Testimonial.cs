using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [Range(1, 5, ErrorMessage = "Değerlendirme 1 ile 5 arasında bir sayı olmalıdır.")]

        public int Review { get; set; }
    }
}
