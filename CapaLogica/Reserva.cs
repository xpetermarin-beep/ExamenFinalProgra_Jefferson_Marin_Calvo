using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace CapaLogica
{
    public class Reserva
    {
        private string _nombreCliente;
        private string _correoCliente;
        private string _tipoReserva;
        private string _tipoSala;
        private DateTime _fechaReserva;
        private int _cantidadHoras;
        private DateTime _fechaRegistro;
        private string _codigoReserva;

        public const decimal TarifaPodcast = 7000m;
        public const decimal TarifaVideoStreaming = 10000m;

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        public string CorreoCliente
        {
            get { return _correoCliente; }
            set { _correoCliente = value; }
        }

        public string TipoReserva
        {
            get { return _tipoReserva; }
            set { _tipoReserva = value; }
        }

        public string TipoSala
        {
            get { return _tipoSala; }
            set { _tipoSala = value; }
        }

        public DateTime FechaReserva
        {
            get { return _fechaReserva; }
            set { _fechaReserva = value; }
        }

        public int CantidadHoras
        {
            get { return _cantidadHoras; }
            set { _cantidadHoras = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        public string CodigoReserva
        {
            get { return _codigoReserva; }
            set { _codigoReserva = value; }
        }

        public virtual decimal TarifaPorHora
        {
            get
            {
                return _tipoSala == "Sala de podcast" ? TarifaPodcast : TarifaVideoStreaming;
            }
        }

        public decimal Subtotal
        {
            get { return TarifaPorHora * _cantidadHoras; }
        }

        public virtual decimal Total
        {
            get { return Subtotal; }
        }

        public Reserva(string nombreCliente, string correoCliente, string tipoReserva,
                       string tipoSala, DateTime fechaReserva, int cantidadHoras)
        {
            _nombreCliente = nombreCliente;
            _correoCliente = correoCliente;
            _tipoReserva = tipoReserva;
            _tipoSala = tipoSala;
            _fechaReserva = fechaReserva;
            _cantidadHoras = cantidadHoras;
            _fechaRegistro = DateTime.Now;
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            _codigoReserva = "RES-" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
    }
}