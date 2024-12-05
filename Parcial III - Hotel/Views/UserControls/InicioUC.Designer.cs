namespace Parcial_III___Hotel.Views.UserControls
{
    partial class InicioUC
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
            lblInicioUC_Mensaje = new Label();
            SuspendLayout();
            // 
            // lblInicioUC_Mensaje
            // 
            lblInicioUC_Mensaje.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicioUC_Mensaje.Location = new Point(198, 433);
            lblInicioUC_Mensaje.Name = "lblInicioUC_Mensaje";
            lblInicioUC_Mensaje.Size = new Size(1061, 329);
            lblInicioUC_Mensaje.TabIndex = 0;
            lblInicioUC_Mensaje.Text = "Bienvenido al Sistema de Hotel Suite Savage";
            lblInicioUC_Mensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InicioUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblInicioUC_Mensaje);
            Name = "InicioUC";
            Size = new Size(1448, 804);
            ResumeLayout(false);
        }

        #endregion

        public Label lblInicioUC_Mensaje;
        private Label label1;
    }
}
