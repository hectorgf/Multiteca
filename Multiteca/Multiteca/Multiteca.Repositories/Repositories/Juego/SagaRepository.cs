using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class SagaRepository : ISagaRepository
    {

        private ISession Session;

        public SagaRepository()
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

        public IEnumerable<SagaEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(SagaEntity));
                return criteria.List<SagaEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public SagaEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<SagaEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}