using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id) 
        {
            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Contact model) 
        {
            if (ModelState.IsValid) 
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
