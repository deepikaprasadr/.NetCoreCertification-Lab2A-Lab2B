using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lab2RoutingNavigationConfigure.Attributes
{
    //custom taghelper
    //Inherit from TagHelper base class
    [HtmlTargetElement(Attributes="asp-active-link")]  //create custom attribute with the name asp-active-link to highlight the link using CSS class Active
    public class ActiveRouteTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]//this property should not be bound as an attri to the tag helper so the property is decorated here
        [ViewContext]
        public ViewContext ViewContext { get; set; }   
        //has [ViewContext] decorations above
        //ViewContext property is used to set with Current ViewDetails when creating a tag helper
        //We can get controller value, action name ie. Curr View Details
        public override void Process(TagHelperContext context, TagHelperOutput output) //override virtual method Process
        {

              
            var currentController = ViewContext.RouteData.Values["Controller"].ToString();
            var currentAction = ViewContext.RouteData.Values["Action"].ToString();
            //<param name="allAttributes">Every attribute associated with the current HTML element.</param>
            var tagController = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-controller").Value.ToString();
            var tagAction=context.AllAttributes.FirstOrDefault(a=>a.Name == "asp-action").Value.ToString();

            //<a class="nav-link text-dark" asp-area="" asp-controller="Account" asp-action="Login">Account Login</a>
            //https:8080/Account/Login/?uname/?password    //Route attributes
            //comparing the Route attributes to the tag herper attributes
            //if matches set the value of class atrri <a> to custom attribute "asp-active-link"

            if(currentController==tagController.ToString() && currentAction == tagAction.ToString())
            {
                var existingCss=context.AllAttributes.FirstOrDefault(a=>a.Name=="class").Value.ToString();
                var cssClass = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-active-link").Value.ToString();

                output.Attributes.SetAttribute("class", $"{existingCss} {cssClass}");
            }
        }
    }
}


