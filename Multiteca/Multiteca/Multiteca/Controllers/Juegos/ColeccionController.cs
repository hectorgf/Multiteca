using Multiteca.Models.Juego;
using Multiteca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Multiteca.Controllers.Juego
{
    public class ColeccionController : Controller
    {
        private IJuegoService JuegoService = new JuegoService();

        // GET: ListaJuego
        public ActionResult Index()
        {
            List<ColeccionModel> colecciones = JuegoService.ColeccionList();
            return View(colecciones);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Saga = new SelectList(JuegoService.SagaList(), "Id", "Nombre", null);
            return View("Create", new ColeccionModel());
        }

        [HttpPost]
        public ActionResult Create(ColeccionModel coleccion)
        {
            JuegoService.CrearColeccion(coleccion);
            ViewBag.Saga = new SelectList(JuegoService.SagaList(), "Id", "Nombre", coleccion.Saga != null ? coleccion.Saga.Id.ToString() : null);
            return View("Edit", coleccion);
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var coleccion = JuegoService.GetColeccionById(id);
            ViewBag.Saga = new SelectList(JuegoService.SagaList(), "Id", "Nombre", coleccion.Saga != null ? coleccion.Saga.Id.ToString() : null);
            return View("Edit", coleccion);
        }

        [HttpPost]
        public ActionResult Edit(ColeccionModel coleccion)
        {
            JuegoService.ModificarColeccion(coleccion);

            List<ColeccionModel> colecciones = JuegoService.ColeccionList();
            return View("Index", colecciones);
        }

        // GET: Default/Delete/5
        public ActionResult Delete(Guid id)
        {
            var coleccion = JuegoService.GetColeccionById(id);
            ViewBag.Saga = new SelectList(JuegoService.SagaList(), "Id", "Nombre", coleccion.Saga != null ? coleccion.Saga.Id.ToString() : null);
            return View("Delete", coleccion);
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, ColeccionModel coleccion)
        {
            try
            {
                JuegoService.EliminarColeccion(coleccion);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
