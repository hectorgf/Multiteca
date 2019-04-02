using Multiteca.Models.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Services
{
    public interface IJuegoService
    {
        JuegoModel GetById(Guid id);
        List<ListaJuegoModel> GetList();

        List<ColeccionModel> ColeccionList();
        ColeccionModel GetColeccionById(Guid id);

        List<DesarrolladorModel> DesarrolladorList();

        List<DistribuidorModel> DistribuidorList();

        List<FormatoModel> FormatoList();

        List<GeneroModel> GeneroList();

        List<SagaModel> SagaList();

        List<TiendaModel> TiendaList();

        List<PlataformaModel> PlataformaList();
    }
}
