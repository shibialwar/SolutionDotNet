using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using KC.SPARTA.Common.Constants;
using KC.SPARTA.Interface.Service;
using KC.SPARTA.Authentication;
using Unity;

namespace KC.SPARTA.Web.Filters
{
    public class AuthFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
          

            //when user is authenticated
            if (!filterContext.Principal.Identity.IsAuthenticated)
            {

                //filterContext.Result = new HttpUnauthorizedResult();

            }

        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //Check Session is Empty Then set as Result is HttpUnauthorizedResult 

        }
    }
}