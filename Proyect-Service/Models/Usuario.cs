using System;
using System.Collections.Generic;

namespace Proyect_Service.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public int? Telefono { get; set; }
        public int? EmpresaId { get; set; }

        public virtual Empresa? Empresa { get; set; }
    }
}
