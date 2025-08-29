using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int StartYear { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string? EndYear { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string City { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Description { get; set; }
    }
}
