using Microsoft.AspNetCore.Antiforgery;
using TwoContexts.Controllers;

namespace TwoContexts.Web.Host.Controllers
{
    public class AntiForgeryController : TwoContextsControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
