using FluentNHibernate.Mapping;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class DesarrolladorEntity : BaseNameDescEntity
    {
        public DesarrolladorEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class DesarrolladorMap : ClassMap<DesarrolladorEntity>
    {
        public DesarrolladorMap()
        {
            Table("GM_Desarrollador");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");
        }
    }
}