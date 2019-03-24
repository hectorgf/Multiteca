using FluentNHibernate.Mapping;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class TiendaEntity : BaseNameDescEntity
    {
        public TiendaEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class TiendaMap : ClassMap<TiendaEntity>
    {
        public TiendaMap()
        {
            Table("GM_Tienda");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");
        }
    }
}