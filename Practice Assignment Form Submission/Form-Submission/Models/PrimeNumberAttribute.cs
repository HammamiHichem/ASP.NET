// PrimeNumberAttribute.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace Form_Submission.Models
{
    public class PrimeNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int number = (int)value;
            if (IsPrime(number))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("The number must be a prime number.");
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }
    }
}
