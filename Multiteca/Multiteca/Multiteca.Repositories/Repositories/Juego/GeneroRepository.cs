using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class GeneroRepository : IGeneroRepository
    {

        private ISession Session;

        public GeneroRepository()
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

        public IEnumerable<GeneroEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(GeneroEntity));
                return criteria.List<GeneroEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public GeneroEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<GeneroEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}