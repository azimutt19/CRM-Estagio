using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SITE.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Dashboard";

            return View();
        }

        public ActionResult Administracao()
        {
            ViewBag.Message = "Administração";

            return View();
        }

        public ActionResult Clientes()
        {
            ViewBag.Message = "Clientes";

            return View();
        }

        public ActionResult Empresas()
        {
            ViewBag.Message = "Empresas";

            return View();
        }

        public ActionResult Agenda()
        {
            ViewBag.Message = "Agenda";

            return View();
        }

        public ActionResult Criarcliente()
        {
            ViewBag.Message = "Cliente";

            return View();
        }

        public ActionResult Criarempresa()
        {
            ViewBag.Message = "Empresa";

            return View();
        }

        public ActionResult Detalhescliente()
        {
            ViewBag.Message = "ID + Cliente";

            return View();
        }

        public ActionResult Detalhesempresa()
        {
            ViewBag.Message = "ID + Empresa";

            return View();
        }

        public ActionResult Detalhesutilizador()
        {
            ViewBag.Message = "ID + Utilizador";

            return View();
        }

        public ActionResult Editarcliente()
        {
            ViewBag.Message = "ID + Cliente";

            return View();
        }

        public ActionResult Editarempresa()
        {
            ViewBag.Message = "ID + Empresa";

            return View();
        }



    }
}