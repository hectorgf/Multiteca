using System;
using System.ComponentModel;

namespace Multiteca.Models
{
    public class BaseNameDescModel
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Nombre")]
        public virtual string Nombre { get; set; }
        [DisplayName("Descripción")]
        public virtual string Descripcion { get; set; }
    }
}