using System.Web.Mvc;
//using System.Web.Mvc.FileResult;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller
    {
        public ActionResult RedirectPermanent()
        {
            return RedirectPermanent("http://www.google.com");
        }

        public ActionResult Index()
        {
            return Content("This message is sent from the Index action!");
        }

        public ActionResult RedirectToActionInTheSameController()
        {
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToActionInHomeController()
        {
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute("About");
        }

        public ActionResult ReturnFile()
        {
            return Content("Site.css");
        }
    }
}