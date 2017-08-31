using System.Web.Mvc;

namespace Memos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult Memos()
        {
            return View();
        }

        public ActionResult NewMemo()
        {
            return View();
        }

        public ActionResult Tracking()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }
    }
}