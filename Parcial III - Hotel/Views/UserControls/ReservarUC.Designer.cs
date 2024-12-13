namespace Parcial_III___Hotel.Views.UserControls
{
    partial class ReservarUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblReservarUC_Nombre = new Label();
            lblReservarUC_Celular = new Label();
            lblReservarUC_Correo = new Label();
            lblReservarUC_Membresia = new Label();
            lblReservarUC_FechaEntrada = new Label();
            lblReservarUC_FechaSalida = new Label();
            dtgvReservarUC_Habitaciones = new DataGridView();
            txtbReservarUC_Nombre = new TextBox();
            txtbReservarUC_Celular = new TextBox();
            txtbReservarUC_Correo = new TextBox();
            cmboxReservarUC_Membresia = new ComboBox();
            dtpReservarUC_FechaEntrada = new DateTimePicker();
            dtpReservarUC_FechaSalida = new DateTimePicker();
            btnReservarUC_MostrarHabitaciones = new Button();
            btnReservarUC_Cotizar = new Button();
            btnReservarUC_Reservar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvReservarUC_Habitaciones).BeginInit();
            SuspendLayout();
            // 
            // lblReservarUC_Nombre
            // 
            lblReservarUC_Nombre.AutoSize = true;
            lblReservarUC_Nombre.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_Nombre.Location = new Point(137, 235);
            lblReservarUC_Nombre.Name = "lblReservarUC_Nombre";
            lblReservarUC_Nombre.Size = new Size(127, 36);
            lblReservarUC_Nombre.TabIndex = 1;
            lblReservarUC_Nombre.Text = "Nombre";
            // 
            // lblReservarUC_Celular
            // 
            lblReservarUC_Celular.AutoSize = true;
            lblReservarUC_Celular.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_Celular.Location = new Point(157, 310);
            lblReservarUC_Celular.Name = "lblReservarUC_Celular";
            lblReservarUC_Celular.Size = new Size(107, 36);
            lblReservarUC_Celular.TabIndex = 2;
            lblReservarUC_Celular.Text = "Celular";
            // 
            // lblReservarUC_Correo
            // 
            lblReservarUC_Correo.AutoSize = true;
            lblReservarUC_Correo.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_Correo.Location = new Point(156, 384);
            lblReservarUC_Correo.Name = "lblReservarUC_Correo";
            lblReservarUC_Correo.Size = new Size(108, 36);
            lblReservarUC_Correo.TabIndex = 3;
            lblReservarUC_Correo.Text = "Correo";
            // 
            // lblReservarUC_Membresia
            // 
            lblReservarUC_Membresia.AutoSize = true;
            lblReservarUC_Membresia.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_Membresia.Location = new Point(100, 455);
            lblReservarUC_Membresia.Name = "lblReservarUC_Membresia";
            lblReservarUC_Membresia.Size = new Size(164, 36);
            lblReservarUC_Membresia.TabIndex = 4;
            lblReservarUC_Membresia.Text = "Membresia";
            // 
            // lblReservarUC_FechaEntrada
            // 
            lblReservarUC_FechaEntrada.AutoSize = true;
            lblReservarUC_FechaEntrada.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_FechaEntrada.Location = new Point(20, 572);
            lblReservarUC_FechaEntrada.Name = "lblReservarUC_FechaEntrada";
            lblReservarUC_FechaEntrada.Size = new Size(244, 36);
            lblReservarUC_FechaEntrada.TabIndex = 5;
            lblReservarUC_FechaEntrada.Text = "Fecha de entrada";
            // 
            // lblReservarUC_FechaSalida
            // 
            lblReservarUC_FechaSalida.AutoSize = true;
            lblReservarUC_FechaSalida.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_FechaSalida.Location = new Point(47, 632);
            lblReservarUC_FechaSalida.Name = "lblReservarUC_FechaSalida";
            lblReservarUC_FechaSalida.Size = new Size(217, 36);
            lblReservarUC_FechaSalida.TabIndex = 6;
            lblReservarUC_FechaSalida.Text = "Fecha de salida";
            // 
            // dtgvReservarUC_Habitaciones
            // 
            dtgvReservarUC_Habitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvReservarUC_Habitaciones.Location = new Point(650, 235);
            dtgvReservarUC_Habitaciones.Name = "dtgvReservarUC_Habitaciones";
            dtgvReservarUC_Habitaciones.RowHeadersWidth = 51;
            dtgvReservarUC_Habitaciones.Size = new Size(664, 373);
            dtgvReservarUC_Habitaciones.TabIndex = 7;
            // 
            // txtbReservarUC_Nombre
            // 
            txtbReservarUC_Nombre.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbReservarUC_Nombre.Location = new Point(280, 233);
            txtbReservarUC_Nombre.Name = "txtbReservarUC_Nombre";
            txtbReservarUC_Nombre.Size = new Size(330, 38);
            txtbReservarUC_Nombre.TabIndex = 8;
            // 
            // txtbReservarUC_Celular
            // 
            txtbReservarUC_Celular.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbReservarUC_Celular.Location = new Point(280, 308);
            txtbReservarUC_Celular.Name = "txtbReservarUC_Celular";
            txtbReservarUC_Celular.Size = new Size(330, 38);
            txtbReservarUC_Celular.TabIndex = 9;
            // 
            // txtbReservarUC_Correo
            // 
            txtbReservarUC_Correo.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbReservarUC_Correo.Location = new Point(280, 382);
            txtbReservarUC_Correo.Name = "txtbReservarUC_Correo";
            txtbReservarUC_Correo.Size = new Size(330, 38);
            txtbReservarUC_Correo.TabIndex = 10;
            // 
            // cmboxReservarUC_Membresia
            // 
            cmboxReservarUC_Membresia.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmboxReservarUC_Membresia.FormattingEnabled = true;
            cmboxReservarUC_Membresia.Location = new Point(280, 453);
            cmboxReservarUC_Membresia.Name = "cmboxReservarUC_Membresia";
            cmboxReservarUC_Membresia.Size = new Size(330, 38);
            cmboxReservarUC_Membresia.TabIndex = 11;
            // 
            // dtpReservarUC_FechaEntrada
            // 
            dtpReservarUC_FechaEntrada.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReservarUC_FechaEntrada.Location = new Point(280, 570);
            dtpReservarUC_FechaEntrada.Name = "dtpReservarUC_FechaEntrada";
            dtpReservarUC_FechaEntrada.Size = new Size(330, 38);
            dtpReservarUC_FechaEntrada.TabIndex = 12;
            // 
            // dtpReservarUC_FechaSalida
            // 
            dtpReservarUC_FechaSalida.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReservarUC_FechaSalida.Location = new Point(280, 630);
            dtpReservarUC_FechaSalida.Name = "dtpReservarUC_FechaSalida";
            dtpReservarUC_FechaSalida.Size = new Size(330, 38);
            dtpReservarUC_FechaSalida.TabIndex = 13;
            dtpReservarUC_FechaSalida.Value = new DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // btnReservarUC_MostrarHabitaciones
            // 
            btnReservarUC_MostrarHabitaciones.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservarUC_MostrarHabitaciones.Location = new Point(661, 172);
            btnReservarUC_MostrarHabitaciones.Name = "btnReservarUC_MostrarHabitaciones";
            btnReservarUC_MostrarHabitaciones.Size = new Size(404, 41);
            btnReservarUC_MostrarHabitaciones.TabIndex = 14;
            btnReservarUC_MostrarHabitaciones.Text = "Checar habitaciones disponibles";
            btnReservarUC_MostrarHabitaciones.UseVisualStyleBackColor = true;
            // 
            // btnReservarUC_Cotizar
            // 
            btnReservarUC_Cotizar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservarUC_Cotizar.Location = new Point(661, 627);
            btnReservarUC_Cotizar.Name = "btnReservarUC_Cotizar";
            btnReservarUC_Cotizar.Size = new Size(133, 41);
            btnReservarUC_Cotizar.TabIndex = 15;
            btnReservarUC_Cotizar.Text = "Cotizar";
            btnReservarUC_Cotizar.UseVisualStyleBackColor = true;
            // 
            // btnReservarUC_Reservar
            // 
            btnReservarUC_Reservar.BackColor = Color.PaleGreen;
            btnReservarUC_Reservar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservarUC_Reservar.Location = new Point(820, 627);
            btnReservarUC_Reservar.Name = "btnReservarUC_Reservar";
            btnReservarUC_Reservar.Size = new Size(133, 41);
            btnReservarUC_Reservar.TabIndex = 16;
            btnReservarUC_Reservar.Text = "Reservar";
            btnReservarUC_Reservar.UseVisualStyleBackColor = false;
            // 
            // ReservarUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnReservarUC_Reservar);
            Controls.Add(btnReservarUC_Cotizar);
            Controls.Add(btnReservarUC_MostrarHabitaciones);
            Controls.Add(dtpReservarUC_FechaSalida);
            Controls.Add(dtpReservarUC_FechaEntrada);
            Controls.Add(cmboxReservarUC_Membresia);
            Controls.Add(txtbReservarUC_Correo);
            Controls.Add(txtbReservarUC_Celular);
            Controls.Add(txtbReservarUC_Nombre);
            Controls.Add(dtgvReservarUC_Habitaciones);
            Controls.Add(lblReservarUC_FechaSalida);
            Controls.Add(lblReservarUC_FechaEntrada);
            Controls.Add(lblReservarUC_Membresia);
            Controls.Add(lblReservarUC_Correo);
            Controls.Add(lblReservarUC_Celular);
            Controls.Add(lblReservarUC_Nombre);
            Name = "ReservarUC";
            Size = new Size(1448, 804);
            ((System.ComponentModel.ISupportInitialize)dtgvReservarUC_Habitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblReservarUC_Nombre;
        private Label lblReservarUC_Celular;
        private Label lblReservarUC_Correo;
        private Label lblReservarUC_Membresia;
        private Label lblReservarUC_FechaEntrada;
        private Label lblReservarUC_FechaSalida;
        public DataGridView dtgvReservarUC_Habitaciones;
        public TextBox txtbReservarUC_Nombre;
        public TextBox txtbReservarUC_Celular;
        public TextBox txtbReservarUC_Correo;
        public ComboBox cmboxReservarUC_Membresia;
        public DateTimePicker dtpReservarUC_FechaEntrada;
        public DateTimePicker dtpReservarUC_FechaSalida;
        public Button btnReservarUC_MostrarHabitaciones;
        public Button btnReservarUC_Cotizar;
        public Button btnReservarUC_Reservar;
    }
}
