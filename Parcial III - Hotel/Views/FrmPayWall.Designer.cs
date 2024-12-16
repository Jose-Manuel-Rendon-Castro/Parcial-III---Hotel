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
            cmboxPayWall_TipoPago = new ComboBox();
            lblPayWall_InfoTarjeta = new Label();
            label1 = new Label();
            msktxtboxPayWall_NumTarjeta = new MaskedTextBox();
            msktxtboxPayWall_FechaV = new MaskedTextBox();
            lblPayWall_NumT = new Label();
            lblPayWall_FechaVCVV = new Label();
            msktxtboxPayWall_CVV = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnPayWall_Pagar
            // 
            btnPayWall_Pagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayWall_Pagar.Location = new Point(237, 365);
            btnPayWall_Pagar.Name = "btnPayWall_Pagar";
            btnPayWall_Pagar.Size = new Size(211, 38);
            btnPayWall_Pagar.TabIndex = 0;
            btnPayWall_Pagar.Text = "Pagar y Confirmar";
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
            // cmboxPayWall_TipoPago
            // 
            cmboxPayWall_TipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxPayWall_TipoPago.FormattingEnabled = true;
            cmboxPayWall_TipoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmboxPayWall_TipoPago.Location = new Point(24, 107);
            cmboxPayWall_TipoPago.Name = "cmboxPayWall_TipoPago";
            cmboxPayWall_TipoPago.Size = new Size(123, 23);
            cmboxPayWall_TipoPago.TabIndex = 3;
            // 
            // lblPayWall_InfoTarjeta
            // 
            lblPayWall_InfoTarjeta.AutoSize = true;
            lblPayWall_InfoTarjeta.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_InfoTarjeta.Location = new Point(24, 158);
            lblPayWall_InfoTarjeta.Name = "lblPayWall_InfoTarjeta";
            lblPayWall_InfoTarjeta.Size = new Size(222, 26);
            lblPayWall_InfoTarjeta.TabIndex = 4;
            lblPayWall_InfoTarjeta.Text = "Información de la Tarjeta";
            lblPayWall_InfoTarjeta.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 74);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 5;
            label1.Text = "Método de Pago";
            // 
            // msktxtboxPayWall_NumTarjeta
            // 
            msktxtboxPayWall_NumTarjeta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_NumTarjeta.Location = new Point(24, 231);
            msktxtboxPayWall_NumTarjeta.Mask = "0000-0000-0000-0000";
            msktxtboxPayWall_NumTarjeta.Name = "msktxtboxPayWall_NumTarjeta";
            msktxtboxPayWall_NumTarjeta.PromptChar = 'X';
            msktxtboxPayWall_NumTarjeta.Size = new Size(176, 29);
            msktxtboxPayWall_NumTarjeta.TabIndex = 7;
            msktxtboxPayWall_NumTarjeta.Text = "1234123412341234";
            msktxtboxPayWall_NumTarjeta.Visible = false;
            // 
            // msktxtboxPayWall_FechaV
            // 
            msktxtboxPayWall_FechaV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_FechaV.Location = new Point(24, 269);
            msktxtboxPayWall_FechaV.Mask = "00/00";
            msktxtboxPayWall_FechaV.Name = "msktxtboxPayWall_FechaV";
            msktxtboxPayWall_FechaV.PromptChar = 'X';
            msktxtboxPayWall_FechaV.Size = new Size(53, 29);
            msktxtboxPayWall_FechaV.TabIndex = 8;
            msktxtboxPayWall_FechaV.Visible = false;
            // 
            // lblPayWall_NumT
            // 
            lblPayWall_NumT.AutoSize = true;
            lblPayWall_NumT.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_NumT.Location = new Point(24, 195);
            lblPayWall_NumT.Name = "lblPayWall_NumT";
            lblPayWall_NumT.Size = new Size(157, 33);
            lblPayWall_NumT.TabIndex = 9;
            lblPayWall_NumT.Text = "Num. Tarjeta";
            lblPayWall_NumT.Visible = false;
            // 
            // lblPayWall_FechaVCVV
            // 
            lblPayWall_FechaVCVV.AutoSize = true;
            lblPayWall_FechaVCVV.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_FechaVCVV.Location = new Point(12, 311);
            lblPayWall_FechaVCVV.Name = "lblPayWall_FechaVCVV";
            lblPayWall_FechaVCVV.Size = new Size(225, 26);
            lblPayWall_FechaVCVV.TabIndex = 10;
            lblPayWall_FechaVCVV.Text = "Fecha Vencimiento / CVV";
            lblPayWall_FechaVCVV.Visible = false;
            // 
            // msktxtboxPayWall_CVV
            // 
            msktxtboxPayWall_CVV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_CVV.Location = new Point(94, 269);
            msktxtboxPayWall_CVV.Mask = "000/0";
            msktxtboxPayWall_CVV.Name = "msktxtboxPayWall_CVV";
            msktxtboxPayWall_CVV.PromptChar = 'X';
            msktxtboxPayWall_CVV.Size = new Size(53, 29);
            msktxtboxPayWall_CVV.TabIndex = 11;
            msktxtboxPayWall_CVV.Visible = false;
            // 
            // FrmPayWall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msktxtboxPayWall_CVV);
            Controls.Add(lblPayWall_FechaVCVV);
            Controls.Add(lblPayWall_NumT);
            Controls.Add(msktxtboxPayWall_FechaV);
            Controls.Add(msktxtboxPayWall_NumTarjeta);
            Controls.Add(label1);
            Controls.Add(lblPayWall_InfoTarjeta);
            Controls.Add(cmboxPayWall_TipoPago);
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
        public ComboBox cmboxPayWall_TipoPago;
        public Label lblPayWall_InfoTarjeta;
        private Label label1;
        public MaskedTextBox msktxtboxPayWall_NumTarjeta;
        public MaskedTextBox msktxtboxPayWall_FechaV;
        public Label lblPayWall_NumT;
        public Label lblPayWall_FechaVCVV;
        public MaskedTextBox msktxtboxPayWall_CVV;
    }
}