using Matematica;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraGrafica.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ObtenerSuma(int primerNumero, int segundpNumero)
        {
                Calculadora calculadora = new Calculadora();
            calculadora.PrimerNumero = primerNumero;
            calculadora.SegundoNumero = segundpNumero;
            calculadora.Sumar();
        ViewBag.Sumar = calculadora.Resultado;

            return View();
        }
    }
}




