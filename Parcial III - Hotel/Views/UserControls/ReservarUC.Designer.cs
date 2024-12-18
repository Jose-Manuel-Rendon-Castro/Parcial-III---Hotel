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
            lblReservarUC_FechaEntrada = new Label();
            lblReservarUC_FechaSalida = new Label();
            dtgvReservarUC_Habitaciones = new DataGridView();
            dtpReservarUC_FechaEntrada = new DateTimePicker();
            dtpReservarUC_FechaSalida = new DateTimePicker();
            btnReservarUC_MostrarHabitaciones = new Button();
            btnReservarUC_Cotizar = new Button();
            btnReservarUC_Reservar = new Button();
            lblReservarUC_Huesped = new Label();
            combxReservarUC_Huesped = new ComboBox();
            btnReservarUC_CrearHuesped = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvReservarUC_Habitaciones).BeginInit();
            SuspendLayout();
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
            // lblReservarUC_Huesped
            // 
            lblReservarUC_Huesped.AutoSize = true;
            lblReservarUC_Huesped.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservarUC_Huesped.Location = new Point(132, 229);
            lblReservarUC_Huesped.Name = "lblReservarUC_Huesped";
            lblReservarUC_Huesped.Size = new Size(142, 36);
            lblReservarUC_Huesped.TabIndex = 17;
            lblReservarUC_Huesped.Text = "Huesped:";
            // 
            // combxReservarUC_Huesped
            // 
            combxReservarUC_Huesped.DropDownHeight = 180;
            combxReservarUC_Huesped.FormattingEnabled = true;
            combxReservarUC_Huesped.IntegralHeight = false;
            combxReservarUC_Huesped.Location = new Point(280, 235);
            combxReservarUC_Huesped.MaxDropDownItems = 5;
            combxReservarUC_Huesped.Name = "combxReservarUC_Huesped";
            combxReservarUC_Huesped.Size = new Size(330, 28);
            combxReservarUC_Huesped.TabIndex = 1;
            // 
            // btnReservarUC_CrearHuesped
            // 
            btnReservarUC_CrearHuesped.BackColor = SystemColors.HotTrack;
            btnReservarUC_CrearHuesped.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservarUC_CrearHuesped.Location = new Point(434, 284);
            btnReservarUC_CrearHuesped.Name = "btnReservarUC_CrearHuesped";
            btnReservarUC_CrearHuesped.Size = new Size(176, 52);
            btnReservarUC_CrearHuesped.TabIndex = 2;
            btnReservarUC_CrearHuesped.Text = "Crear Huesped";
            btnReservarUC_CrearHuesped.UseVisualStyleBackColor = false;
            // 
            // ReservarUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnReservarUC_CrearHuesped);
            Controls.Add(combxReservarUC_Huesped);
            Controls.Add(lblReservarUC_Huesped);
            Controls.Add(btnReservarUC_Reservar);
            Controls.Add(btnReservarUC_Cotizar);
            Controls.Add(btnReservarUC_MostrarHabitaciones);
            Controls.Add(dtpReservarUC_FechaSalida);
            Controls.Add(dtpReservarUC_FechaEntrada);
            Controls.Add(dtgvReservarUC_Habitaciones);
            Controls.Add(lblReservarUC_FechaSalida);
            Controls.Add(lblReservarUC_FechaEntrada);
            Name = "ReservarUC";
            Size = new Size(1448, 804);
            ((System.ComponentModel.ISupportInitialize)dtgvReservarUC_Habitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblReservarUC_FechaEntrada;
        private Label lblReservarUC_FechaSalida;
        public DataGridView dtgvReservarUC_Habitaciones;
        public DateTimePicker dtpReservarUC_FechaEntrada;
        public DateTimePicker dtpReservarUC_FechaSalida;
        public Button btnReservarUC_MostrarHabitaciones;
        public Button btnReservarUC_Cotizar;
        public Button btnReservarUC_Reservar;
        private Label lblReservarUC_Huesped;
        public ComboBox combxReservarUC_Huesped;
        public Button btnReservarUC_CrearHuesped;
    }
}
