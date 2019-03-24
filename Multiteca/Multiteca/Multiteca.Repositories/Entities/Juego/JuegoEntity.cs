using FluentNHibernate.Mapping;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class JuegoEntity
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual DateTime? FechaLanzamiento { get; set; }
        public virtual ColeccionEntity Coleccion { get; set; }
        public virtual int NumColeccion { get; set; }
        public virtual DesarrolladorEntity Desarrollador { get; set; }
        public virtual DistribuidorEntity Distribuidor { get; set; }
        public virtual decimal PrecioPropuesto { get; set; }
        public virtual bool Deseado { get; set; }
        public virtual PlataformaEntity PlataformaDeseada { get; set; }
        public virtual bool Comprado { get; set; }
        public virtual TiendaEntity TiendaComprado { get; set; }
        public virtual decimal PrecioCompra { get; set; }
        public virtual PlataformaEntity PlataformaCompra { get; set; }
        public virtual FormatoEntity FormatoCompra { get; set; }
        public virtual int Estado { get; set; }
        public virtual int NotaJugado { get; set; }
        public virtual string ReviewJugado { get; set; }
        public virtual int NotaFinal { get; set; }
        public virtual DateTime? FechaCompleto { get; set; }
        public virtual string ReviewFinal { get; set; }
        public virtual DateTime? FechaAbandono { get; set; }
        public virtual string NotasAbandono { get; set; }
        public virtual IList<GeneroEntity> Generos { get; set; }
        public virtual IList<SagaEntity> Saga { get; set; }

        public JuegoEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class JuegoMap : ClassMap<JuegoEntity>
    {
        public JuegoMap()
        {
            Table("GM_Juego");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.NumColeccion).Column("NumColeccion");
            Map(x => x.FechaLanzamiento).Column("FechaLanzamiento");
            Map(x => x.PrecioPropuesto).Column("PrecioPropuesto");
            Map(x => x.Deseado).Column("Deseado");
            Map(x => x.Comprado).Column("Comprado");
            Map(x => x.PrecioCompra).Column("PrecioCompra");
            Map(x => x.Estado).Column("Estado");
            Map(x => x.NotaJugado).Column("NotaJugado");
            Map(x => x.ReviewJugado).Column("ReviewJugado");
            Map(x => x.NotaFinal).Column("NotaFinal");
            Map(x => x.FechaCompleto).Column("FechaCompleto");
            Map(x => x.ReviewFinal).Column("ReviewFinal");
            Map(x => x.FechaAbandono).Column("FechaAbandono");
            Map(x => x.NotasAbandono).Column("NotasAbandono");

            References(x => x.Coleccion, "Coleccion").ForeignKey("Id").LazyLoad();
            References(x => x.Desarrollador, "Desarrollador").ForeignKey("Id").LazyLoad();
            References(x => x.Distribuidor, "DistribuidorEspania").ForeignKey("Id").LazyLoad();
            References(x => x.PlataformaDeseada, "PlataformaDeseada").ForeignKey("Id").LazyLoad();
            References(x => x.TiendaComprado, "TiendaCompra").ForeignKey("Id").LazyLoad();
            References(x => x.PlataformaCompra, "PlataformaCompra").ForeignKey("Id").LazyLoad();
            References(x => x.FormatoCompra, "FormatoCompra").ForeignKey("Id").LazyLoad();

            HasManyToMany<GeneroEntity>(x => x.Generos).Table("GM_REL_Generos_Juego").ParentKeyColumn("Juego").ChildKeyColumn("Genero");
            HasManyToMany<SagaEntity>(x => x.Saga).Table("GM_REL_Saga_Juego").ParentKeyColumn("Juego").ChildKeyColumn("Saga");
        }
    }
}