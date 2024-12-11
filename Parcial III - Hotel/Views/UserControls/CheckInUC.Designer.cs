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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnCheckInUC_ConfirmarCheckIn = new Button();
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
            dtgvCheckInUC_Selected.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dtgvCheckInUC_Selected.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvCheckInUC_Selected.Location = new Point(41, 504);
            dtgvCheckInUC_Selected.Name = "dtgvCheckInUC_Selected";
            dtgvCheckInUC_Selected.RowHeadersWidth = 51;
            dtgvCheckInUC_Selected.Size = new Size(1328, 58);
            dtgvCheckInUC_Selected.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Fecha de entrada";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Fecha de salida";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "ID Huesped";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Numero Habitacion";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Estado de paga";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
