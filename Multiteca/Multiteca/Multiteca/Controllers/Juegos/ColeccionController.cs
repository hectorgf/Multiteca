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
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
