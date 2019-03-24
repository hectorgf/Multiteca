using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories
{
    public class DistribuidorRepository : IDistribuidorRepository
    {

        private ISession Session;

        public DistribuidorRepository()
        {
            Session = SessionManager.Instance.Session;
        }

        //public void Create(DistribuidorEntity entity)
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

        public IEnumerable<DistribuidorEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(DistribuidorEntity));
                return criteria.List<DistribuidorEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public DistribuidorEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<DistribuidorEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}