namespace Parcial_III___Hotel.Views
{
    partial class FrmPayWall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPayWall_Pagar = new Button();
            lblPayWall_InfoPago = new Label();
            lblPayWall_CantidadPagar = new Label();
            SuspendLayout();
            // 
            // btnPayWall_Pagar
            // 
            btnPayWall_Pagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayWall_Pagar.Location = new Point(345, 365);
            btnPayWall_Pagar.Name = "btnPayWall_Pagar";
            btnPayWall_Pagar.Size = new Size(103, 38);
            btnPayWall_Pagar.TabIndex = 0;
            btnPayWall_Pagar.Text = "Pagar";
            btnPayWall_Pagar.UseVisualStyleBackColor = true;
            // 
            // lblPayWall_InfoPago
            // 
            lblPayWall_InfoPago.AutoSize = true;
            lblPayWall_InfoPago.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_InfoPago.Location = new Point(24, 23);
            lblPayWall_InfoPago.Name = "lblPayWall_InfoPago";
            lblPayWall_InfoPago.Size = new Size(176, 30);
            lblPayWall_InfoPago.TabIndex = 1;
            lblPayWall_InfoPago.Text = "Cantidad a Pagar:";
            // 
            // lblPayWall_CantidadPagar
            // 
            lblPayWall_CantidadPagar.AutoSize = true;
            lblPayWall_CantidadPagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_CantidadPagar.Location = new Point(223, 23);
            lblPayWall_CantidadPagar.Name = "lblPayWall_CantidadPagar";
            lblPayWall_CantidadPagar.Size = new Size(0, 30);
            lblPayWall_CantidadPagar.TabIndex = 2;
            // 
            // FrmPayWall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPayWall_CantidadPagar);
            Controls.Add(lblPayWall_InfoPago);
            Controls.Add(btnPayWall_Pagar);
            Name = "FrmPayWall";
            Text = "FrmPayWall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnPayWall_Pagar;
        public Label lblPayWall_InfoPago;
        public Label lblPayWall_CantidadPagar;
    }
}