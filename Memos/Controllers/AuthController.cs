using System.Web.Mvc;

namespace Memos.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }


		public ActionResult Delete(int id)
		{
			return View();
		}

		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

	}
}
