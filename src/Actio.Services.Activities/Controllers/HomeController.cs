using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Actio.Services.Activities.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() => Content("Hello From Actio.Services.Activities.Controllers API !");
    }
}
