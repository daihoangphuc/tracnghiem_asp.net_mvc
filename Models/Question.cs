using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TracNghiem.Models
{
    public class Question
    {
        [Key]
        public  string? QuestionId { get; set; }
        public  string? QuestionContent { get; set; }
        public  string? CorrectAnswer { get; set; } // Đáp án đúng
        // Danh sách các đáp án cho câu hỏi
        public ICollection<Answer> Answers { get; set; }

        // Người đã trả lời câu hỏi
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public User? User { get; set; }
    }
}
