using AutoMapper;
using Multiteca.Models.Juego;
using Multiteca.Repositories.Juego;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace Multiteca.Services
{
    public class JuegoService : IJuegoService
    {
        private IJuegoRepository JuegoRepository = new JuegoRepository();
        private IColeccionRepository ColeccionRepository = new ColeccionRepository();
        private IDesarrolladorRepository DesarrolladorRepository = new DesarrolladorRepository();
        private IDistribuidorRepository DistribuidorRepository = new DistribuidorRepository();
        private IFormatoRepository FormatoRepository = new FormatoRepository();
        private IGeneroRepository GeneroRepository = new GeneroRepository();
        private IPlataformaRepository PlataformaRepository = new PlataformaRepository();
        private ISagaRepository SagaRepository = new SagaRepository();
        private ITiendaRepository TiendaRepository = new TiendaRepository();

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

        public ColeccionModel GetColeccionById(Guid id)
        {
            try
            {
                return Mapper.Map<ColeccionModel>(ColeccionRepository.GetById(id));
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public bool CrearColeccion(ColeccionModel coleccion)
        {
            return ColeccionRepository.Create(TransformColeccion(coleccion));
        }

        public bool ModificarColeccion(ColeccionModel coleccion)
        {
            return ColeccionRepository.Edit(TransformColeccion(coleccion));
        }

        private ColeccionEntity TransformColeccion(ColeccionModel coleccion)
        {
            var editColeccion = Mapper.Map<ColeccionEntity>(coleccion);
            editColeccion.Saga = SagaRepository.GetById(coleccion.SagaId);
            return editColeccion;
        }
        #endregion

        #region Desarrollador
        public List<DesarrolladorModel> DesarrolladorList()
        {
            try
            {
                return Mapper.Map<List<DesarrolladorModel>>(DesarrolladorRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Distribuidor
        public List<DistribuidorModel> DistribuidorList()
        {
            try
            {
                return Mapper.Map<List<DistribuidorModel>>(DistribuidorRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Formato
        public List<FormatoModel> FormatoList()
        {
            try
            {
                return Mapper.Map<List<FormatoModel>>(FormatoRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Género
        public List<GeneroModel> GeneroList()
        {
            try
            {
                return Mapper.Map<List<GeneroModel>>(GeneroRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Plataforma
        public List<PlataformaModel> PlataformaList()
        {
            try
            {
                return Mapper.Map<List<PlataformaModel>>(PlataformaRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Saga
        public List<SagaModel> SagaList()
        {
            try
            {
                return Mapper.Map<List<SagaModel>>(SagaRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Tienda
        public List<TiendaModel> TiendaList()
        {
            try
            {
                return Mapper.Map<List<TiendaModel>>(TiendaRepository.GetList());
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}