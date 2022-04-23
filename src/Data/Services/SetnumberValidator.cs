using System.ComponentModel.DataAnnotations;

namespace BlazingLego.Data.Services
{
    public class SetnumberValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var JsonDataService = new JsonDataService();

            var setnumber = (string)value;
            var set = JsonDataService.GetLegoSet(setnumber);
            if (set == null)
            {
                return new ValidationResult($"{setnumber} is not a valid lego set number");
            }
            return ValidationResult.Success;
        }   
    }
}
