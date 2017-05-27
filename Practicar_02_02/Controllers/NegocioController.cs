using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Dominio.Entidades;
using Dominio.Repositorio;

namespace Practicar_02_02.Controllers
{
    public class NegocioController : Controller
    {
        //
        clienteBL cliente = new clienteBL();
        paisBL pais = new paisBL();

        // GET: Negocio
        public ActionResult Index()
        {
            return View(cliente.listar());
        }

        public ActionResult Create() {
            return View(new clienteEntidad());
        }

        [HttpPost]
        public ActionResult Create(clienteEntidad reg) {

            //almacenar el resultado del proceso agregar
            string mensaje =cliente.Agregar(reg);

            return RedirectToAction("Index");

        }

        public ActionResult CreateCliente()
        {

            ViewBag.paises = new SelectList(pais.listarPais(),"idpais","nombrepais");


            return View(new clienteEntidad());
        }

        [HttpPost]
        public ActionResult CreateCliente(clienteEntidad reg)
        {
            ViewBag.paises = new SelectList(pais.listarPais(), "idpais", "nombrepais", reg.idpais);

            //almacenar el resultado del proceso agregar
            string mensaje = cliente.Agregar(reg);

            return RedirectToAction("Index");

        }

    }
}