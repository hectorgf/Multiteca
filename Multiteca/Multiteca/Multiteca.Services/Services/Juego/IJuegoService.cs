using Multiteca.Models.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Services
{
    public interface IJuegoService
    {
        #region Juegos
        JuegoModel GetById(Guid id);

        List<ListaJuegoModel> GetList();
        #endregion Juegos

        #region Coleccion
        List<ColeccionModel> ColeccionList();

        ColeccionModel GetColeccionById(Guid id);

        bool CrearColeccion(ColeccionModel coleccion);

        bool ModificarColeccion(ColeccionModel coleccion);
        #endregion Coleccion

        #region Listas
        List<DesarrolladorModel> DesarrolladorList();

        List<DistribuidorModel> DistribuidorList();

        List<FormatoModel> FormatoList();

        List<GeneroModel> GeneroList();

        List<SagaModel> SagaList();

        List<TiendaModel> TiendaList();

        List<PlataformaModel> PlataformaList();
        #endregion Listas
    }
}
