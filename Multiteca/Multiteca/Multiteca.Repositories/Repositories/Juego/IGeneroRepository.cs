using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public interface IGeneroRepository
    {
        //void Create(ColeccionEntity entity);
        IEnumerable<GeneroEntity> GetList();
        GeneroEntity GetById(Guid id);
    }
}