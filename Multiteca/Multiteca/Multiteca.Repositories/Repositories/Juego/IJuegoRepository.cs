using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories
{
    public interface IJuegoRepository
    {
        void Create(JuegoEntity entity);
        IEnumerable<JuegoEntity> GetList();
        JuegoEntity GetById(Guid id);
    }
}
