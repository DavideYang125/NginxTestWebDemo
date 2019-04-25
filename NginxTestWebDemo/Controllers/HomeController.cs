using System.Web.Mvc;

namespace NginxTestWebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var serverName = "服务器名称：" + Server.MachineName;
            var ip = "服务器IP地址：" + Request.ServerVariables["LOCAL_ADDR"];
            var port = Request.ServerVariables["SERVER_PORT"];
            var portStr = "HTTP访问端口：" + Request.ServerVariables["SERVER_PORT"];
            var message = "hello nginx";
            if (port == "35356") message = "good morning,Sir";
            ViewBag.serverName = serverName;
            ViewBag.ip = ip;
            ViewBag.portStr = portStr;
            ViewBag.message = message;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}