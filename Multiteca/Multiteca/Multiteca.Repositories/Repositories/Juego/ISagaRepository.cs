using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface ISagaRepository
    {
        //void Create(SagaEntity entity);
        IEnumerable<SagaEntity> GetList();
        SagaEntity GetById(Guid id);
    }
}