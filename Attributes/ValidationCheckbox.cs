using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

using System.ComponentModel.DataAnnotations;



namespace AssignmentDNTSignup.Attributes
{
	public class ValidationCheckbox : System.ComponentModel.DataAnnotations.ValidationAttribute
	{

        public class ValidateCheckBox : System.ComponentModel.DataAnnotations.ValidationAttribute, IClientModelValidator
        {
            public void AddValidation(ClientModelValidationContext context)
            {
                context.Attributes.Add("data-val-checkbox", ErrorMessage);
                
            }

            public override bool IsValid(object? value)
            {
                return (bool)value;
                //if ((bool)value == true)
                //    return true;
                //else
                //    return false;
            }
        }

        public class ValidateRadio : System.ComponentModel.DataAnnotations.ValidationAttribute, IClientModelValidator
        {
            public void AddValidation(ClientModelValidationContext context)
            {
                context.Attributes.Add("data-val-radio", ErrorMessage);

            }

            public override bool IsValid(object? value)
            {
                return (bool)value;
                //if ((bool)value == true)
                //    return true;
                //else
                //    return false;
            }
        }
    }
}
