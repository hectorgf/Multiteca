using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface IColeccionRepository
    {
        //void Create(ColeccionEntity entity);
        IEnumerable<ColeccionEntity> GetList();
        ColeccionEntity GetById(Guid id);
    }
}
