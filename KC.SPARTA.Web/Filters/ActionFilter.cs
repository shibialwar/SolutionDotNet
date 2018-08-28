using System.Web.Mvc;
using System.Web.Mvc.Filters;
using KC.SPARTA.Interface.Service;
using KC.SPARTA.Common.Constants;
using Unity;

namespace KC.SPARTA.Web.Filters
{
    public class ActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
    }
}