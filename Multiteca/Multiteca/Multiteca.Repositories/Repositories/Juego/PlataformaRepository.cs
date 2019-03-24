using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class PlataformaRepository : IPlataformaRepository
    {

        private ISession Session;

        public PlataformaRepository()
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

        public IEnumerable<PlataformaEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(PlataformaEntity));
                return criteria.List<PlataformaEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public PlataformaEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<PlataformaEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}