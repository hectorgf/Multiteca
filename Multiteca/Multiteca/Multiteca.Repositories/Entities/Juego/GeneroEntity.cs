using FluentNHibernate.Mapping;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities.Juego
{
    public class GeneroEntity : BaseNameDescEntity
    {
        public virtual IList<JuegoEntity> Juegos { get; set; }

        public GeneroEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class GeneroMap : ClassMap<GeneroEntity>
    {
        public GeneroMap()
        {
            Table("GM_Genero");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");

            HasManyToMany<JuegoEntity>(x => x.Juegos).Table("GM_REL_Generos_Juego").ParentKeyColumn("Genero").ChildKeyColumn("Juego");
        }
    }
}