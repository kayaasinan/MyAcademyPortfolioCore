using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string GitHubUrl { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int CategoryId { get; set; }
        //navigation property
        public Category? Category { get; set; }
    }
}
