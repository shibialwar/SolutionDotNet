using KC.SPARTA.Common.Constants;
using KC.SPARTA.Interface.Business;
using KC.SPARTA.Interface.Service;
using KC.SPARTA.Model.ViewModel;
using System.Web.Mvc;
using Unity;
using AutoMapper;

namespace KC.SPARTA.Web.Controllers
{
    public class DefaultController : BaseController
    {
        

        public DefaultController(IUserProvider UserProvider, IMapper MyMapper ): base(UserProvider)
        {
        }

        // GET: Default
        public ActionResult Index()
        {
            Default d = new Default { Region = Rule.Calculate(5, 5).ToString() };
            
            return View("Index", d);
        }

        // GET: Default
        public ActionResult Index1()
        {
            Default d = new Default { Region = Rule.Calculate(5, 5).ToString() };
            return View("Index",d);
        }

        // GET: Default
        public ActionResult Index2()
        {
            Default d = new Default { Region = Rule.Calculate(5, 5).ToString() };
            return View("Index", d);
        }

        public ActionResult Error()
        {
            return View();
        }


    }
}
