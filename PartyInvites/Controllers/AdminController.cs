using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.Username = newName;
            repository.SubmitChanges();

            return View();
        }
    }
}