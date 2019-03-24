using FluentNHibernate.Mapping;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class DistribuidorEntity : BaseNameDescEntity
    {
        public DistribuidorEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class DistribuidorMap : ClassMap<DistribuidorEntity>
    {
        public DistribuidorMap()
        {
            Table("GM_Distribuidor");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");
        }
    }
}