using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [Range(0, 100, ErrorMessage = "Yüzde değeri 0 ile 100 arasında olmalıdır.")]
        public int Percentage { get; set; }
    }
}
