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
    }
}
