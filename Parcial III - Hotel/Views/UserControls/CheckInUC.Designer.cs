namespace Parcial_III___Hotel.Views.UserControls
{
    partial class CheckInUC
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
            lblCheckInUC_Titulo = new Label();
            panel1 = new Panel();
            dtgvCheckInUC_Lista = new DataGridView();
            dtgvCheckInUC_Selected = new DataGridView();
            btnCheckInUC_ConfirmarCheckIn = new Button();
            ID_Checks = new DataGridViewTextBoxColumn();
            Fecha_Entrada = new DataGridViewTextBoxColumn();
            Fecha_Salida = new DataGridViewTextBoxColumn();
            Id_Huesped = new DataGridViewTextBoxColumn();
            Num_Habitacion = new DataGridViewTextBoxColumn();
            Estado_Checks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvCheckInUC_Lista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCheckInUC_Selected).BeginInit();
            SuspendLayout();
            // 
            // lblCheckInUC_Titulo
            // 
            lblCheckInUC_Titulo.AutoSize = true;
            lblCheckInUC_Titulo.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckInUC_Titulo.ForeColor = Color.CadetBlue;
            lblCheckInUC_Titulo.Location = new Point(0, 0);
            lblCheckInUC_Titulo.Name = "lblCheckInUC_Titulo";
            lblCheckInUC_Titulo.Size = new Size(193, 52);
            lblCheckInUC_Titulo.TabIndex = 0;
            lblCheckInUC_Titulo.Text = "Check-In";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 10);
            panel1.TabIndex = 1;
            // 
            // dtgvCheckInUC_Lista
            // 
            dtgvCheckInUC_Lista.AllowUserToAddRows = false;
            dtgvCheckInUC_Lista.AllowUserToResizeColumns = false;
            dtgvCheckInUC_Lista.BorderStyle = BorderStyle.None;
            dtgvCheckInUC_Lista.ColumnHeadersHeight = 29;
            dtgvCheckInUC_Lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvCheckInUC_Lista.EnableHeadersVisualStyles = false;
            dtgvCheckInUC_Lista.Location = new Point(41, 123);
            dtgvCheckInUC_Lista.Name = "dtgvCheckInUC_Lista";
            dtgvCheckInUC_Lista.ReadOnly = true;
            dtgvCheckInUC_Lista.RowHeadersWidth = 51;
            dtgvCheckInUC_Lista.Size = new Size(1328, 273);
            dtgvCheckInUC_Lista.TabIndex = 2;
            // 
            // dtgvCheckInUC_Selected
            // 
            dtgvCheckInUC_Selected.AllowUserToAddRows = false;
            dtgvCheckInUC_Selected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCheckInUC_Selected.Columns.AddRange(new DataGridViewColumn[] { ID_Checks, Fecha_Entrada, Fecha_Salida, Id_Huesped, Num_Habitacion, Estado_Checks });
            dtgvCheckInUC_Selected.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvCheckInUC_Selected.Location = new Point(41, 504);
            dtgvCheckInUC_Selected.Name = "dtgvCheckInUC_Selected";
            dtgvCheckInUC_Selected.RowHeadersWidth = 51;
            dtgvCheckInUC_Selected.Size = new Size(1328, 58);
            dtgvCheckInUC_Selected.TabIndex = 3;
            // 
            // btnCheckInUC_ConfirmarCheckIn
            // 
            btnCheckInUC_ConfirmarCheckIn.BackColor = SystemColors.ActiveCaption;
            btnCheckInUC_ConfirmarCheckIn.BackgroundImageLayout = ImageLayout.None;
            btnCheckInUC_ConfirmarCheckIn.FlatAppearance.BorderSize = 3;
            btnCheckInUC_ConfirmarCheckIn.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckInUC_ConfirmarCheckIn.Location = new Point(41, 689);
            btnCheckInUC_ConfirmarCheckIn.Name = "btnCheckInUC_ConfirmarCheckIn";
            btnCheckInUC_ConfirmarCheckIn.Size = new Size(437, 81);
            btnCheckInUC_ConfirmarCheckIn.TabIndex = 4;
            btnCheckInUC_ConfirmarCheckIn.Text = "Confirmar Check-In";
            btnCheckInUC_ConfirmarCheckIn.UseVisualStyleBackColor = false;
            // 
            // ID_Checks
            // 
            ID_Checks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID_Checks.HeaderText = "ID";
            ID_Checks.MinimumWidth = 6;
            ID_Checks.Name = "ID_Checks";
            // 
            // Fecha_Entrada
            // 
            Fecha_Entrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha_Entrada.HeaderText = "Fecha de entrada";
            Fecha_Entrada.MinimumWidth = 6;
            Fecha_Entrada.Name = "Fecha_Entrada";
            // 
            // Fecha_Salida
            // 
            Fecha_Salida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha_Salida.HeaderText = "Fecha de salida";
            Fecha_Salida.MinimumWidth = 6;
            Fecha_Salida.Name = "Fecha_Salida";
            // 
            // Id_Huesped
            // 
            Id_Huesped.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id_Huesped.HeaderText = "ID Huesped";
            Id_Huesped.MinimumWidth = 6;
            Id_Huesped.Name = "Id_Huesped";
            // 
            // Num_Habitacion
            // 
            Num_Habitacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Num_Habitacion.HeaderText = "Numero Habitacion";
            Num_Habitacion.MinimumWidth = 6;
            Num_Habitacion.Name = "Num_Habitacion";
            // 
            // Estado_Checks
            // 
            Estado_Checks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado_Checks.HeaderText = "Estado de Check";
            Estado_Checks.MinimumWidth = 6;
            Estado_Checks.Name = "Estado_Checks";
            // 
            // CheckInUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCheckInUC_ConfirmarCheckIn);
            Controls.Add(dtgvCheckInUC_Selected);
            Controls.Add(dtgvCheckInUC_Lista);
            Controls.Add(panel1);
            Controls.Add(lblCheckInUC_Titulo);
            Name = "CheckInUC";
            Size = new Size(1448, 804);
            ((System.ComponentModel.ISupportInitialize)dtgvCheckInUC_Lista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCheckInUC_Selected).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblCheckInUC_Titulo;
        private Panel panel1;
        public Button btnCheckInUC_ConfirmarCheckIn;
        public DataGridView dtgvCheckInUC_Lista;
        public DataGridView dtgvCheckInUC_Selected;
        private DataGridViewTextBoxColumn ID_Checks;
        private DataGridViewTextBoxColumn Fecha_Entrada;
        private DataGridViewTextBoxColumn Fecha_Salida;
        private DataGridViewTextBoxColumn Id_Huesped;
        private DataGridViewTextBoxColumn Num_Habitacion;
        private DataGridViewTextBoxColumn Estado_Checks;
    }
}
