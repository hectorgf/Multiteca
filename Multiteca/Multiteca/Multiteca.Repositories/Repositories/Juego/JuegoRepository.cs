using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories
{
    public class JuegoRepository : IJuegoRepository
    {

        private ISession Session;

        public JuegoRepository()
        {
            Session = SessionManager.Instance.Session;
        }

        public void Create(JuegoEntity entity)
        {
            try
            {
                Session.Save(entity);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<JuegoEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(JuegoEntity));
                return criteria.List<JuegoEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public JuegoEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<JuegoEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}