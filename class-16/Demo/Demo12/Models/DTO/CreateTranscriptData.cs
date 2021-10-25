using System.ComponentModel.DataAnnotations;

namespace Demo12.Models.DTO
{
    public class CreateTranscriptData
    {
        [Required]
        public string CourseCode { get; set; }

        [Required]
        public string Grade { get; set; }
    }
}
