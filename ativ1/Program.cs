using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class CustomRaValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var ra = value as string;

        if (string.IsNullOrEmpty(ra))
        {
            return new ValidationResult("O RA � obrigat�rio.");
        }

        var raPattern = @"^RA\d{6}$";
        if (!Regex.IsMatch(ra, raPattern))
        {
            return new ValidationResult("O RA deve come�ar com 'RA' seguido por 6 d�gitos.");
        }

        return ValidationResult.Success;
    }
}
    