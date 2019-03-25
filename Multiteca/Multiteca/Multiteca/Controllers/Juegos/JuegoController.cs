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

            ViewBag.Saga = new SelectList(JuegoService.SagaList(), "Id", "Nombre", juego.Saga != null ? juego.Saga.Id.ToString() : juego.Coleccion != null ? juego.Coleccion.Saga.Id.ToString() : null);
            ViewBag.Coleccion = new SelectList(JuegoService.ColeccionList(), "Id", "Nombre", juego.Coleccion != null ? juego.Coleccion.Id.ToString() : null);
            ViewBag.Desarrollador = new SelectList(JuegoService.DesarrolladorList(), "Id", "Nombre", juego.Desarrollador != null ? juego.Desarrollador.Id.ToString() : null);
            ViewBag.Distribuidor = new SelectList(JuegoService.DistribuidorList(), "Id", "Nombre", juego.Distribuidor != null ? juego.Distribuidor.Id.ToString() : null);
            ViewBag.PlataformaDeseada = new SelectList(JuegoService.PlataformaList(), "Id", "Nombre", juego.PlataformaDeseada != null ? juego.PlataformaDeseada.Id.ToString() : null);
            ViewBag.Tienda = new SelectList(JuegoService.TiendaList(), "Id", "Nombre", juego.TiendaComprado != null ? juego.TiendaComprado.Id.ToString() : null);
            ViewBag.PlataformaCompra = new SelectList(JuegoService.PlataformaList(), "Id", "Nombre", juego.PlataformaCompra != null ? juego.PlataformaCompra.Id.ToString() : null);
            ViewBag.FormatoCompra = new SelectList(JuegoService.FormatoList(), "Id", "Nombre", juego.FormatoCompra != null ? juego.FormatoCompra.Id.ToString() : null);

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
