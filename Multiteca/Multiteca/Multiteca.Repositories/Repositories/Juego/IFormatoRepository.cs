using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface IFormatoRepository
    {
        //void Create(FormatoEntity entity);
        IEnumerable<FormatoEntity> GetList();
        FormatoEntity GetById(Guid id);
    }
}
