﻿using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Controllers.ControllersUC
{
    public class CheckInController
    {
        private CheckInUC _checkInUC;
        private MediadorPayWall _mediadorPayWall;
        public CheckInController(CheckInUC checkInUC, MediadorPayWall mediadorPayWall)
        {
            _checkInUC = checkInUC;
            _checkInUC.Load += Load;
            _checkInUC.btnCheckInUC_ConfirmarCheckIn.Click += btnCheckInUC_ConfirmarCheckIn_Click;
            _checkInUC.btnCheckInUC_Refresh.Click += btnCheckInUC_Refresh_Click;
            _checkInUC.dtgvCheckInUC_Lista.CellContentClick += dtgvCheckInUC_Lista_CellContentClick;
            _mediadorPayWall = mediadorPayWall;
        } 

        private void updateTable()
        {
            foreach (DataGridViewRow row in _checkInUC.dtgvCheckInUC_Lista.Rows)
            {
                string? status = row.Cells["Estado_Checks"].Value?.ToString();
                if (status == "IN")
                {
                    row.Cells["Estado_Checks"].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells["Estado_Checks"].Style.ForeColor = Color.Red;
                }
            }
            _checkInUC.dtgvCheckInUC_Lista.Invalidate();
        }

        private void btnCheckInUC_ConfirmarCheckIn_Click (object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in _checkInUC.dtgvCheckInUC_Selected.Rows)
            {
                string? status = row.Cells["Estado_Checks"].Value?.ToString();
                if (status == "En Check In")
                {
                    MessageBox.Show("Pago Requerido Antes de Check In");
                    decimal Id_Check = Convert.ToDecimal(row.Cells["ID_Checks"].Value);
                    
                    _mediadorPayWall.NotificarPagoRequerido(Id_Check);
                }
            }
            CheckInDAO.UpdateCheckStatus(_checkInUC.dtgvCheckInUC_Selected);
            _checkInUC.dtgvCheckInUC_Selected.Rows.Clear();
            Load(sender, e);
        }
        
        private void btnCheckInUC_Refresh_Click (object? sender, EventArgs e)
        {
            Load(sender, e);
        }

        public void Load (object? sender, EventArgs e)
        {
            CheckInDAO.TablaHuespedes(_checkInUC.dtgvCheckInUC_Lista);
            updateTable();
            if (!_checkInUC.dtgvCheckInUC_Lista.Columns.Contains("btnCheckInUC_dtgvTransfer"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Hacer Check-In";
                btn.Name = "btnCheckInUC_dtgvTransfer";
                btn.Text = "Check";
                btn.UseColumnTextForButtonValue = true;

                // Añadir el botón como una nueva columna a la tabla
                _checkInUC.dtgvCheckInUC_Lista.Columns.Add(btn);
            }
        }

        private void dtgvCheckInUC_Lista_CellContentClick (object? sender, DataGridViewCellEventArgs e)
        {
            if (_checkInUC.dtgvCheckInUC_Selected != null)
            {
                _checkInUC.dtgvCheckInUC_Selected.Rows.Clear();
            }
            string col = _checkInUC.dtgvCheckInUC_Lista.Columns[e.ColumnIndex].HeaderText;
            if (col == "Hacer Check-In")
            {

                //Obtener el estado de la fila seleccionada
                string? status = _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["Estado_Checks"].Value?.ToString();

                if (status != "IN") {
                    _checkInUC.dtgvCheckInUC_Selected.Rows.Add(
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["ID_Checks"].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["Fecha_Entrada"].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["Fecha_Salida"].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["Huesped_Id"].Value? .ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["NumHabitacion"].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells["Estado_Checks"].Value?.ToString());
                }
                else
                {
                    MessageBox.Show("Habitación en uso");
                }
            }
        }
    }
}
