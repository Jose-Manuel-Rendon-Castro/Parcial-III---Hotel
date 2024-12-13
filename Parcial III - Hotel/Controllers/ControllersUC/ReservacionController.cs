using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Exceptions;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_III___Hotel.Controllers.ControllersUC
{
    internal class ReservacionController
    {
        private ReservacionUC _reservacion1;


         public ReservacionController(ReservacionUC reservacion1) 
         {
            _reservacion1 = reservacion1;
           _reservacion1.btnMostrar.Click += BtnMostrar_Click;
             _reservacion1.calendario1.Click += Calendario1_Click;
            _reservacion1.calendario2.Click += Calendario2_Click;
            _reservacion1.calendario1.DoubleClick += Calendario1_DoubleClick;
            _reservacion1.calendario2.DoubleClick += Calendario2_DoubleClick;
            _reservacion1.btnLimpiarCampos.Click += BtnLimpiarCampos_Click;
            

            #region "convertir num en text"
            _reservacion1.numPrecioMin.Text = string.Empty;
            _reservacion1.numPrecioMax.Text = string.Empty;
            #endregion

            #region "combobox_Disponibilidad"
            _reservacion1.cmbDisponibilidad.Items.Add("Disponible");
            _reservacion1.cmbDisponibilidad.Items.Add("Ocupado");
            _reservacion1.cmbDisponibilidad.Items.Add("Todas");
            #endregion

            #region "combobox_Vista"
            _reservacion1.cmbVista.Items.Add("Vista a la ciudad");
            _reservacion1.cmbVista.Items.Add("Vista al mar");
            _reservacion1.cmbVista.Items.Add("Vista a la piscina");
            _reservacion1.cmbVista.Items.Add("Vista al jardin");
            _reservacion1.cmbVista.Items.Add("Vista a la montaña");
            #endregion
            #region "combobox_TipoHabitacion"
            _reservacion1.cmbTipoHabitacion.Items.Add("Habitacion doble");
            _reservacion1.cmbTipoHabitacion.Items.Add("Suite ejecutiva");
            _reservacion1.cmbTipoHabitacion.Items.Add("Habitacion sencilla");
            _reservacion1.cmbTipoHabitacion.Items.Add("Suite familiar");
            _reservacion1.cmbTipoHabitacion.Items.Add("Suite presidencial");
            #endregion




        }


        #region Métodos extras
        private void BtnLimpiarCampos_Click(object? sender, EventArgs e)
        {
            _reservacion1.cmbDisponibilidad.Items.Clear();
            _reservacion1.cmbTipoHabitacion.Items.Clear();
            _reservacion1.cmbVista.Items.Clear();
            _reservacion1.txtBusquedaNPersona.Clear();
          
        }
        #endregion

        private void Calendario2_DoubleClick(object? sender, EventArgs e)
        {
            _reservacion1.dateTimePicker2.Visible = false;
        }

        private void Calendario1_DoubleClick(object? sender, EventArgs e)
        {
            _reservacion1.dateTimePicker1.Visible = false;
        }

        private void Calendario2_Click(object? sender, EventArgs e)
         {
             _reservacion1.dateTimePicker2.Visible = true;
         }

         private void Calendario1_Click(object? sender, EventArgs e)
         {
             _reservacion1.dateTimePicker1.Visible = true;
         }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string precioMin = string.IsNullOrEmpty(_reservacion1.numPrecioMin.Text) ? null : _reservacion1.numPrecioMin.Text;
                string precioMax = string.IsNullOrEmpty(_reservacion1.numPrecioMax.Text) ? null : _reservacion1.numPrecioMax.Text;

                if (!string.IsNullOrEmpty(precioMin) && !decimal.TryParse(precioMin, out _))
                {
                    MessageBox.Show("El precio mínimo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(precioMax) && !decimal.TryParse(precioMax, out _))
                {
                    MessageBox.Show("El precio máximo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(precioMin) && !string.IsNullOrEmpty(precioMax) && decimal.Parse(precioMin) > decimal.Parse(precioMax))
                {
                    MessageBox.Show("El precio mínimo no puede ser mayor que el precio máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ReservacionUCDAO.MostrarTabla(
                    _reservacion1.dataGridViewHabitaciones,
                    "HabitacionPorHuesped",
                    precioMin,
                    precioMax,
                    _reservacion1.cmbDisponibilidad.Text == "Todas" ? null : _reservacion1.cmbDisponibilidad.Text,
                    _reservacion1.cmbVista.Text,
                    _reservacion1.cmbTipoHabitacion.Text,
                    _reservacion1.txtBusquedaNPersona.Text
                );

                if (_reservacion1.dataGridViewHabitaciones.RowCount == 0)
                {
                    MessageBox.Show("No se encontraron datos", "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
} 
    
// 9:27 am