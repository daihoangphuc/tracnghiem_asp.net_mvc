using System.ComponentModel.DataAnnotations;

namespace TracNghiem.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserClassName { get; set; }

    }
}
