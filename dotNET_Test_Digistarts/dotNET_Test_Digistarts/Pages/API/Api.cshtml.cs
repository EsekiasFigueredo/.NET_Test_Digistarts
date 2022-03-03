using dotNET_Test_Digistarts.Logic;
using dotNET_Test_Digistarts.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotNET_Test_Digistarts.Pages
{
    [Authorize]
    public class ApiModel : PageModel
    {

        public ApiModel()
        {

        }
        public Resultado resultado { get; set; }
        public void OnGet()
        {
            ResultadoLogic result = new();
            resultado = result.resultadoLogica();

        }
    }
}