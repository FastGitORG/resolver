using Microsoft.AspNetCore.Mvc;
using Resolver.Util;

namespace Resolver.Controllers
{
    [ApiController]
    public class ConvertController : ControllerBase
    {
        [HttpGet]
        [Route("{org}/{repo}/zip/{branch}")]
        public IActionResult Get(string org, string repo, string branch)
        {
            return RedirectPermanent(Converter.ConvertToDownload(org, repo, branch));
        }
        
    }
}