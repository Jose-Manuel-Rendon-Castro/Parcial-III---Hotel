namespace Parcial_III___Hotel.Views.UserControls
{
    partial class CheckOutUC
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
            btnCheckOutUC_ConfirmarCheckOut = new Button();
            dtgvCheckOutUC_Selected = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dtgvCheckOutUC_Lista = new DataGridView();
            panel1 = new Panel();
            lblCheckOutUC_Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvCheckOutUC_Selected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCheckOutUC_Lista).BeginInit();
            SuspendLayout();
            // 
            // btnCheckOutUC_ConfirmarCheckOut
            // 
            btnCheckOutUC_ConfirmarCheckOut.BackColor = SystemColors.ActiveCaption;
            btnCheckOutUC_ConfirmarCheckOut.BackgroundImageLayout = ImageLayout.None;
            btnCheckOutUC_ConfirmarCheckOut.FlatAppearance.BorderSize = 3;
            btnCheckOutUC_ConfirmarCheckOut.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOutUC_ConfirmarCheckOut.Location = new Point(41, 689);
            btnCheckOutUC_ConfirmarCheckOut.Name = "btnCheckOutUC_ConfirmarCheckOut";
            btnCheckOutUC_ConfirmarCheckOut.Size = new Size(437, 81);
            btnCheckOutUC_ConfirmarCheckOut.TabIndex = 9;
            btnCheckOutUC_ConfirmarCheckOut.Text = "Confirmar Check-In";
            btnCheckOutUC_ConfirmarCheckOut.UseVisualStyleBackColor = false;
            // 
            // dtgvCheckOutUC_Selected
            // 
            dtgvCheckOutUC_Selected.AllowUserToAddRows = false;
            dtgvCheckOutUC_Selected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCheckOutUC_Selected.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Column4, Column5, Column6 });
            dtgvCheckOutUC_Selected.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvCheckOutUC_Selected.Location = new Point(41, 504);
            dtgvCheckOutUC_Selected.Name = "dtgvCheckOutUC_Selected";
            dtgvCheckOutUC_Selected.RowHeadersWidth = 51;
            dtgvCheckOutUC_Selected.Size = new Size(1328, 58);
            dtgvCheckOutUC_Selected.TabIndex = 8;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
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
            Column6.HeaderText = "Estado de Check";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // dtgvCheckOutUC_Lista
            // 
            dtgvCheckOutUC_Lista.AllowUserToAddRows = false;
            dtgvCheckOutUC_Lista.AllowUserToResizeColumns = false;
            dtgvCheckOutUC_Lista.BorderStyle = BorderStyle.None;
            dtgvCheckOutUC_Lista.ColumnHeadersHeight = 29;
            dtgvCheckOutUC_Lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvCheckOutUC_Lista.EnableHeadersVisualStyles = false;
            dtgvCheckOutUC_Lista.Location = new Point(41, 123);
            dtgvCheckOutUC_Lista.Name = "dtgvCheckOutUC_Lista";
            dtgvCheckOutUC_Lista.ReadOnly = true;
            dtgvCheckOutUC_Lista.RowHeadersWidth = 51;
            dtgvCheckOutUC_Lista.Size = new Size(1328, 273);
            dtgvCheckOutUC_Lista.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 10);
            panel1.TabIndex = 6;
            // 
            // lblCheckOutUC_Titulo
            // 
            lblCheckOutUC_Titulo.AutoSize = true;
            lblCheckOutUC_Titulo.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckOutUC_Titulo.ForeColor = Color.CadetBlue;
            lblCheckOutUC_Titulo.Location = new Point(0, 0);
            lblCheckOutUC_Titulo.Name = "lblCheckOutUC_Titulo";
            lblCheckOutUC_Titulo.Size = new Size(229, 52);
            lblCheckOutUC_Titulo.TabIndex = 5;
            lblCheckOutUC_Titulo.Text = "Check-Out";
            // 
            // CheckOutUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCheckOutUC_ConfirmarCheckOut);
            Controls.Add(dtgvCheckOutUC_Selected);
            Controls.Add(dtgvCheckOutUC_Lista);
            Controls.Add(panel1);
            Controls.Add(lblCheckOutUC_Titulo);
            Name = "CheckOutUC";
            Size = new Size(1448, 804);
            ((System.ComponentModel.ISupportInitialize)dtgvCheckOutUC_Selected).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCheckOutUC_Lista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnCheckOutUC_ConfirmarCheckOut;
        public DataGridView dtgvCheckOutUC_Selected;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public DataGridView dtgvCheckOutUC_Lista;
        private Panel panel1;
        protected Label lblCheckOutUC_Titulo;
    }
}
