using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Necesidades;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class ListaController : Controller
    {
        // GET: Lista
        public ActionResult List()
        {
            var cat = CatalogoProvider.();
            return View("listado", cat);
        }
        [HttpGet]
        public ActionResult Procesos()
        {
            return View();
        }
    }
}