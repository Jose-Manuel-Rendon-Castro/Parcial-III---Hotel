﻿namespace Parcial_III___Hotel.Views
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
            lblPayWall_MetodoPago = new Label();
            msktxtboxPayWall_NumTarjeta = new MaskedTextBox();
            msktxtboxPayWall_FechaV = new MaskedTextBox();
            lblPayWall_NumT = new Label();
            lblPayWall_FechaV = new Label();
            msktxtboxPayWall_CVV = new MaskedTextBox();
            lblPayWall_CVV = new Label();
            msktxtboxPayWall_Pago = new MaskedTextBox();
            lblPayWall_Pago = new Label();
            lblPayWall_Cambio = new Label();
            lblPayWall_Vuelto = new Label();
            lblPayWall_NombreTitular = new Label();
            msktxtboxPayWall_NombreTitular = new MaskedTextBox();
            lblPayWall_MsjError = new Label();
            SuspendLayout();
            // 
            // btnPayWall_Pagar
            // 
            btnPayWall_Pagar.BackColor = SystemColors.ControlLightLight;
            btnPayWall_Pagar.Enabled = false;
            btnPayWall_Pagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayWall_Pagar.Location = new Point(394, 520);
            btnPayWall_Pagar.Margin = new Padding(3, 4, 3, 4);
            btnPayWall_Pagar.Name = "btnPayWall_Pagar";
            btnPayWall_Pagar.Size = new Size(252, 51);
            btnPayWall_Pagar.TabIndex = 0;
            btnPayWall_Pagar.Text = "Pagar y Confirmar";
            btnPayWall_Pagar.UseVisualStyleBackColor = false;
            // 
            // lblPayWall_InfoPago
            // 
            lblPayWall_InfoPago.AutoSize = true;
            lblPayWall_InfoPago.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_InfoPago.Location = new Point(34, 164);
            lblPayWall_InfoPago.Name = "lblPayWall_InfoPago";
            lblPayWall_InfoPago.Size = new Size(224, 31);
            lblPayWall_InfoPago.TabIndex = 1;
            lblPayWall_InfoPago.Text = "Cantidad a Pagar:";
            // 
            // lblPayWall_CantidadPagar
            // 
            lblPayWall_CantidadPagar.AutoSize = true;
            lblPayWall_CantidadPagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_CantidadPagar.Location = new Point(34, 204);
            lblPayWall_CantidadPagar.Name = "lblPayWall_CantidadPagar";
            lblPayWall_CantidadPagar.Size = new Size(0, 37);
            lblPayWall_CantidadPagar.TabIndex = 2;
            // 
            // cmboxPayWall_TipoPago
            // 
            cmboxPayWall_TipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxPayWall_TipoPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmboxPayWall_TipoPago.FormattingEnabled = true;
            cmboxPayWall_TipoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmboxPayWall_TipoPago.Location = new Point(34, 87);
            cmboxPayWall_TipoPago.Margin = new Padding(3, 4, 3, 4);
            cmboxPayWall_TipoPago.Name = "cmboxPayWall_TipoPago";
            cmboxPayWall_TipoPago.Size = new Size(140, 36);
            cmboxPayWall_TipoPago.TabIndex = 3;
            // 
            // lblPayWall_InfoTarjeta
            // 
            lblPayWall_InfoTarjeta.AutoSize = true;
            lblPayWall_InfoTarjeta.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_InfoTarjeta.Location = new Point(503, 43);
            lblPayWall_InfoTarjeta.Name = "lblPayWall_InfoTarjeta";
            lblPayWall_InfoTarjeta.Size = new Size(343, 35);
            lblPayWall_InfoTarjeta.TabIndex = 4;
            lblPayWall_InfoTarjeta.Text = "Información de la Tarjeta";
            lblPayWall_InfoTarjeta.Visible = false;
            // 
            // lblPayWall_MetodoPago
            // 
            lblPayWall_MetodoPago.AutoSize = true;
            lblPayWall_MetodoPago.Font = new Font("Gadugi", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_MetodoPago.Location = new Point(34, 43);
            lblPayWall_MetodoPago.Name = "lblPayWall_MetodoPago";
            lblPayWall_MetodoPago.Size = new Size(296, 45);
            lblPayWall_MetodoPago.TabIndex = 5;
            lblPayWall_MetodoPago.Text = "Método de Pago";
            // 
            // msktxtboxPayWall_NumTarjeta
            // 
            msktxtboxPayWall_NumTarjeta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_NumTarjeta.Location = new Point(576, 164);
            msktxtboxPayWall_NumTarjeta.Margin = new Padding(3, 4, 3, 4);
            msktxtboxPayWall_NumTarjeta.Mask = "0000-0000-0000-0000";
            msktxtboxPayWall_NumTarjeta.Name = "msktxtboxPayWall_NumTarjeta";
            msktxtboxPayWall_NumTarjeta.PromptChar = 'X';
            msktxtboxPayWall_NumTarjeta.Size = new Size(201, 34);
            msktxtboxPayWall_NumTarjeta.TabIndex = 7;
            msktxtboxPayWall_NumTarjeta.Visible = false;
            // 
            // msktxtboxPayWall_FechaV
            // 
            msktxtboxPayWall_FechaV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_FechaV.Location = new Point(576, 261);
            msktxtboxPayWall_FechaV.Margin = new Padding(3, 4, 3, 4);
            msktxtboxPayWall_FechaV.Mask = "00/00";
            msktxtboxPayWall_FechaV.Name = "msktxtboxPayWall_FechaV";
            msktxtboxPayWall_FechaV.PromptChar = 'X';
            msktxtboxPayWall_FechaV.Size = new Size(60, 34);
            msktxtboxPayWall_FechaV.TabIndex = 8;
            msktxtboxPayWall_FechaV.Visible = false;
            // 
            // lblPayWall_NumT
            // 
            lblPayWall_NumT.AutoSize = true;
            lblPayWall_NumT.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_NumT.Location = new Point(576, 116);
            lblPayWall_NumT.Name = "lblPayWall_NumT";
            lblPayWall_NumT.Size = new Size(166, 31);
            lblPayWall_NumT.TabIndex = 9;
            lblPayWall_NumT.Text = "Num. Tarjeta";
            lblPayWall_NumT.Visible = false;
            // 
            // lblPayWall_FechaV
            // 
            lblPayWall_FechaV.AutoSize = true;
            lblPayWall_FechaV.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_FechaV.Location = new Point(576, 223);
            lblPayWall_FechaV.Name = "lblPayWall_FechaV";
            lblPayWall_FechaV.Size = new Size(107, 31);
            lblPayWall_FechaV.TabIndex = 10;
            lblPayWall_FechaV.Text = "MM/AA";
            lblPayWall_FechaV.Visible = false;
            // 
            // msktxtboxPayWall_CVV
            // 
            msktxtboxPayWall_CVV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_CVV.Location = new Point(717, 261);
            msktxtboxPayWall_CVV.Margin = new Padding(3, 4, 3, 4);
            msktxtboxPayWall_CVV.Mask = "000/0";
            msktxtboxPayWall_CVV.Name = "msktxtboxPayWall_CVV";
            msktxtboxPayWall_CVV.PromptChar = 'X';
            msktxtboxPayWall_CVV.Size = new Size(60, 34);
            msktxtboxPayWall_CVV.TabIndex = 11;
            msktxtboxPayWall_CVV.Visible = false;
            // 
            // lblPayWall_CVV
            // 
            lblPayWall_CVV.AutoSize = true;
            lblPayWall_CVV.BackColor = Color.Transparent;
            lblPayWall_CVV.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_CVV.Location = new Point(717, 223);
            lblPayWall_CVV.Name = "lblPayWall_CVV";
            lblPayWall_CVV.Size = new Size(65, 31);
            lblPayWall_CVV.TabIndex = 12;
            lblPayWall_CVV.Text = "CVV";
            lblPayWall_CVV.Visible = false;
            // 
            // msktxtboxPayWall_Pago
            // 
            msktxtboxPayWall_Pago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_Pago.Location = new Point(34, 313);
            msktxtboxPayWall_Pago.Margin = new Padding(3, 4, 3, 4);
            msktxtboxPayWall_Pago.Mask = "00000";
            msktxtboxPayWall_Pago.Name = "msktxtboxPayWall_Pago";
            msktxtboxPayWall_Pago.Size = new Size(107, 34);
            msktxtboxPayWall_Pago.TabIndex = 13;
            msktxtboxPayWall_Pago.Visible = false;
            // 
            // lblPayWall_Pago
            // 
            lblPayWall_Pago.AutoSize = true;
            lblPayWall_Pago.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_Pago.Location = new Point(34, 269);
            lblPayWall_Pago.Name = "lblPayWall_Pago";
            lblPayWall_Pago.Size = new Size(129, 31);
            lblPayWall_Pago.TabIndex = 14;
            lblPayWall_Pago.Text = "Paga con:";
            lblPayWall_Pago.Visible = false;
            // 
            // lblPayWall_Cambio
            // 
            lblPayWall_Cambio.AutoSize = true;
            lblPayWall_Cambio.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_Cambio.Location = new Point(34, 404);
            lblPayWall_Cambio.Name = "lblPayWall_Cambio";
            lblPayWall_Cambio.Size = new Size(246, 31);
            lblPayWall_Cambio.TabIndex = 16;
            lblPayWall_Cambio.Text = "Cambio a Devolver:";
            lblPayWall_Cambio.Visible = false;
            // 
            // lblPayWall_Vuelto
            // 
            lblPayWall_Vuelto.AutoSize = true;
            lblPayWall_Vuelto.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_Vuelto.Location = new Point(34, 468);
            lblPayWall_Vuelto.Name = "lblPayWall_Vuelto";
            lblPayWall_Vuelto.Size = new Size(261, 72);
            lblPayWall_Vuelto.TabIndex = 17;
            lblPayWall_Vuelto.Text = "Presione le tecla 'Enter' en el \r\npago ingresado para \r\nobtener el cambio.";
            lblPayWall_Vuelto.TextAlign = ContentAlignment.TopCenter;
            lblPayWall_Vuelto.Visible = false;
            // 
            // lblPayWall_NombreTitular
            // 
            lblPayWall_NombreTitular.AutoSize = true;
            lblPayWall_NombreTitular.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayWall_NombreTitular.Location = new Point(530, 339);
            lblPayWall_NombreTitular.Name = "lblPayWall_NombreTitular";
            lblPayWall_NombreTitular.Size = new Size(391, 31);
            lblPayWall_NombreTitular.TabIndex = 18;
            lblPayWall_NombreTitular.Text = "Nombre del Titular de la Tarjeta";
            lblPayWall_NombreTitular.Visible = false;
            // 
            // msktxtboxPayWall_NombreTitular
            // 
            msktxtboxPayWall_NombreTitular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msktxtboxPayWall_NombreTitular.Location = new Point(530, 377);
            msktxtboxPayWall_NombreTitular.Margin = new Padding(3, 4, 3, 4);
            msktxtboxPayWall_NombreTitular.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            msktxtboxPayWall_NombreTitular.Name = "msktxtboxPayWall_NombreTitular";
            msktxtboxPayWall_NombreTitular.Size = new Size(345, 34);
            msktxtboxPayWall_NombreTitular.TabIndex = 19;
            msktxtboxPayWall_NombreTitular.Visible = false;
            // 
            // lblPayWall_MsjError
            // 
            lblPayWall_MsjError.AutoSize = true;
            lblPayWall_MsjError.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayWall_MsjError.ForeColor = Color.Red;
            lblPayWall_MsjError.Location = new Point(530, 441);
            lblPayWall_MsjError.Name = "lblPayWall_MsjError";
            lblPayWall_MsjError.Size = new Size(0, 24);
            lblPayWall_MsjError.TabIndex = 20;
            lblPayWall_MsjError.TextAlign = ContentAlignment.TopCenter;
            lblPayWall_MsjError.Visible = false;
            // 
            // FrmPayWall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(lblPayWall_MsjError);
            Controls.Add(msktxtboxPayWall_NombreTitular);
            Controls.Add(lblPayWall_NombreTitular);
            Controls.Add(lblPayWall_Vuelto);
            Controls.Add(lblPayWall_Cambio);
            Controls.Add(lblPayWall_Pago);
            Controls.Add(msktxtboxPayWall_Pago);
            Controls.Add(lblPayWall_CVV);
            Controls.Add(msktxtboxPayWall_CVV);
            Controls.Add(lblPayWall_FechaV);
            Controls.Add(lblPayWall_NumT);
            Controls.Add(msktxtboxPayWall_FechaV);
            Controls.Add(msktxtboxPayWall_NumTarjeta);
            Controls.Add(lblPayWall_MetodoPago);
            Controls.Add(lblPayWall_InfoTarjeta);
            Controls.Add(cmboxPayWall_TipoPago);
            Controls.Add(lblPayWall_CantidadPagar);
            Controls.Add(lblPayWall_InfoPago);
            Controls.Add(btnPayWall_Pagar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPayWall";
            Text = "Formulario De Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnPayWall_Pagar;
        public Label lblPayWall_InfoPago;
        public Label lblPayWall_CantidadPagar;
        public ComboBox cmboxPayWall_TipoPago;
        public Label lblPayWall_InfoTarjeta;
        private Label lblPayWall_MetodoPago;
        public MaskedTextBox msktxtboxPayWall_NumTarjeta;
        public MaskedTextBox msktxtboxPayWall_FechaV;
        public Label lblPayWall_NumT;
        public Label lblPayWall_FechaV;
        public MaskedTextBox msktxtboxPayWall_CVV;
        public Label lblPayWall_CVV;
        public MaskedTextBox msktxtboxPayWall_Pago;
        public Label lblPayWall_Pago;
        public Label lblPayWall_Cambio;
        public Label lblPayWall_Vuelto;
        public Label lblPayWall_NombreTitular;
        public MaskedTextBox maskedTextBox1;
        public MaskedTextBox msktxtboxPayWall_NombreTitular;
        public ToolTip toolTip1;
        public Label lblPayWall_MsjError;
    }
}