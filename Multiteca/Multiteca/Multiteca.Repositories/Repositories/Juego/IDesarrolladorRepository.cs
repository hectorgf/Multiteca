using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories
{
    public interface IDesarrolladorRepository
    {
        //void Create(JuegoEntity entity);
        IEnumerable<DesarrolladorEntity> GetList();
        DesarrolladorEntity GetById(Guid id);
    }
}
