using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Lab2RoutingNavigationConfigure.Attributes
{
    public class ValidateCheckBox : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
           
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-chkbox", ErrorMessage); //ErrorMessage src DataAnnotations Attr, ValidateCheckBox validator
        }
        public override bool IsValid(object? value)
        {
            //return base.IsValid(value); 
           return (bool)value;  //the unboxing can hav anything bool or object type
        }
    }
}

  