using System.Web.Mvc;
using Microsoft.Research.Malmo;

namespace MinimalMalmo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CauseTrouble()
        {
            ViewBag.Message = "Instantiating AgentHost creates trouble when publishing.";
            //MissionSpec mission = new MissionSpec();
            AgentHost agentHost = new AgentHost();
            return RedirectToAction("Success");
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
