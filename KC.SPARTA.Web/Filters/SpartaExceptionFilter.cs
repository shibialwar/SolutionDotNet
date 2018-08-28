using System;
using System.Web.Mvc;
using System.Web;
using System.Web.Mvc.Filters;
using KC.SPARTA.SpartaException;

namespace KC.SPARTA.Web.Filters
{
    public class SpartaExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                //SpartaException.ExceptionHandler.GetInstance().Handle(filterContext.Exception);

                   filterContext.ExceptionHandled = true;
                var controlerName = filterContext.RouteData.Values["controller"].ToString();
                var actionName = filterContext.RouteData.Values["action"].ToString();
                var model = new HandleErrorInfo(filterContext.Exception, controlerName, actionName);

                filterContext.Result = new ViewResult
                {
                    ViewName = "error",
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                    TempData = filterContext.Controller.TempData,
                };

            }

        }
    }
}