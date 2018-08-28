using KC.SPARTA.Common.Constants;
using KC.SPARTA.Interface.Business;
using System.Web.Mvc;
using Unity;
using KC.SPARTA.Web.Filters;
using KC.SPARTA.Interface.Service;
using KC.SPARTA.DataAccess;

namespace KC.SPARTA.Web.Controllers
{
    [AuthFilter,ActionFilter, SpartaExceptionFilter]
    public class BaseController : Controller
    {
        protected IRule Rule { get; set; }
        protected IAppUser AppUser { get; set; }
        protected IBusinessSample BusinessObject { get; set; }


        public BaseController(IUserProvider UserProvider)
        {
            
            System.Web.HttpContext currentContext = System.Web.HttpContext.Current;

            //add to session 
            if (currentContext.Session[AppConstants.UserKey] == null)
            {
                //Get User Details to add to the session
                IAppUser appUser = UserProvider.GetUserContext(currentContext.User.Identity.Name);
                currentContext.Session[AppConstants.UserKey] = appUser;
            }
           
            
            //get from session add to property
            if (currentContext.Session[AppConstants.UserKey] != null)
                   AppUser  = (IAppUser)currentContext.Session[AppConstants.UserKey];


            ResolveUnity(AppUser.Region);


        }


        private void ResolveUnity(string Region)
        {
            //resolve unity based on the user regionlal setting (Default region or prefered or last logged in region)
            //the unit will resolve for Rules, Business & DAL
            Rule = UnityConfig.Container.Resolve<IRule>(Region);
            BusinessObject = UnityConfig.Container.Resolve<IBusinessSample>(Region);
        }

        //Resolve Unity for user context alone

    }
}