using System.Collections.Generic;
using System.Web.Mvc;
using Memos.Models;
using Memos.Models.ViewModels;

namespace Memos.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
			var users = new List<User> {
				new User() { firstName = "Danilo", lastName = "Carolino", id = 1 },
                new User() { firstName = "Daniel", lastName = "Carolino", id = 2 },
                new User() { firstName = "Francisco", lastName = "Carlos", id = 3 },
                new User() { firstName = "Jeni", lastName = "Aparecida", id = 4 },
			};
			var viewModel = new UsersViewModel() { Users = users };
			return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        }

		public ActionResult New()
		{
			return View();
		}

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}