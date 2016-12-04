using Microsoft.AspNetCore.Mvc;
using PwtDev.Models;

namespace PwtDev.Controllers
{
    public class ProjectController : Controller
    {
        private PwtContext _context;

        public ProjectController(PwtContext context)
        {
            this._context = context;
        }

        public IActionResult Index(int ProjectID)
        {
            Project toDisplay = _context.Projects.Find(ProjectID);
            return View(toDisplay);
        }


        public IActionResult Projects()
        {
            return View(_context.Projects);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Projects.Add(project);
                _context.SaveChanges();
                return RedirectToAction("Index", new { ProjectID = project.ProjectID });
            }

            return RedirectToAction("Index", "Home", null);
        }
    }
}
