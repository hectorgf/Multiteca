using FluentNHibernate.Mapping;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class ColeccionEntity : BaseNameDescEntity
    {
        public virtual IList<SagaEntity> Saga { get; set; }
        public ColeccionEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class ColeccionMap : ClassMap<ColeccionEntity>
    {
        public ColeccionMap()
        {
            Table("GM_Coleccion");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");

            HasManyToMany<SagaEntity>(x => x.Saga).Table("GM_REL_Saga_Coleccion").ParentKeyColumn("Coleccion").ChildKeyColumn("Saga");
        }
    }
}