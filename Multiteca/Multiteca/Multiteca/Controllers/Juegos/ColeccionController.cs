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
            List<ColeccionModel> juegos = JuegoService.ColeccionList();
            return View(juegos);
        }

        // GET: ListaJuego/Edit/5
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            ColeccionModel coleccion = JuegoService.GetColeccionById(id);

            ViewBag.Saga = new SelectList(JuegoService.SagaList(), "Id", "Nombre", coleccion.Saga != null ? coleccion.Saga.Id.ToString() : null);

            return View("Edit", coleccion);
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, ColeccionModel coleccion)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
