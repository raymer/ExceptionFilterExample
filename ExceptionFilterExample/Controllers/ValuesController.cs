using System.Web.Http;
using ExceptionFilterAttribute.Business;

namespace ExceptionFilterExample.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly MyService _myService;

        public ValuesController()
        {
            _myService = new MyService();
        }

        public string Get(int id)
        {
            _myService.DoThing();
            return "Result";
        }
    }
}
