using AutoMapper;
using Multiteca.Models.Juego;
using NHibernate.Entities.Juego;
using System.Linq;

namespace Multiteca.Services.Profiles
{
    public class JuegoProfile : Profile
    {
        private const string NOT_DATA = "-";

        public JuegoProfile()
        {
            CreateMap<JuegoModel, JuegoEntity>();
            CreateMap<JuegoEntity, JuegoModel>()
                .ForMember(dest => dest.Saga, opt => opt.MapFrom(src => src.Saga.FirstOrDefault()));

            CreateMap<ListaJuegoModel, JuegoEntity>();
            CreateMap<JuegoEntity, ListaJuegoModel>()
                .ForMember(dest => dest.Coleccion, opt => opt.MapFrom(src => src.Coleccion != null ? src.Coleccion.Nombre : NOT_DATA))
                .ForMember(dest => dest.Desarrollador, opt => opt.MapFrom(src => src.Desarrollador != null ? src.Desarrollador.Nombre : NOT_DATA))
                .ForMember(dest => dest.Distribuidor, opt => opt.MapFrom(src => src.Distribuidor != null ? src.Distribuidor.Nombre : NOT_DATA))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => (EstadoJuego)src.Estado))
                .ForMember(dest => dest.Precio, opt => opt.MapFrom(src => src.PrecioPropuesto))
                .ForMember(dest => dest.Generos, opt => opt.Ignore())
                .ForMember(dest => dest.Saga, opt => opt.MapFrom(src => src.Saga.FirstOrDefault() != null ? src.Saga.FirstOrDefault().Nombre : NOT_DATA))
                .ForMember(dest => dest.Review, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.ReviewFinal) ? src.ReviewJugado : src.ReviewFinal))
                .AfterMap((src, dest) => {
                    if (src.Generos != null && src.Generos.Count > 0)
                    {
                        foreach (var genero in src.Generos)
                        {
                            dest.Generos += genero.Nombre + ", ";
                        }
                        dest.Generos = dest.Generos.Substring(0, dest.Generos.Length - 2);
                    }
                    else
                        dest.Generos = NOT_DATA;
                });

            CreateMap<ColeccionModel, ColeccionEntity>()
                .ForMember(dest => dest.Saga, opt => opt.MapFrom(src => src.Saga));
            CreateMap<ColeccionEntity, ColeccionModel>()
                .ForMember(dest => dest.SagaId, opt => opt.MapFrom(src => src.Saga.Id));

            CreateMap<DesarrolladorModel, DesarrolladorEntity>();
            CreateMap<DesarrolladorEntity, DesarrolladorModel>();

            CreateMap<DistribuidorModel, DistribuidorEntity>();
            CreateMap<DistribuidorEntity, DistribuidorModel>();

            CreateMap<FormatoModel, FormatoEntity>();
            CreateMap<FormatoEntity, FormatoModel>();

            CreateMap<GeneroModel, GeneroEntity>();
            CreateMap<GeneroEntity, GeneroModel>();

            CreateMap<PlataformaModel, PlataformaEntity>();
            CreateMap<PlataformaEntity, PlataformaModel>();

            CreateMap<SagaModel, SagaEntity>();
            CreateMap<SagaEntity, SagaModel>();

            CreateMap<TiendaModel, TiendaEntity>();
            CreateMap<TiendaEntity, TiendaModel>();
        }
    }
}