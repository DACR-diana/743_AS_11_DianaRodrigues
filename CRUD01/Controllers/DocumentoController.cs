using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD01.Models;

namespace CRUD01.Controllers {
    public class DocumentoController : Controller {

        public IActionResult ListarTudo() {
            List<Documento> Contentor;
            DocumentoHelper dh = new DocumentoHelper(Program._ligacao);

            Contentor = dh.getList();
            return View(Contentor);
        }
    }
}
