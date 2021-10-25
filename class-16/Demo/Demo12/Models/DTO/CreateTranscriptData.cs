using System.ComponentModel.DataAnnotations;

namespace Demo12.Models.DTO
{
    public class CreateTranscriptData
    {
        public int CourseId { get; set; }

        [Required]
        public string Grade { get; set; }
    }
}
