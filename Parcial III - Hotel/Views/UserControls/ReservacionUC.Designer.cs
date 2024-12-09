namespace Parcial_III___Hotel.Views.UserControls
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
            cmbTipo_Habitacion = new ComboBox();
            txtPrecio = new TextBox();
            txtBusquedaNPersona = new TextBox();
            dataGridViewHabitaciones = new DataGridView();
            imgMostrar = new PictureBox();
            imgLimpieza = new PictureBox();
            lblVistas = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            calendario1 = new PictureBox();
            calendario2 = new PictureBox();
            btnLimpiarCampos = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLimpieza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendario1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendario2).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.CornflowerBlue;
            btnMostrar.FlatAppearance.BorderColor = Color.LightCoral;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrar.Location = new Point(1484, 22);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(209, 121);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            // 
            // cmbDisponibilidad
            // 
            cmbDisponibilidad.FormattingEnabled = true;
            cmbDisponibilidad.Location = new Point(93, 188);
            cmbDisponibilidad.Name = "cmbDisponibilidad";
            cmbDisponibilidad.Size = new Size(182, 33);
            cmbDisponibilidad.TabIndex = 3;
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.BackColor = Color.MediumTurquoise;
            lblDisponibilidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisponibilidad.Location = new Point(104, 127);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(158, 28);
            lblDisponibilidad.TabIndex = 4;
            lblDisponibilidad.Text = "Disponibilidad";
            // 
            // cmbVista
            // 
            cmbVista.FormattingEnabled = true;
            cmbVista.Location = new Point(381, 332);
            cmbVista.Name = "cmbVista";
            cmbVista.Size = new Size(182, 33);
            cmbVista.TabIndex = 6;
            // 
            // cmbTipo_Habitacion
            // 
            cmbTipo_Habitacion.FormattingEnabled = true;
            cmbTipo_Habitacion.Location = new Point(93, 332);
            cmbTipo_Habitacion.Name = "cmbTipo_Habitacion";
            cmbTipo_Habitacion.Size = new Size(182, 33);
            cmbTipo_Habitacion.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(400, 188);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 9;
            // 
            // txtBusquedaNPersona
            // 
            txtBusquedaNPersona.Location = new Point(883, 161);
            txtBusquedaNPersona.Name = "txtBusquedaNPersona";
            txtBusquedaNPersona.Size = new Size(150, 31);
            txtBusquedaNPersona.TabIndex = 12;
            // 
            // dataGridViewHabitaciones
            // 
            dataGridViewHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHabitaciones.Location = new Point(0, 418);
            dataGridViewHabitaciones.Name = "dataGridViewHabitaciones";
            dataGridViewHabitaciones.RowHeadersWidth = 62;
            dataGridViewHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHabitaciones.ShowCellToolTips = false;
            dataGridViewHabitaciones.Size = new Size(1810, 587);
            dataGridViewHabitaciones.TabIndex = 13;
            // 
            // imgMostrar
            // 
            imgMostrar.AccessibleRole = AccessibleRole.None;
            imgMostrar.BackColor = Color.LightCoral;
            imgMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            imgMostrar.Image = (Image)resources.GetObject("imgMostrar.Image");
            imgMostrar.Location = new Point(1688, 22);
            imgMostrar.Name = "imgMostrar";
            imgMostrar.Size = new Size(122, 121);
            imgMostrar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMostrar.TabIndex = 15;
            imgMostrar.TabStop = false;
            // 
            // imgLimpieza
            // 
            imgLimpieza.Image = (Image)resources.GetObject("imgLimpieza.Image");
            imgLimpieza.Location = new Point(1688, 244);
            imgLimpieza.Name = "imgLimpieza";
            imgLimpieza.Size = new Size(122, 121);
            imgLimpieza.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLimpieza.TabIndex = 16;
            imgLimpieza.TabStop = false;
            // 
            // lblVistas
            // 
            lblVistas.AutoSize = true;
            lblVistas.BackColor = Color.MediumTurquoise;
            lblVistas.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVistas.Location = new Point(381, 262);
            lblVistas.Name = "lblVistas";
            lblVistas.Size = new Size(233, 28);
            lblVistas.TabIndex = 17;
            lblVistas.Text = "Vista de la habitacion ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.MediumTurquoise;
            lblPrecio.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(426, 127);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(77, 28);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 272);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(186, 28);
            label1.TabIndex = 19;
            label1.Text = "Tipo de habitacin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(768, 105);
            label2.Name = "label2";
            label2.Size = new Size(368, 28);
            label2.TabIndex = 20;
            label2.Text = "Busqueda por nombre de la persona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.Font = new Font("Times New Roman", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(390, 58);
            label3.TabIndex = 21;
            label3.Text = "SUITE SAVAGE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(741, 0);
            label4.Name = "label4";
            label4.Size = new Size(470, 46);
            label4.TabIndex = 22;
            label4.Text = "Busqueda de reservaciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(839, 244);
            label5.Name = "label5";
            label5.Size = new Size(216, 28);
            label5.TabIndex = 23;
            label5.Text = "Busqueda por fecha ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumTurquoise;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(826, 337);
            label6.Name = "label6";
            label6.Size = new Size(40, 28);
            label6.TabIndex = 24;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumTurquoise;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(998, 337);
            label7.Name = "label7";
            label7.Size = new Size(35, 28);
            label7.TabIndex = 25;
            label7.Text = "Al";
            // 
            // calendario1
            // 
            calendario1.AccessibleRole = AccessibleRole.None;
            calendario1.BackColor = Color.MediumTurquoise;
            calendario1.BackgroundImageLayout = ImageLayout.Zoom;
            calendario1.Image = (Image)resources.GetObject("calendario1.Image");
            calendario1.Location = new Point(883, 307);
            calendario1.Name = "calendario1";
            calendario1.Size = new Size(91, 70);
            calendario1.SizeMode = PictureBoxSizeMode.StretchImage;
            calendario1.TabIndex = 26;
            calendario1.TabStop = false;
            // 
            // calendario2
            // 
            calendario2.AccessibleRole = AccessibleRole.None;
            calendario2.BackColor = Color.MediumTurquoise;
            calendario2.BackgroundImageLayout = ImageLayout.Zoom;
            calendario2.Image = (Image)resources.GetObject("calendario2.Image");
            calendario2.Location = new Point(1064, 307);
            calendario2.Name = "calendario2";
            calendario2.Size = new Size(91, 70);
            calendario2.SizeMode = PictureBoxSizeMode.StretchImage;
            calendario2.TabIndex = 27;
            calendario2.TabStop = false;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.CornflowerBlue;
            btnLimpiarCampos.FlatAppearance.BorderColor = Color.LightCoral;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarCampos.Location = new Point(1484, 244);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(209, 121);
            btnLimpiarCampos.TabIndex = 30;
            btnLimpiarCampos.Text = "Limpiar campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(653, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1064, 231);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 32;
            dateTimePicker2.Visible = false;
            // 
            // ReservacionUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(imgMostrar);
            Controls.Add(calendario2);
            Controls.Add(calendario1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPrecio);
            Controls.Add(lblVistas);
            Controls.Add(imgLimpieza);
            Controls.Add(dataGridViewHabitaciones);
            Controls.Add(txtBusquedaNPersona);
            Controls.Add(txtPrecio);
            Controls.Add(cmbTipo_Habitacion);
            Controls.Add(cmbVista);
            Controls.Add(lblDisponibilidad);
            Controls.Add(cmbDisponibilidad);
            Controls.Add(btnMostrar);
            Margin = new Padding(4);
            Name = "ReservacionUC";
            Size = new Size(1810, 1005);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLimpieza).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendario1).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendario2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnMostrar;
        public ComboBox cmbDisponibilidad;
        private Label lblDisponibilidad;
        private ComboBox cmbVista;
        private ComboBox cmbTipo_Habitacion;
        public TextBox txtPrecio;
        public TextBox txtBusquedaNPersona;
        public DataGridView dataGridViewHabitaciones;
        private PictureBox imgMostrar;
        private PictureBox imgLimpieza;
        private Label lblVistas;
        private Label lblPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public PictureBox calendario1;
        public PictureBox calendario2;
        public Button btnLimpiarCampos;
        public DateTimePicker dateTimePicker1;
        public DateTimePicker dateTimePicker2;
    }
}
