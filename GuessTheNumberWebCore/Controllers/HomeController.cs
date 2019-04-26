using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Model;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
namespace GuessTheNumberWebCore.Controllers
{
    public class HomeController : Controller
    {
        UserRepository UserRepository{ get; }

        public HomeController(DataContext dataContext)
        {
            this.UserRepository = new UserRepository(dataContext);
        }

        public IActionResult Index()
        {            
            return View(this.UserRepository.GetAllUsers());
        }
        public IActionResult AddUser(User user)
        {
            this.UserRepository.Save(user);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveUser(long id)
        {
            this.UserRepository.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult Profile(long userId)
        {
            return View(UserRepository.GetAllUsers().SingleOrDefault(p => p.Id == userId));
        }        
    }
}
