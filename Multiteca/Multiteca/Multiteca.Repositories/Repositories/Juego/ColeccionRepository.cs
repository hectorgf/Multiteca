using NHibernate;
using NHibernate.Entities.Juego;
using NHibernateApp.Persistence;
using System;
using System.Collections.Generic;

namespace Multiteca.Repositories.Juego
{
    public class ColeccionRepository : IColeccionRepository
    {

        private ISession _session;

        public ColeccionRepository()
        {
            _session = SessionManager.Instance.Session;
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
                ICriteria criteria = _session.CreateCriteria(typeof(ColeccionEntity));
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
                return _session.Get<ColeccionEntity>(id);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public bool Edit(ColeccionEntity coleccion)
        {
            _session.Transaction.Begin();

            try
            {
                var editColeccion = this.GetById(coleccion.Id);
                editColeccion.Nombre = coleccion.Nombre;
                editColeccion.Descripcion = coleccion.Descripcion;
                editColeccion.Saga = coleccion.Saga;

                _session.Update(editColeccion);
                _session.Flush();
                _session.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {  
                return false;
                throw new NotImplementedException();
            }
        }
    }
}