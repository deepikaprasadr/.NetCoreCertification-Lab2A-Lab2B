using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Components
{
    public class CommentViewComponent:ViewComponent
    {
        //public IViewComponentResult Invoke(int id)
        //{
        //    List<string> comments = new List<string> { "good", "better", "best" };
        //    return View("~/views/components/_comment.cshtml",comments);
        //}

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<string> comments = new List<string> { "good", "better", "best" };
            return View("~/views/components/_comment.cshtml", comments);
        }
    }
}
