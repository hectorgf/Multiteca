using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Multiteca.Models.Juego
{
    public enum EstadoJuego
    {
        Pendiente = 0,
        Comprado = 1,
        Jugado = 2,
        Compeltado = 3,
        Abandonado = 4
    }

    public class JuegoModel
    {
        public virtual Guid Id { get; set; }

        [DisplayName("Nombre")]
        public virtual string Nombre { get; set; }

        [DisplayName("Fecha de lanzamiento")]
        public virtual DateTime? FechaLanzamiento { get; set; }

        [DisplayName("Colección")]
        public virtual ColeccionModel Coleccion { get; set; }

        [DisplayName("Nº de colección")]
        public virtual int NumColeccion { get; set; }

        [DisplayName("Desarrollador")]
        public virtual DesarrolladorModel Desarrollador { get; set; }

        [DisplayName("Distribuidor")]
        public virtual DistribuidorModel Distribuidor { get; set; }

        [DisplayName("Precio propuesto")]
        public virtual decimal PrecioPropuesto { get; set; }

        [DisplayName("Deseado")]
        public virtual bool Deseado { get; set; }

        [DisplayName("Plataforma deseada")]
        public virtual PlataformaModel PlataformaDeseada { get; set; }

        [DisplayName("Comprado")]
        public virtual bool Comprado { get; set; }

        [DisplayName("Tienda")]
        public virtual TiendaModel TiendaComprado { get; set; }

        [DisplayName("Precio")]
        public virtual decimal PrecioCompra { get; set; }

        [DisplayName("Plataforma")]
        public virtual PlataformaModel PlataformaCompra { get; set; }

        [DisplayName("Formato")]
        public virtual FormatoModel FormatoCompra { get; set; }

        [DisplayName("Estado")]
        public virtual EstadoJuego Estado { get; set; }

        [DisplayName("Nota")]
        public virtual int NotaJugado { get; set; }

        [DisplayName("Review")]
        public virtual string ReviewJugado { get; set; }

        [DisplayName("Nota")]
        public virtual int NotaFinal { get; set; }

        [DisplayName("Fecha de finalización")]
        public virtual DateTime? FechaCompleto { get; set; }

        [DisplayName("Review")]
        public virtual string ReviewFinal { get; set; }

        [DisplayName("Fecha de abandono")]
        public virtual DateTime? FechaAbandono { get; set; }

        [DisplayName("Notas de abandono")]
        public virtual string NotasAbandono { get; set; }

        [DisplayName("Géneros")]
        public virtual IList<GeneroModel> Generos { get; set; }

        [DisplayName("Saga")]
        public virtual SagaModel Saga { get; set; }
    }

    public class ListaJuegoModel
    {
        public virtual Guid Id { get; set; }

        [DisplayName("Nombre")]
        public virtual string Nombre { get; set; }

        [DisplayName("Colección")]
        public virtual string Coleccion { get; set; }

        [DisplayName("Nº")]
        public virtual string NumColeccion { get; set; }

        [DisplayName("Desarrollador")]
        public virtual string Desarrollador { get; set; }

        [DisplayName("Distribuidor")]
        public virtual string Distribuidor { get; set; }

        [DisplayName("Precio")]
        public virtual decimal Precio { get; set; }

        [DisplayName("Estado")]
        public virtual EstadoJuego Estado { get; set; }

        [DisplayName("Géneros")]
        public virtual string Generos { get; set; }

        [DisplayName("Saga")]
        public virtual string Saga { get; set; }

        [DisplayName("Review")]
        public virtual string Review { get; set; }
    }

    public class ColeccionModel : BaseNameDescModel
    {

    }

    public class SagaModel : BaseNameDescModel
    {
        public virtual JuegoModel Juego { get; set; }
        public virtual ColeccionModel Coleccion { get; set; }
    }

    public class TiendaModel : BaseNameDescModel
    {

    }

    public class DistribuidorModel : BaseNameDescModel
    {

    }

    public class FormatoModel : BaseNameDescModel
    {

    }

    public class GeneroModel : BaseNameDescModel
    {

    }

    public class PlataformaModel : BaseNameDescModel
    {

    }

    public class DesarrolladorModel : BaseNameDescModel
    {

    }
}