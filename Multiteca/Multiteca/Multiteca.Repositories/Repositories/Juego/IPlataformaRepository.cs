using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface IPlataformaRepository
    {
        //void Create(PlataformaEntity entity);
        IEnumerable<PlataformaEntity> GetList();
        PlataformaEntity GetById(Guid id);
    }
}