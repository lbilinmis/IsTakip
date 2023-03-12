using Microsoft.AspNetCore.Mvc.Filters;

namespace IsTakip.WebUI.Filters
{
    public class UserFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.Where(x => x.Key == "model").FirstOrDefault();
            base.OnActionExecuting(context);
        }
    }
}
