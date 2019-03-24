using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class TiendaRepository : ITiendaRepository
    {

        private ISession Session;

        public TiendaRepository()
        {
            Session = SessionManager.Instance.Session;
        }

        //public void Create(ColeccionEntity entity)
        //{
        //    try
        //    {
        //        Session.Save(entity);
        //    }
        //    catch (Exception)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public IEnumerable<TiendaEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(TiendaEntity));
                return criteria.List<TiendaEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public TiendaEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<TiendaEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}