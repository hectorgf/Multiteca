using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class DesarrolladorRepository : IDesarrolladorRepository
    {

        private ISession Session;

        public DesarrolladorRepository()
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

        public IEnumerable<DesarrolladorEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(DesarrolladorEntity));
                return criteria.List<DesarrolladorEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public DesarrolladorEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<DesarrolladorEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}