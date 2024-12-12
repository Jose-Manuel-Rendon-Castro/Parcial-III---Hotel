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
            SuspendLayout();
            // 
            // ReservarUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Name = "ReservarUC";
            Size = new Size(1448, 804);
            ResumeLayout(false);
        }

        #endregion
        public Label lblReservar_Nombre;
        public Label lblCelular;
        public Label lblCorreo;
        public Label lblMembresia;
        private Label label1;
        public ComboBox comboBox_ReservarUC_TipoDeMembresia;
        public DataGridView dgvReservar_MostrarHabitaciones;
        public Button btnReservar_ChecarHabitaciones;
        public Label lblReservar_FechaInicio;
        public Label lblReserva_FechaSalida;
        public Button btnReservar_Cotizar;
        public TextBox txtReservar_Nombre;
        public TextBox txtReservar_Celular;
        public TextBox txtReservar_Correo;
        public DateTimePicker dtpReserva_FechaInicio;
        public DateTimePicker dtpReservar_FechaSalida;
        public Button btnReservar_CrearReservacion;
    }
}
