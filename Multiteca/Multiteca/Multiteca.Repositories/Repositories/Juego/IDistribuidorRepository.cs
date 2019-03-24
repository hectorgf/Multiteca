using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface IDistribuidorRepository
    {
        //void Create(DistribuidorEntity entity);
        IEnumerable<DistribuidorEntity> GetList();
        DistribuidorEntity GetById(Guid id);
    }
}
