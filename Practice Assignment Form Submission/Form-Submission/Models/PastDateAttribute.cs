using System;
using System.ComponentModel.DataAnnotations;

namespace Form_Submission.Models
{
    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && (DateTime)value < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("La date doit être dans le passé.");
        }
    }
}
