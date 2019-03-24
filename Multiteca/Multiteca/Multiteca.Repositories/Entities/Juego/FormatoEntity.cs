using FluentNHibernate.Mapping;
using NHibernate.Entities.Juego;

namespace NHibernate.Entities.Juego
{
    public class FormatoEntity : BaseNameDescEntity
    {
        public FormatoEntity()
        {

        }
    }
}

namespace NHibernate.Mapping.Juego
{
    public class FormatoMap : ClassMap<FormatoEntity>
    {
        public FormatoMap()
        {
            Table("GM_Formato");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Descripcion).Column("Descripcion");
        }
    }
}