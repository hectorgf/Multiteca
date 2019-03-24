﻿using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class FormatoRepository : IFormatoRepository
    {

        private ISession Session;

        public FormatoRepository()
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

        public IEnumerable<FormatoEntity> GetList()
        {
            try
            {
                ICriteria criteria = Session.CreateCriteria(typeof(FormatoEntity));
                return criteria.List<FormatoEntity>();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public FormatoEntity GetById(Guid id)
        {
            try
            {
                return Session.Get<FormatoEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}