using Microsoft.AspNetCore.Mvc.Rendering;

namespace Proyect_Service.Models.ViewModels
{
    public class UsuarioVM
    {
        public Usuario oUsuario { get; set; }

        public List<SelectListItem> olistaEmpresa { get; set; }



    }
}
