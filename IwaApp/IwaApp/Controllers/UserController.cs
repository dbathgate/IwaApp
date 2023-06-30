using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IwaApp.Controllers
{
    public class UserController : Controller
    {
        [Authorize]
        // GET: User
        public String Index()
        {
            return $"IWA on .NET Framework\nUsername: {User.Identity?.Name}";
        }
    }
}