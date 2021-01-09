using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD01.Models {
    public class Documento {
        public Guid uid { get; set; }               
        public Guid uidTipo { get; set; }          
        public string designacao { get; set; }
        public DateTime dtPublicacao { get; set; }
        public byte estado { get; set; }
        public string lstNomeTipoDocumento { get; set; }

    }
}
