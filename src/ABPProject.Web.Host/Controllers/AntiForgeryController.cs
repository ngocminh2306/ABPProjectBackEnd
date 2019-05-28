using Microsoft.AspNetCore.Antiforgery;
using ABPProject.Controllers;

namespace ABPProject.Web.Host.Controllers
{
    public class AntiForgeryController : ABPProjectControllerBase
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
