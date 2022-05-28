using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using w03_MVC_Tutorial.Models;

namespace w03_MVC_Tutorial.Controllers
{
    public class MovieController : Controller
    {

        private static List<Movie> _Movie = new List<Movie>()
        {
            new Movie(){Id = 1, MName = "絕命毒師", Type = "Action、Mystery", Duration = 147},
            new Movie(){Id = 2, MName = "良醫", Type = "Action、Drama", Duration = 134}
        };
        // GET: MovieController
        public ActionResult Index()
        {
            return View(_Movie);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie model)
        {
            try
            {
                _Movie.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
