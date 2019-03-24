using Multiteca.Models.Juego;
using Multiteca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Multiteca.Controllers.Juego
{
    public class JuegoController : Controller
    {
        private IJuegoService JuegoService = new JuegoService();

        // GET: ListaJuego
        public ActionResult Index()
        {
            List<ListaJuegoModel> juegos = JuegoService.GetList();
            return View(juegos);
        }

        // GET: ListaJuego/Edit/5
        public ActionResult Edit(Guid id)
        {
            JuegoModel juego = JuegoService.GetById(id);
            
            ViewBag.Coleccion = new SelectList(JuegoService.ColeccionList(), "Id", "Nombre", juego.Coleccion);
            ViewBag.Desarrollador = new SelectList(JuegoService.DesarrolladorList(), "Id", "Nombre", juego.Desarrollador);
            ViewBag.Distribuidor = new SelectList(JuegoService.DistribuidorList(), "Id", "Nombre", juego.Distribuidor);
            ViewBag.PlataformaDeseada = new SelectList(JuegoService.PlataformaList(), "Id", "Nombre", juego.PlataformaDeseada);

            return View("Edit", juego);
        }

        // GET: ListaJuego/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListaJuego/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListaJuego/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
