using FluentNHibernate.Mapping;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class SagaEntity : BaseNameDescEntity
    {
        public virtual IList<JuegoEntity> Juego { get; set; }
        public virtual IList<ColeccionEntity> Coleccion { get; set; }
        public SagaEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class SagaMap : ClassMap<SagaEntity>
    {
        public SagaMap()
        {
            Table("GM_Saga");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");

            HasManyToMany<JuegoEntity>(x => x.Juego).Table("GM_REL_Saga_Juego").ParentKeyColumn("Saga").ChildKeyColumn("Juego");
            HasManyToMany<ColeccionEntity>(x => x.Coleccion).Table("GM_REL_Saga_Coleccion").ParentKeyColumn("Saga").ChildKeyColumn("Coleccion");
        }
    }
}