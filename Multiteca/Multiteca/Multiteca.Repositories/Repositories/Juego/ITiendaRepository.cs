using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface ITiendaRepository
    {
        //void Create(TiendaEntity entity);
        IEnumerable<TiendaEntity> GetList();
        TiendaEntity GetById(Guid id);
    }
}