using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace CapaLogica
{
    public class ReservaCorporativa : Reserva
    {
        private const decimal Descuento = 0.10m;

        public override decimal Total
        {
            get
            {
                decimal montoDescuento = Subtotal * Descuento;
                return Subtotal - montoDescuento;
            }
        }

        public ReservaCorporativa(string nombreCliente, string correoCliente,
                                   string tipoSala, DateTime fechaReserva, int cantidadHoras)
            : base(nombreCliente, correoCliente, "Corporativa", tipoSala, fechaReserva, cantidadHoras)
        {
        }
    }
}

