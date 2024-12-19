using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_III___Hotel.Controllers.ControllersUC
{
    public class CheckOutController
    {
        private CheckOutUC _checkOutUC;

        public CheckOutController(CheckOutUC checkOutUC)
        {
            _checkOutUC = checkOutUC;
            _checkOutUC.Load += Load;
            _checkOutUC.btnCheckOutUC_ConfirmarCheckOut.Click += btnCheckOutUC_ConfirmarCheckOut_Click;
            _checkOutUC.btnCheckOutUC_Refresh.Click += btnCheckOut_Refresh_Click;
            _checkOutUC.dtgvCheckOutUC_Lista.CellContentClick += dtgvCheckOutUC_Lista_CellContentClick;
        }

        private void updateTable()
        {
            foreach (DataGridViewRow row in _checkOutUC.dtgvCheckOutUC_Lista.Rows)
            {
                string? status = row.Cells["Estado_Checks"].Value?.ToString();
                if (status == "OUT")
                {
                    row.Cells["Estado_Checks"].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells["Estado_Checks"].Style.ForeColor = Color.Red;
                }
            }
            _checkOutUC.dtgvCheckOutUC_Lista.Invalidate();
        }

        private void btnCheckOutUC_ConfirmarCheckOut_Click(object? sender, EventArgs e)
        {
            CheckOutDAO.UpdateCheckStatus(_checkOutUC.dtgvCheckOutUC_Selected);
            _checkOutUC.dtgvCheckOutUC_Selected.Rows.Clear();
            Load(sender, e);
        }

        private void btnCheckOut_Refresh_Click (object? sender, EventArgs e)
        {
            Load(sender, e);
        }

        public void Load(object? sender, EventArgs e)
        {
            CheckOutDAO.TablaHuespedes(_checkOutUC.dtgvCheckOutUC_Lista);
            updateTable();
            if (!_checkOutUC.dtgvCheckOutUC_Lista.Columns.Contains("btnCheckOutUC_dtgvTransfer"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Width = 130;
                btn.HeaderText = "Hacer Check-Out";
                btn.Name = "btnCheckOutUC_dtgvTransfer";
                btn.Text = "Check";
                btn.UseColumnTextForButtonValue = true;

                //Se añade el boton a la nueva columna de la tabla
                _checkOutUC.dtgvCheckOutUC_Lista.Columns.Add(btn);
            }
        }

        private void dtgvCheckOutUC_Lista_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (_checkOutUC.dtgvCheckOutUC_Selected != null)
            {
                _checkOutUC.dtgvCheckOutUC_Selected.Rows.Clear();
            }
            string col = _checkOutUC.dtgvCheckOutUC_Lista.Columns[e.ColumnIndex].HeaderText;
            if (col == "Hacer Check-Out")
            {

                //Obtener el estado de la fila seleccionada
                string? status = _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["Estado_Checks"].Value?.ToString();

                if (status != "OUT")
                {
                    _checkOutUC.dtgvCheckOutUC_Selected.Rows.Add(
                        _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["ID_Checks"].Value?.ToString(),
                        _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["Fecha_Entrada"].Value?.ToString(),
                        _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["Fecha_Salida"].Value?.ToString(),
                        _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["Huesped_Id"].Value?.ToString(),
                        _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["NumHabitacion"].Value?.ToString(),
                        _checkOutUC.dtgvCheckOutUC_Lista.Rows[e.RowIndex].Cells["Estado_Checks"].Value?.ToString());
                }
                else
                {
                    MessageBox.Show("Habitación desocupada");
                }
            }
        }
    }
}
