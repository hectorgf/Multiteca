using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories
{
    public interface IColeccionRepository
    {
        //void Create(JuegoEntity entity);
        IEnumerable<ColeccionEntity> GetList();
        ColeccionEntity GetById(Guid id);
    }
}
