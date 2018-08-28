using AutoMapper;
using System.Web.Mvc;
using KC.SPARTA.Model.ViewModel;
using KC.SPARTA.Interface.Service;
using KC.SPARTA.SpartaException;
using System;
using System.Linq;

namespace KC.SPARTA.Web.Controllers
{
    public class AuthenticationController : BaseController
    {

        public AuthenticationController(IUserProvider UserProvider, IMapper MyMapper) : base(UserProvider)
        {
        }

        // GET: Authentication
        public ActionResult Login()
        {
            try
            {
                throw new Exception("test");

            }
            catch (Exception e)
            {
                SpartaException.ExceptionHandler.GetInstance().Handle(e);
            }

            Login login = new Login() { UserId = AppUser.Name };

            return View(login);
        }

        
        public ActionResult Sample()
        {
            SampleModel s = new SampleModel() { data = Enumerable.ToList(BusinessObject.GetBizData()) };

            return View ("SampleView",s);
        }

    }
}