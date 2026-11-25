using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaLogica
{
    public class AdministradorReservas
    {
        private List<Reserva> _listaReservas;

        public AdministradorReservas()
        {
            _listaReservas = new List<Reserva>();
        }

        public void AgregarReserva(Reserva reserva)
        {
            _listaReservas.Add(reserva);
        }

        public List<Reserva> ObtenerTodas()
        {
            return _listaReservas.ToList();
        }

        public List<Reserva> BuscarPorNombre(string nombre)
        {
            return _listaReservas
                .Where(r => r.NombreCliente.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public bool EliminarReserva(string codigo)
        {
            Reserva reserva = _listaReservas.FirstOrDefault(r => r.CodigoReserva == codigo);
            if (reserva != null)
            {
                _listaReservas.Remove(reserva);
                return true;
            }
            return false;
        }


        public Reserva ObtenerPorCodigo(string codigoReserva)
        {
            return _listaReservas.FirstOrDefault(r => r.CodigoReserva == codigoReserva);
        }






        public bool EditarReserva(string codigoReserva, Reserva reservaActualizada)
        {
            int indice = _listaReservas.FindIndex(r => r.CodigoReserva == codigoReserva);
            if (indice >= 0)
            {
                reservaActualizada.CodigoReserva = _listaReservas[indice].CodigoReserva;
                reservaActualizada.FechaRegistro = _listaReservas[indice].FechaRegistro;
                _listaReservas[indice] = reservaActualizada;
                return true;
            }
            return false;
        }

        public int CantidadReservas()
        {
            return _listaReservas.Count;
        }

        public decimal MontoTotalAcumulado()
        {
            decimal total = 0;
            foreach (Reserva r in _listaReservas)
            {
                total += r.Total;
            }
            return total;
        }
    }
}


