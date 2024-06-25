using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TracNghiem.Models
{
    public class Answer
    {
        [Key]
        public  string AnswerId { get; set; }
        public  string AnswerOption { get; set; } // Ví dụ: "A", "B", "C", "D"
        public  string AnswerDescription { get; set; }
        // Câu hỏi mà đáp án này thuộc về
        [ForeignKey("QuestionId")]
        public string QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
