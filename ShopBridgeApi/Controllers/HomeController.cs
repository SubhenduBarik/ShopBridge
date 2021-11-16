using System.Web.Http;

namespace ShopBridgeApi.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            return "Api Running";
        }
    }
}