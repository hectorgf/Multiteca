using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class ColeccionRepository : IColeccionRepository
    {

        private ISession Session;

        public ColeccionRepository()
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

        public IEnumerable<ColeccionEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(ColeccionEntity));
                return criteria.List<ColeccionEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public ColeccionEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<ColeccionEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}