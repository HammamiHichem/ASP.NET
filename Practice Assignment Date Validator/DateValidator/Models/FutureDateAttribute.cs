using System;
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
{
    if (value != null && (DateTime)value > DateTime.Now)
    {
        return new ValidationResult("La date ne peut pas être dans le futur.");
    }
    // Retourner un ValidationResult.Success même si la validation réussit
    return ValidationResult.Success;
}

}
