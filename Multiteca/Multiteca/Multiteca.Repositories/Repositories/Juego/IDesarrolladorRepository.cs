using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface IDesarrolladorRepository
    {
        //void Create(DesarrolladorEntity entity);
        IEnumerable<DesarrolladorEntity> GetList();
        DesarrolladorEntity GetById(Guid id);
    }
}
