using Multiteca.Models.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Services
{
    public interface IJuegoService
    {
        List<ListaJuegoModel> GetList();
        JuegoModel GetById(Guid id);
    }
}
