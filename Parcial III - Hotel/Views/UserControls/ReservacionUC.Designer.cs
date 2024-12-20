﻿namespace Parcial_III___Hotel.Views.UserControls
{
    partial class ReservacionUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionUC));
            btnMostrar = new Button();
            cmbDisponibilidad = new ComboBox();
            lblDisponibilidad = new Label();
            cmbVista = new ComboBox();
            txtBusquedaNPersona = new TextBox();
            dataGridViewHabitaciones = new DataGridView();
            imgMostrar = new PictureBox();
            imgLimpieza = new PictureBox();
            lblVistas = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnLimpiarCampos = new Button();
            numPrecioMax = new NumericUpDown();
            numPrecioMin = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            cmbTipoHabitacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLimpieza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioMin).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.ActiveCaption;
            btnMostrar.FlatAppearance.BorderColor = Color.LightCoral;
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrar.Location = new Point(1187, 18);
            btnMostrar.Margin = new Padding(2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(167, 97);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            // 
            // cmbDisponibilidad
            // 
            cmbDisponibilidad.FormattingEnabled = true;
            cmbDisponibilidad.Location = new Point(71, 147);
            cmbDisponibilidad.Margin = new Padding(2);
            cmbDisponibilidad.Name = "cmbDisponibilidad";
            cmbDisponibilidad.Size = new Size(146, 28);
            cmbDisponibilidad.TabIndex = 3;
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.BackColor = SystemColors.Control;
            lblDisponibilidad.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisponibilidad.Location = new Point(71, 108);
            lblDisponibilidad.Margin = new Padding(2, 0, 2, 0);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(149, 27);
            lblDisponibilidad.TabIndex = 4;
            lblDisponibilidad.Text = "Disponibilidad";
            // 
            // cmbVista
            // 
            cmbVista.FormattingEnabled = true;
            cmbVista.Location = new Point(338, 268);
            cmbVista.Margin = new Padding(2);
            cmbVista.Name = "cmbVista";
            cmbVista.Size = new Size(146, 28);
            cmbVista.TabIndex = 6;
            // 
            // txtBusquedaNPersona
            // 
            txtBusquedaNPersona.Location = new Point(605, 146);
            txtBusquedaNPersona.Margin = new Padding(2);
            txtBusquedaNPersona.Name = "txtBusquedaNPersona";
            txtBusquedaNPersona.Size = new Size(359, 27);
            txtBusquedaNPersona.TabIndex = 12;
            // 
            // dataGridViewHabitaciones
            // 
            dataGridViewHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHabitaciones.Location = new Point(0, 334);
            dataGridViewHabitaciones.Margin = new Padding(2);
            dataGridViewHabitaciones.Name = "dataGridViewHabitaciones";
            dataGridViewHabitaciones.RowHeadersWidth = 62;
            dataGridViewHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHabitaciones.ShowCellToolTips = false;
            dataGridViewHabitaciones.Size = new Size(1448, 489);
            dataGridViewHabitaciones.TabIndex = 13;
            // 
            // imgMostrar
            // 
            imgMostrar.AccessibleRole = AccessibleRole.None;
            imgMostrar.BackColor = Color.LightCoral;
            imgMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            imgMostrar.Image = (Image)resources.GetObject("imgMostrar.Image");
            imgMostrar.Location = new Point(1350, 18);
            imgMostrar.Margin = new Padding(2);
            imgMostrar.Name = "imgMostrar";
            imgMostrar.Size = new Size(98, 97);
            imgMostrar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMostrar.TabIndex = 15;
            imgMostrar.TabStop = false;
            // 
            // imgLimpieza
            // 
            imgLimpieza.Image = (Image)resources.GetObject("imgLimpieza.Image");
            imgLimpieza.Location = new Point(1350, 195);
            imgLimpieza.Margin = new Padding(2);
            imgLimpieza.Name = "imgLimpieza";
            imgLimpieza.Size = new Size(98, 97);
            imgLimpieza.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLimpieza.TabIndex = 16;
            imgLimpieza.TabStop = false;
            // 
            // lblVistas
            // 
            lblVistas.AutoSize = true;
            lblVistas.BackColor = SystemColors.Control;
            lblVistas.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVistas.Location = new Point(338, 232);
            lblVistas.Margin = new Padding(2, 0, 2, 0);
            lblVistas.Name = "lblVistas";
            lblVistas.Size = new Size(221, 27);
            lblVistas.TabIndex = 17;
            lblVistas.Text = "Vista de la habitacion ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = SystemColors.Control;
            lblPrecio.Font = new Font("Microsoft YaHei UI", 12F);
            lblPrecio.Location = new Point(320, 108);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(71, 27);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 228);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(189, 27);
            label1.TabIndex = 19;
            label1.Text = "Tipo de habitacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.Location = new Point(601, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(368, 27);
            label2.TabIndex = 20;
            label2.Text = "Busqueda por nombre de la persona:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(487, 45);
            label4.TabIndex = 22;
            label4.Text = "Busqueda de reservaciones";
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = SystemColors.ActiveCaption;
            btnLimpiarCampos.FlatAppearance.BorderColor = Color.LightCoral;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCampos.Location = new Point(1187, 195);
            btnLimpiarCampos.Margin = new Padding(2);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(167, 97);
            btnLimpiarCampos.TabIndex = 30;
            btnLimpiarCampos.Text = "Limpiar campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // numPrecioMax
            // 
            numPrecioMax.Location = new Point(469, 147);
            numPrecioMax.Margin = new Padding(2);
            numPrecioMax.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrecioMax.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPrecioMax.Name = "numPrecioMax";
            numPrecioMax.Size = new Size(74, 27);
            numPrecioMax.TabIndex = 33;
            numPrecioMax.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numPrecioMin
            // 
            numPrecioMin.Location = new Point(324, 147);
            numPrecioMin.Margin = new Padding(2);
            numPrecioMin.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrecioMin.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPrecioMin.Name = "numPrecioMin";
            numPrecioMin.Size = new Size(74, 27);
            numPrecioMin.TabIndex = 34;
            numPrecioMin.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft YaHei UI", 12F);
            label8.Location = new Point(277, 147);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 27);
            label8.TabIndex = 35;
            label8.Text = "De";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Microsoft YaHei UI", 12F);
            label9.Location = new Point(420, 149);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(26, 27);
            label9.TabIndex = 36;
            label9.Text = "A";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(71, 266);
            cmbTipoHabitacion.Margin = new Padding(2);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(146, 28);
            cmbTipoHabitacion.TabIndex = 37;
            // 
            // ReservacionUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(numPrecioMin);
            Controls.Add(numPrecioMax);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(imgMostrar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPrecio);
            Controls.Add(lblVistas);
            Controls.Add(imgLimpieza);
            Controls.Add(dataGridViewHabitaciones);
            Controls.Add(txtBusquedaNPersona);
            Controls.Add(cmbVista);
            Controls.Add(lblDisponibilidad);
            Controls.Add(cmbDisponibilidad);
            Controls.Add(btnMostrar);
            Name = "ReservacionUC";
            Size = new Size(1448, 804);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLimpieza).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnMostrar;
        public ComboBox cmbDisponibilidad;
        private Label lblDisponibilidad;
        public TextBox txtBusquedaNPersona;
        public DataGridView dataGridViewHabitaciones;
        private PictureBox imgMostrar;
        private PictureBox imgLimpieza;
        private Label lblVistas;
        private Label lblPrecio;
        private Label label1;
        private Label label2;
        private Label label4;
        public Button btnLimpiarCampos;
        public ComboBox cmbVista;
        private Label label8;
        private Label label9;
        public NumericUpDown numPrecioMin;
        public NumericUpDown numPrecioMax;
        public ComboBox cmbTipoHabitacion;
    }
}
