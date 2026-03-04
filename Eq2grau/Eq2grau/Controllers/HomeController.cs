using Eq2grau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eq2grau.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Calculo das raízes de uma equação do 2º grau
        /// </summary>
        /// <param name="A">Parâmetro do x^2</param>
        /// <param name="B">Parâmetro do x</param>
        /// <param name="C">Parâmetro da constante</param>
        /// <returns>Vista</returns>

        public IActionResult Index(string A, string B,string C)
        {
            //1º - Receber os  parâmetros, do cliente
                 
            //2º - Validar os parâmetros
                //2.1 - A,B,C  são números ?

            if(!float.TryParse(A, out float a))
            {
                //A não é numero
                //Falta gerar uma mensagem de erro para o utilizador corrigir os parâmetros inseridos 
                return View();
            }

            if (!float.TryParse(B, out float b))
            {
                //A não é numero
                //Falta gerar uma mensagem de erro para o utilizador corrigir os parâmetros inseridos 
                return View();
            }

            if (!float.TryParse(C, out float c))
            {
                //A não é numero
                //Falta gerar uma mensagem de erro para o utilizador corrigir os parâmetros inseridos 
                return View();
            }


            //2.2 - A !=0

            if (a ==0)
            {
                return View();
            }

            //3º - Seguir para o calculo

            //3.1 - Calcular o DELTA  (B^2 - 4ac)
            float delta = (b*b) - (4 * a * c);

            //3.2 Se DELTA >=0   ->>>>>>RAÍZ REAL
            if(delta >= 0) {
                //3.2.1 Calcular raízes reais  
                float x1 = (-b + MathF.Sqrt(delta)) / 2*a;
                float x2 = (-b - MathF.Sqrt(delta)) / 2*a;

                ViewBag.X1 = x1;
                ViewBag.X2 = x2;
            }

            //3.3 Caso Contrario ->>>>>>RAÍZ COMPLEXA CONJUGADA 
            else
            {
                //3.3.1 Calcular raízes complexas   
            }




            //3.4 Informar o utilizador das raízes calculadas


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
