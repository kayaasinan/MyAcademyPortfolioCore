using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public IList<Project> Projects { get; set; }
    }
}
