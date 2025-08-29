using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Education
    {
        public int EducationId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string SchoolName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int StartYear { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string? EndYear { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string? Description { get; set; }
        
    }
}
