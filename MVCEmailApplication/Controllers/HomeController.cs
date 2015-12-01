using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MVCEmailApplication.Models;

namespace MVCEmailApplication.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        public ActionResult Index()
        {
            //User must be authorized by this point. Safe to retrieve user id
            var userId = User.Identity.GetUserId();
            var user = db.Users.Single(u => u.Id == userId);

            var viewModel = new SystemEmailUserViewModel
            {
                User = user,
                SystemEmails = db.SystemEmails.Where(se => se.UserId == user.Id)
            };

            return View(viewModel);
        }
    }
}