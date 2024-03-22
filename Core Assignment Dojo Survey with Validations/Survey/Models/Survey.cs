using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = "";

        [Required(ErrorMessage = "Language is required.")]
        public string Language { get; set; } = "";

        // Optional validation for Comment
        [MinLength(20, ErrorMessage = "Comment must be at least 20 characters.")]
        public string Comment { get; set; }
    }
}
