using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories
{
    public interface IDistribuidorRepository
    {
        //void Create(DistribuidorEntity entity);
        IEnumerable<DistribuidorEntity> GetList();
        DistribuidorEntity GetById(Guid id);
    }
}
