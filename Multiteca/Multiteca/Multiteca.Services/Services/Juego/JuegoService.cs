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

        public List<ListaJuegoModel> GetList()
        {
            try
            {
                List<ListaJuegoModel> result = new List<ListaJuegoModel>();

                foreach (var item in JuegoRepository.GetList())
                {
                    ListaJuegoModel obj = new ListaJuegoModel();

                    obj.Id = item.Id;
                    obj.Nombre = item.Nombre;
                    if (item.Coleccion != null)
                    {
                        obj.Coleccion = item.Coleccion.Nombre;
                        obj.NumColeccion = item.NumColeccion.ToString();
                    }
                    else
                    {
                        obj.Coleccion = "-";
                        obj.NumColeccion = "-";
                    }
                    obj.Desarrollador = item.Desarrollador != null ? item.Desarrollador.Nombre : "-";
                    obj.Distribuidor = item.Distribuidor != null ? item.Distribuidor.Nombre : "-";
                    obj.Estado = (EstadoJuego)item.Estado;
                    obj.Precio = item.PrecioPropuesto;

                    if (item.Generos != null && item.Generos.Count > 0)
                    {
                        foreach (var genero in item.Generos)
                        {
                            obj.Generos += genero.Nombre + ", ";
                        }
                        obj.Generos = obj.Generos.Substring(0, obj.Generos.Length - 2);
                    }
                    else
                        obj.Generos = "-";

                    if (item.Saga != null && item.Saga.Count > 0)
                    {
                        obj.Saga = item.Saga.FirstOrDefault().Nombre;
                    }
                    else if (item.Coleccion != null && item.Coleccion.Saga != null && item.Coleccion.Saga.Count > 0)
                    {
                        obj.Saga = item.Coleccion.Saga.FirstOrDefault().Nombre;
                    }
                    else
                        obj.Saga = "-";

                    if (string.IsNullOrEmpty(item.ReviewFinal))
                        obj.Review = item.ReviewJugado;
                    else
                        obj.Review = item.ReviewFinal;

                    result.Add(obj);
                }

                return result;
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
                JuegoModel detail = null;
                var juego = JuegoRepository.GetById(id);

                if (juego != null)
                {
                    detail = new JuegoModel()
                    {
                        Id = juego.Id,
                        Nombre = juego.Nombre,
                        FechaLanzamiento = juego.FechaLanzamiento,
                        Coleccion = juego.Coleccion == null ? null : new ColeccionModel()
                        {
                            Id = juego.Coleccion.Id,
                            Nombre = juego.Coleccion.Nombre,
                            Descripcion = juego.Coleccion.Descripcion
                        },
                        NumColeccion = juego.NumColeccion,
                        Desarrollador = juego.Desarrollador == null ? null : new DesarrolladorModel()
                        {
                            Id = juego.Desarrollador.Id,
                            Nombre = juego.Desarrollador.Nombre,
                            Descripcion = juego.Desarrollador.Descripcion
                        },
                        Distribuidor = juego.Distribuidor == null ? null : new DistribuidorModel()
                        {
                            Id = juego.Distribuidor.Id,
                            Nombre = juego.Distribuidor.Nombre,
                            Descripcion = juego.Distribuidor.Descripcion
                        },
                        PrecioPropuesto = juego.PrecioPropuesto,
                        Deseado = juego.Deseado,
                        PlataformaDeseada = juego.PlataformaDeseada == null ? null : new PlataformaModel()
                        {
                            Id = juego.PlataformaDeseada.Id,
                            Nombre = juego.PlataformaDeseada.Nombre,
                            Descripcion = juego.PlataformaDeseada.Descripcion
                        },
                        Comprado = juego.Comprado,
                        TiendaComprado = juego.TiendaComprado == null ? null : new TiendaModel()
                        {
                            Id = juego.TiendaComprado.Id,
                            Nombre = juego.TiendaComprado.Nombre,
                            Descripcion = juego.TiendaComprado.Descripcion
                        },
                        PrecioCompra = juego.PrecioCompra,
                        PlataformaCompra = juego.PlataformaCompra == null ? null : new PlataformaModel()
                        {
                            Id = juego.PlataformaCompra.Id,
                            Nombre = juego.PlataformaCompra.Nombre,
                            Descripcion = juego.PlataformaCompra.Descripcion
                        },
                        FormatoCompra = juego.FormatoCompra == null ? null : new FormatoModel()
                        {
                            Id = juego.FormatoCompra.Id,
                            Nombre = juego.FormatoCompra.Nombre,
                            Descripcion = juego.FormatoCompra.Descripcion
                        },
                        Estado = (EstadoJuego)juego.Estado,
                        NotaJugado = juego.NotaJugado,
                        ReviewJugado = juego.ReviewJugado,
                        NotaFinal = juego.NotaFinal,
                        FechaCompleto = juego.FechaCompleto,
                        ReviewFinal = juego.ReviewFinal,
                        NotasAbandono = juego.NotasAbandono,
                        Generos = (juego.Generos == null || juego.Generos.Count == 0) ? null : new List<GeneroModel>() /*{
                            x => juego.Generos.ForEach(y => new GeneroModel
                        {
                            Id = y.Id,
                            Nombre = y.Nombre,
                            Descripcion = y.Descripcion
                        })
                        }*/,
                        Saga = (juego.Saga != null && juego.Saga.Count > 0) ? new SagaModel {
                            Id = juego.Saga.FirstOrDefault().Id,
                            Nombre = juego.Saga.FirstOrDefault().Nombre,
                            Descripcion = juego.Saga.FirstOrDefault().Descripcion,
                            Juego = null,
                            Coleccion = null 
                        } : null
                    };
                }

                return detail;
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
    }
}