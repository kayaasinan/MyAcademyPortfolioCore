using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class UserMessage
    {
        public int UserMessageId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string MessageBody { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public bool IsRead { get; set; }
    }
}
