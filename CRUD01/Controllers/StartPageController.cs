using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD01.Controllers {
    public class StartPageController : Controller {
        public IActionResult Home() {
            return View();
        }
    }
}
