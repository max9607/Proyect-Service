using System;
using System.Collections.Generic;

namespace Proyect_Service.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? Nit { get; set; }
        public int? Telefono { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
