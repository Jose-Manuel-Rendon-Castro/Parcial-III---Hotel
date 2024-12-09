using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Controllers.ControllersUC
{
    public class CheckInController
    {
        private CheckInUC _checkInUC;
        public CheckInController(CheckInUC checkInUC)
        {
            _checkInUC = checkInUC;
            _checkInUC.Load += Load;
            _checkInUC.btnCheckInUC_ConfirmarCheckIn.Click += btnCheckInUC_ConfirmarCheckIn_Click;
            _checkInUC.dtgvCheckInUC_Lista.CellContentClick += dtgvCheckInUC_Lista_CellContentClick;
        } 

        private void btnCheckInUC_ConfirmarCheckIn_Click (object? sender, EventArgs e)
        {
            CheckInDAO.UpdateCheckStatus(_checkInUC.dtgvCheckInUC_Selected);
        }

        private void Load (object? sender, EventArgs e)
        {
            CheckInDAO.TablaHuespedes(_checkInUC.dtgvCheckInUC_Lista);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Hacer Check-In";
            btn.Name = "btnCheckInUC_dtgvTransfer";
            btn.Text = "Check";
            btn.UseColumnTextForButtonValue = true;
            _checkInUC.dtgvCheckInUC_Lista.Columns.Add(btn);
        }

        private void dtgvCheckInUC_Lista_CellContentClick (object? sender, DataGridViewCellEventArgs e)
        {
            string col = _checkInUC.dtgvCheckInUC_Lista.Columns[e.ColumnIndex].HeaderText;
            if (col == "Hacer Check-In")
            {
                string? status = _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[_checkInUC.dtgvCheckInUC_Lista.ColumnCount - 1].Value?.ToString();

                if (status != "ACTIVO") {
                    _checkInUC.dtgvCheckInUC_Selected.Rows.Add(
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[1].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[2].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[3].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[4].Value? .ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[5].Value?.ToString(),
                        _checkInUC.dtgvCheckInUC_Lista.Rows[e.RowIndex].Cells[6].Value?.ToString());
                }
                else
                {
                    MessageBox.Show("Habitacion ya se encuentra en uso");
                }
            }
        }
    }
}
