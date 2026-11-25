
using CapaLogica;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace ExamenFinalProgra_Jefferson_Marin_Calvo
{
    public partial class Form1 : Form
    {
        private AdministradorReservas _admin;
        private Reserva _reservaEnEdicion;




        public Form1()
        {
            InitializeComponent();
            _admin = new AdministradorReservas();
            _reservaEnEdicion = null;
            ConfigurarControles();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarControles()
        {
            cboTipoReserva.Items.AddRange(new string[] { "Individual", "Corporativa" });
            cboTipoSala.Items.AddRange(new string[] { "Sala de podcast", "Sala de video y streaming" });

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 4;
            numericUpDown1.Value = 1;
            dtpFechaReserva.MinDate = DateTime.Now;

            cboTipoSala.SelectedIndexChanged += CalcularTotal;
            cboTipoReserva.SelectedIndexChanged += CalcularTotal;
            numericUpDown1.ValueChanged += CalcularTotal;
        }

        private void CalcularTotal(object sender, EventArgs e)
        {
            if (cboTipoSala.SelectedItem == null || cboTipoReserva.SelectedItem == null)
            {
                lblTotal.Text = "Total: ₡0.00";
                return;
            }

            string tipoSala = cboTipoSala.SelectedItem.ToString();
            string tipoReserva = cboTipoReserva.SelectedItem.ToString();
            int horas = (int)numericUpDown1.Value;

            Reserva reservaTemp;
            if (tipoReserva == "Corporativa")
            {
                reservaTemp = new ReservaCorporativa("Temp", "temp@correo.com", tipoSala, DateTime.Now.AddDays(1), horas);
            }
            else
            {
                reservaTemp = new Reserva("Temp", "temp@correo.com", tipoReserva, tipoSala, DateTime.Now.AddDays(1), horas);
            }

            lblTotal.Text = $"Total: ₡{reservaTemp.Total:N2}";
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                errorProvider1.SetError(txtNombreCliente, "Ingrese el nombre del cliente");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido con @");
                esValido = false;
            }

            if (cboTipoReserva.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboTipoReserva, "Seleccione un tipo de reserva");
                esValido = false;
            }

            if (cboTipoSala.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboTipoSala, "Seleccione un tipo de sala");
                esValido = false;
            }

            if (dtpFechaReserva.Value <= DateTime.Now)
            {
                errorProvider1.SetError(dtpFechaReserva, "Seleccione una fecha y hora futura");
                esValido = false;
            }

            return esValido;
        }




        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = _admin.ObtenerTodas();
            FormatearGrid();
            ActualizarResumen();
        }

        private void FormatearGrid()
        {
            if (dgvReservas.Columns.Count > 0)
            {
                dgvReservas.Columns["CodigoReserva"].HeaderText = "Código";
                dgvReservas.Columns["NombreCliente"].HeaderText = "Cliente";
                dgvReservas.Columns["CorreoCliente"].HeaderText = "Correo";
                dgvReservas.Columns["TipoReserva"].HeaderText = "Tipo";
                dgvReservas.Columns["TipoSala"].HeaderText = "Sala";
                dgvReservas.Columns["FechaReserva"].HeaderText = "Fecha Reserva";
                dgvReservas.Columns["CantidadHoras"].HeaderText = "Horas";
                dgvReservas.Columns["Total"].HeaderText = "Total";
                dgvReservas.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void ActualizarResumen()
        {
            lblResumen.Text = $"Reservas registradas: {_admin.CantidadReservas()} | Monto total: ₡{_admin.MontoTotalAcumulado():N2}";
        }




        //Nuevos métodos para manejar eventos de los controles
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Corrija los errores indicados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = txtNombreCliente.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string tipoReserva = cboTipoReserva.SelectedItem.ToString();
                string tipoSala = cboTipoSala.SelectedItem.ToString();
                DateTime fecha = dtpFechaReserva.Value;
                int horas = (int)numericUpDown1.Value;

                if (_reservaEnEdicion != null)
                {
                    Reserva reservaActualizada;
                    if (tipoReserva == "Corporativa")
                    {
                        reservaActualizada = new ReservaCorporativa(nombre, correo, tipoSala, fecha, horas);
                    }
                    else
                    {
                        reservaActualizada = new Reserva(nombre, correo, tipoReserva, tipoSala, fecha, horas);
                    }

                    bool exito = _admin.EditarReserva(_reservaEnEdicion.CodigoReserva, reservaActualizada);

                    if (exito)
                        MessageBox.Show(" Reserva actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(" No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _reservaEnEdicion = null;
                    btnRegistrar.Text = "Registrar Reserva";
                }
                else
                {
                    Reserva nuevaReserva;
                    if (tipoReserva == "Corporativa")
                    {
                        nuevaReserva = new ReservaCorporativa(nombre, correo, tipoSala, fecha, horas);
                    }
                    else
                    {
                        nuevaReserva = new Reserva(nombre, correo, tipoReserva, tipoSala, fecha, horas);
                    }

                    _admin.AgregarReserva(nuevaReserva);
                    MessageBox.Show($" Reserva registrada\nCódigo: {nuevaReserva.CodigoReserva}\nTotal: ₡{nuevaReserva.Total:N2}",
                                    "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnLimpiar_Click(sender, e);
                ActualizarResumen();
                btnConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Ingrese un nombre para buscar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvReservas.DataSource = null;
            dgvReservas.DataSource = _admin.BuscarPorNombre(busqueda);
            FormatearGrid();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string codigo = dgvReservas.SelectedRows[0].Cells["CodigoReserva"].Value.ToString();
            Reserva reservaSeleccionada = _admin.ObtenerPorCodigo(codigo);
            if (reservaSeleccionada != null)
            {
                _reservaEnEdicion = reservaSeleccionada;
                txtNombreCliente.Text = reservaSeleccionada.NombreCliente;
                txtCorreo.Text = reservaSeleccionada.CorreoCliente;
                cboTipoReserva.SelectedItem = reservaSeleccionada.TipoReserva;
                cboTipoSala.SelectedItem = reservaSeleccionada.TipoSala;
                dtpFechaReserva.Value = reservaSeleccionada.FechaReserva;
                numericUpDown1.Value = reservaSeleccionada.CantidadHoras;
                btnRegistrar.Text = "Actualizar Reserva";
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string codigo = dgvReservas.SelectedRows[0].Cells["CodigoReserva"].Value.ToString();

            DialogResult confirmacion = MessageBox.Show($"¿Eliminar la reserva {codigo}?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (_admin.EliminarReserva(codigo))
                {
                    MessageBox.Show(" Reserva eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarResumen();
                    btnConsultar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(" No se pudo eliminar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Clear();
            txtCorreo.Clear();
            cboTipoReserva.SelectedIndex = -1;
            cboTipoSala.SelectedIndex = -1;
            dtpFechaReserva.Value = DateTime.Now.AddDays(1);
            numericUpDown1.Value = 1;
            lblTotal.Text = "Total: ₡0.00";
            errorProvider1.Clear();
            _reservaEnEdicion = null;
            btnRegistrar.Text = "Registrar Reserva";
            txtBuscar.Clear();
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimizarRE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

//USE CreativeStudioDB;

//CREATE TABLE TipoSala
//(
//    IdTipoSala INT PRIMARY KEY IDENTITY(1,1),
//    Nombre VARCHAR(100) NOT NULL,
//    TarifaPorHora DECIMAL(10,2) NOT NULL,
//    Descripcion VARCHAR(250) NULL                
//);



//CREATE TABLE Reserva
//(
//    IdReserva INT PRIMARY KEY IDENTITY(1,1),
//    NombreCliente VARCHAR(150) NOT NULL,
//    CorreoCliente VARCHAR(100) NOT NULL,
//    TipoReserva VARCHAR(50) NOT NULL,
//    FechaReserva DATETIME NOT NULL,
  //  CantidadHoras INT NOT NULL,
    //IdTipoSala INT NOT NULL,
    //TarifaAplicada DECIMAL(10,2) NOT NULL,
    //Total DECIMAL(10,2) NOT NULL,
    //FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),


    //*CONSTRAINT FK_Reserva_TipoSala 
       // FOREIGN KEY (IdTipoSala) REFERENCES TipoSala(IdTipoSala)
       // ON DELETE NO ACTION
        //ON UPDATE CASCADE
//);



//INSERT INTO TipoSala(Nombre, TarifaPorHora, Descripcion)
//VALUES
//(
    //'Sala de podcast',
    //7000.00,
    //'Espacio equipado con micrófonos profesionales, mezcladora y ambiente insonorizado para grabación de podcasts.'
//),
//(
    //'Sala de video y streaming',
    //10000.00,
   // 'Espacio amplio con iluminación profesional, cámaras de alta definición y conexión de alta velocidad para transmisiones en vivo y producción de video.'
//);



//SELECT
  //  IdTipoSala,
    //Nombre,
    //CONCAT('₡', TarifaPorHora) AS TarifaPorHora,
    //Descripcion
//FROM TipoSala;



//SELECT
  //  IdReserva,
    //NombreCliente,
    //CorreoCliente,
   // TipoReserva,
   // FechaReserva,
    //CantidadHoras,
    //TarifaAplicada,
    //Total,
    //FechaRegistro
//FROM Reserva;



//INSERT INTO Reserva
//(
    //NombreCliente,
    //CorreoCliente,
    //TipoReserva,
    //FechaReserva,
    //CantidadHoras,
    //IdTipoSala,
   // TarifaAplicada,
  //  Total
//)
//VALUES
//(
    //'Cliente de Prueba',
    //'prueba@correo.com',
    //'Individual',
    //'2026-12-01 14:00:00',
   // 2,
    //1,
    //7000.00,
  //  14000.00
//);



//SELECT* FROM Reserva;



//DELETE FROM Reserva
//WHERE NombreCliente = 'Cliente de Prueba';



//SELECT* FROM Reserva;/*




















