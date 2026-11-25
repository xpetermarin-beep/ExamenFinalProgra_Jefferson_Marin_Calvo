namespace ExamenFinalProgra_Jefferson_Marin_Calvo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            cboTipoReserva = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cboTipoSala = new ComboBox();
            dtpFechaReserva = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnRegistrar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label8 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            label9 = new Label();
            lblTotal = new Label();
            label10 = new Label();
            lblResumen = new Label();
            dgvReservas = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            btnCerrar = new PictureBox();
            btnminimizarRE = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, 18);
            label1.Name = "label1";
            label1.Size = new Size(319, 34);
            label1.TabIndex = 0;
            label1.Text = "Creative Studio ofrece";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(219, 23);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE DEL CLIENTE:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(253, 82);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(393, 27);
            txtNombreCliente.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(242, 23);
            label3.TabIndex = 3;
            label3.Text = "CORREO ELECTRONICO:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(260, 128);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(386, 27);
            txtCorreo.TabIndex = 4;
            // 
            // cboTipoReserva
            // 
            cboTipoReserva.FormattingEnabled = true;
            cboTipoReserva.Items.AddRange(new object[] { "Individual", "Corporativa" });
            cboTipoReserva.Location = new Point(236, 184);
            cboTipoReserva.Name = "cboTipoReserva";
            cboTipoReserva.Size = new Size(151, 28);
            cboTipoReserva.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 184);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 6;
            label4.Text = "TIPO DE RESERVA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 232);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 7;
            label5.Text = "TIPO DE SALA:";
            // 
            // cboTipoSala
            // 
            cboTipoSala.FormattingEnabled = true;
            cboTipoSala.Items.AddRange(new object[] { "Sala de podcast", "Sala de video y streaming" });
            cboTipoSala.Location = new Point(202, 232);
            cboTipoSala.Name = "cboTipoSala";
            cboTipoSala.Size = new Size(151, 28);
            cboTipoSala.TabIndex = 8;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Location = new Point(253, 282);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(250, 27);
            dtpFechaReserva.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 282);
            label6.Name = "label6";
            label6.Size = new Size(200, 23);
            label6.TabIndex = 10;
            label6.Text = "FECHA DE RESERVA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(47, 327);
            label7.Name = "label7";
            label7.Size = new Size(223, 23);
            label7.TabIndex = 11;
            label7.Text = "CANTIDAD DE HORAS:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(276, 328);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(128, 412);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 42);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(276, 412);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 42);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1436, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 42);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(791, 267);
            label8.Name = "label8";
            label8.Size = new Size(205, 23);
            label8.TabIndex = 16;
            label8.Text = "NOMBRE A BUSCAR:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1002, 263);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(291, 27);
            txtBuscar.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1299, 248);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 42);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1358, 203);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 42);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(815, 147);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 20;
            label9.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(894, 150);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(815, 203);
            label10.Name = "label10";
            label10.Size = new Size(104, 23);
            label10.TabIndex = 22;
            label10.Text = "RESUMEN:";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(925, 206);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(0, 20);
            lblResumen.TabIndex = 23;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(624, 312);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(968, 262);
            dgvReservas.TabIndex = 24;
            dgvReservas.CellContentClick += dgvReservas_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1589, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 30);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 25;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizarRE
            // 
            btnminimizarRE.Image = (Image)resources.GetObject("btnminimizarRE.Image");
            btnminimizarRE.Location = new Point(1554, 0);
            btnminimizarRE.Name = "btnminimizarRE";
            btnminimizarRE.Size = new Size(29, 30);
            btnminimizarRE.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizarRE.TabIndex = 26;
            btnminimizarRE.TabStop = false;
            btnminimizarRE.Click += btnminimizarRE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1616, 805);
            Controls.Add(btnminimizarRE);
            Controls.Add(btnCerrar);
            Controls.Add(dgvReservas);
            Controls.Add(lblResumen);
            Controls.Add(label10);
            Controls.Add(lblTotal);
            Controls.Add(label9);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpFechaReserva);
            Controls.Add(cboTipoSala);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboTipoReserva);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtNombreCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreCliente;
        private Label label3;
        private TextBox txtCorreo;
        private ComboBox cboTipoReserva;
        private Label label4;
        private Label label5;
        private ComboBox cboTipoSala;
        private DateTimePicker dtpFechaReserva;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label8;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label label9;
        private Label lblTotal;
        private Label label10;
        private Label lblResumen;
        private DataGridView dgvReservas;
        private ErrorProvider errorProvider1;
        private PictureBox btnminimizarRE;
        private PictureBox btnCerrar;
    }
}
