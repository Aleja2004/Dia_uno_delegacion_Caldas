using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.Dominio;
using Proyecto.Persistencia;
using System;

namespace Presentacion.Pages
{
    public class FormCuidadoraModel : PageModel
    {

        private readonly IRepositorio _repo;

        public FormCuidadoraModel(IRepositorio repo)
        {
            _repo=repo;
        }

        public UsuarioMujeres  Mujer {get;set;}
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            
            Mujer=_repo.AddMujeres(Mujer);
            if (Mujer != null)
            {
                Console.WriteLine("HOla");
                return RedirectToPage();

                Console.WriteLine(Mujer.Nombres);
            }
            return RedirectToPage("/Error");

        }
    }
}
