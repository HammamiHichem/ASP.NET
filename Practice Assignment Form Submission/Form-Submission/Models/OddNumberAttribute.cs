using System.ComponentModel.DataAnnotations;

namespace Form_Submission.Models
{
    public class OddNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && (int)value % 2 == 1)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Le nombre doit être impair.");
        }
    }
}
