using MVC5_ATM.Models;
using System.Web.Mvc;

namespace MVC5_ATM.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext(); 

        public ActionResult Deposit(int checkingAccountId)
        {

            return View();
        }

        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                dbContext.Transactions.Add(transaction);
                dbContext.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View();
        }

    }
}
