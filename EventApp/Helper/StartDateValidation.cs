using System.ComponentModel.DataAnnotations;

namespace EventApp.Helper
{
    public class StartDateValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if ((DateTime?)value < DateTime.Today)
            {
                return new ValidationResult($"Data nie może być starsza, niż dzisiejsza");
            }
            return ValidationResult.Success;
        }
    }
}
