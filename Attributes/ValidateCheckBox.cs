using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Lab2RoutingNavigationConfigure.Attributes
{
    //step1:create a class and inherit ValidationAttribute class and override IsValid function.
    //step2:inherit IClientModelValidator and implement the AddVAlidation() 
   
    public class ValidateCheckBox : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
           
            context.Attributes.Add("data-val", "true");
     //step3: Attribute name "data-val-chkbox" has to be implemented in frontend validation
            context.Attributes.Add("data-val-chkbox", ErrorMessage); //ErrorMessage src DataAnnotations Attr, ValidateCheckBox validator
        }
        public override bool IsValid(object? value)
        {
            //return base.IsValid(value); 
           return (bool)value;  //the unboxing can hav anything bool or object type
        }
    }
}

  