using ExercicioUm.Controllers.DAO;
using ExercicioUm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioUm.Controllers
{
    public class PessoaController : Controller
    {

        private PessoaDao pdao = new PessoaDao();

        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }


        // GET: Pessoa/Create/
        [HttpPost]
        public ActionResult Create([Bind(Include = "Nome, DataNascimento, Cpf, Email, Telefone")] Pessoa pessoa)
        {
            pdao.Create(pessoa);
            
            return RedirectToAction("Find");
        }

        public ActionResult Find()
        {
            Pessoa pessoa = pdao.Find(6);
            ViewBag.Pessoa = pessoa;
            return View();
        }
    }
}