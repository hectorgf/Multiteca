using FluentNHibernate.Mapping;
using NHibernate.Entities;
using System;
using System.Collections.Generic;

namespace NHibernate.Entities
{
    public class BaseNameDescEntity
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual string Descripcion { get; set; }

        public BaseNameDescEntity()
        {

        }
    }
}