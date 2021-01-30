using System.Collections.Generic;
using System.Web.Mvc;
using WebAppEmprestimo.Models;
using WebAppEmprestimo.Negocio;

namespace WebAppEmprestimo.Controllers
{
    public class HomeController : Controller
    {
        RegraNegocio regraNegocio = new RegraNegocio();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //public ActionResult DadosCliente(FormCollection collection)
        //{
        //    return View();
        //}

        public ActionResult PaginaDadosCliente()
        {

            return View();
        }

      
        [HttpPost]
        public ActionResult EspelhoProposta(PropostaEmprestimo proposta, DadosCliente dadosCliente)
        {
            ViewBag.emprestimos = new List<PropostaEmprestimo>();
            ViewBag.emprestimos = regraNegocio.CalculoPropostaEmprestimo(proposta);
            ViewBag.DetalheProposta = new PropostaEmprestimo();
            ViewBag.DetalheProposta.ClienteProposta = dadosCliente;

            return View();
        }

        public ActionResult Obrigado()
        {
            return View();
        }
    }
}