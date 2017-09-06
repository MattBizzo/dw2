using System.Collections.Generic;
using System.Web.Mvc;
using Memos.Models;
using Memos.Models.ViewModels;

namespace Memos.Controllers
{
    public class MemosController : Controller
    {
        public ActionResult Index()
        {
            var user = new User() { firstName = "Danilo", lastName = "Carolino", id = 1 };
            var memos = new List<Memo> {
                new Memo() {id = 1, content = "Memorando 1", title = "Primeiro memorando", user = user },
                new Memo() {id = 2, content = "Memorando 2", title = "Segundo memorando", user = user }
            };
            var viewModel = new MemosViewModel()
            {
                User = user,
                Memos = memos
            };
            return View (viewModel);
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

		public ActionResult New()
		{
			return View();
		}

		public ActionResult Tracking()
		{
			return View();
		}

        public ActionResult Create()
        {
            return View ();
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