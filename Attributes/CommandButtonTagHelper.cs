using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lab2RoutingNavigationConfigure.Attributes
{
    //custom element eg.Button
    [HtmlTargetElement("command-button")]
    public class CommandButtonTagHelper : TagHelper
    {
        [HtmlAttributeName("value")]
        public string Value { get; set; }
        [HtmlAttributeName ("class")]
        public string CssClass { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string strHtml = $"<button type='submit' value='command' class='{CssClass}'>{Value}</button>";
            output.Content.SetHtmlContent(strHtml);
            
        }
    }
}
/*Anexplanationfortheabovecode: 
 * ● The[HtmlTargetElement] attribute indicates that the customTaghelper name which will be available on the HTMLpage ie., command-button 
 * ● The[HtmlAttributeName] attribute indicates the attribute values for the customTaghelper 
 * ie., valueandclassforValue and CssClass properties respectively. 
 * ● IntheProcess() method, During runtime we are constructing the Htmlbutton of type submit 
 * with the class value of the buttoncontrol would be set from the CssClass and Value attributes of the 
 * command-button Taghelper which we will be using in the Login.cshtml
 */