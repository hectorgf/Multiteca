using AutoMapper;
using Multiteca.Models.Juego;
using Multiteca.Repositories;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiteca.Services
{
    public class JuegoService : IJuegoService
    {
        private IJuegoRepository JuegoRepository = new JuegoRepository();
        private IColeccionRepository ColeccionRepository = new ColeccionRepository();

        #region Juego
        public List<ListaJuegoModel> GetList()
        {
            try
            {
                return Mapper.Map<List<ListaJuegoModel>>(JuegoRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public JuegoModel GetById(Guid id)
        {
            try
            {
                return Mapper.Map<JuegoModel>(JuegoRepository.GetById(id));
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Colección
        public List<ColeccionModel> ColeccionList()
        {
            try
            {
                return Mapper.Map<List<ColeccionModel>>(ColeccionRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}